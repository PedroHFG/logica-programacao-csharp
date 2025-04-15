using SistemaCursos.Entities;
using SistemaCursos.Enums;
using SistemaCursos.Exceptions;
using SistemaCursos.Repositories;
using SistemaCursos.Services;

namespace SistemaCursos;

public class Program
{
    static void Main(string[] args)
    {
        // Initial configs
        Boolean estaRodando = true;
        List<Aluno> alunos = new List<Aluno>();
        List<Curso> cursos = new List<Curso>();
        string pastaAtual = Directory.GetCurrentDirectory();
        string pastaRepositorio = "Repositorio";
        Directory.CreateDirectory($"{pastaAtual}/{pastaRepositorio}");
        string arquivoAlunos = $"{pastaRepositorio}/RepositorioAluno.csv";
        string arquivoCursos = $"{pastaRepositorio}/RepositorioCurso.csv";
        string arquivoMatriculas = $"{pastaRepositorio}/RepositorioMatriula.csv";
        List<string> arquivos = new List<string> { arquivoAlunos, arquivoCursos, arquivoMatriculas };

        CriarRepositorioSeNaoExistir(arquivos);

        while (estaRodando)
        {
            try
            {
                MostrarMenu();
                Console.Write("Escolha uma opção: ");
                int opcaoPrincipal = int.Parse(Console.ReadLine());

                switch (opcaoPrincipal)
                {
                    case 1:
                        Console.Clear();
                        CadastrarCurso(arquivoCursos);
                        break;

                    case 2:
                        Console.Clear();
                        ListarCursos(arquivoCursos);
                        break;

                    case 3:
                        Console.Clear();
                        CadastrarAluno(arquivoAlunos);
                        break;

                    case 4:
                        Console.Clear();
                        ListarAlunos(arquivoAlunos);
                        break;

                    case 5:
                        Console.Clear();
                        Matricular(arquivoAlunos, arquivoCursos);
                        break;

                    case 6:
                        Console.Clear();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Finalizando o programa!");
                        estaRodando = false;
                        break;

                    default:
                        break;
                }
            }
            catch (NivelInvalidoException ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            catch (EmailExistenteException ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
        }
    }

    static void CriarRepositorioSeNaoExistir(List<string> arquivos)
    {
        foreach (string arquivo in arquivos)
        {
            if (!File.Exists(arquivo))
            {
                string cabecalho;
                
                if (arquivo.Contains("Aluno"))
                {
                    cabecalho = "Id;Nome;Email";
                }
                else if (arquivo.Contains("Curso"))
                {
                    cabecalho = "Id;Titulo;Nivel";
                }
                else
                {
                    cabecalho = "AlunoId;CursoId;Status;DataMatricula";
                }
                
                using (StreamWriter sw = new StreamWriter(arquivo))
                {
                    sw.WriteLine(cabecalho);
                }
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine("[1] CADASTRAR CURSO");
        Console.WriteLine("[2] LISTAR CURSOS");
        Console.WriteLine("[3] CADASTRAR ALUNOS");
        Console.WriteLine("[4] LISTAR ALUNOS");
        Console.WriteLine("[5] MATRICULAR ALUNO");
        Console.WriteLine("[6] LIMPAR CONSOLE");
        Console.WriteLine("[7] SAIR\n");
    }

    static void ListarCursos(string arquivo)
    {
        CursoService cursoService = new CursoService(arquivo);

        List<Curso> cursos = cursoService.ListarTodosCursos();

        Console.WriteLine("Lista de Cursos:");
        if (cursos.Count == 0)
        {
            Console.WriteLine("Nenhum curso cadastrado!");
        }
        else
        {
            foreach (var curso in cursos)
            {
                Console.WriteLine($"[{curso.Id}] - {curso.Titulo} - {curso.Nivel}");
            }
        }
        Console.WriteLine();
    }

    static void CadastrarCurso(string arquivo)
    {
        Console.Write("Título: ");
        string titulo = Console.ReadLine().Trim();
        Console.Write("Nível (0 - Básico / 1 - Intermediário / 2 - Avançado): ");
        int valor = int.Parse(Console.ReadLine());
        CursoService cursoService = new CursoService(arquivo);
        cursoService.CadastrarCurso(titulo, valor);
        Console.WriteLine("Curso cadastrado com sucesso!\n");
    }

    static void ListarAlunos(string arquivo)
    {
        AlunoService alunoService = new AlunoService(arquivo);

        List<Aluno> alunos = alunoService.ListarTodosAlunos();

        Console.WriteLine("Lista de Alunos:");
        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado!");
        }
        else
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"[{aluno.Id}] - {aluno.Nome} - {aluno.Email}");
            }
        }
        Console.WriteLine();
    }

    static void CadastrarAluno(string arquivo)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine().Trim();
        Console.Write("Email: ");
        string email = Console.ReadLine().Trim().ToLower();
        AlunoService alunoService = new AlunoService(arquivo);
        alunoService.CadastrarAluno(nome, email);
    }

    static void Matricular(string arquivoAlunos, string arquivoCursos)
    {
        ListarAlunos(arquivoAlunos);
        Console.Write("Deseja fazer a matrícula de qual aluno? ");
        int idAluno = int.Parse(Console.ReadLine());
        Boolean matricular = true;

        do
        {
            ListarCursos(arquivoCursos);
            Console.Write("Em qual curso deseja matricular o aluno? ");
            int idCurso = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja continuar matriculando? (s/n)");
            string escolha = Console.ReadLine().Trim().ToLower();

            if (escolha[0] == 'n')
            {
                matricular = false;
            }
        }
        while (matricular);
        
    }

}