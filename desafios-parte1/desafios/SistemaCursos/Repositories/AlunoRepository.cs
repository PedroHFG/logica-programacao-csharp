using SistemaCursos.Entities;
using SistemaCursos.Exceptions;

namespace SistemaCursos.Repositories;

public class AlunoRepository
{
    public string Arquivo { get; set; }
    public List<string> Alunos { get; set; } = new List<string>();

    public AlunoRepository()
    {

    }

    public AlunoRepository(string arquivo)
    {
        Arquivo = arquivo;
    }

    public List<string> ListarTodosAlunos()
    {
        if (Alunos.Count >= 0)
        {
            Alunos.Clear();
        }

        using (StreamReader sr = new StreamReader(Arquivo))
        {
            while (!sr.EndOfStream)
            {
                string linha = sr.ReadLine();

                if (!linha.Contains("Id"))
                {
                    Alunos.Add(linha);
                }
            }
        }

        return Alunos;
    }

    public void CadastrarAluno(Aluno aluno)
    {
        List<string> lista = EncontrarAlunoPorEmail(aluno.Email);

        if (lista.Count > 0)
        {
            throw new EmailExistenteException($"Não foi possível concluir o cadastro. O endereço de e-mail `{aluno.Email}` já está registrado em nosso sistema.");
        }

        int id = ObterProximoId();
        aluno.Id = id;
        
        using (StreamWriter sr = new StreamWriter(Arquivo, true))
        {
            sr.WriteLine(aluno.ToString());
        }
        
        
    }

    public List<string> EncontrarAlunoPorEmail(string email)
    {
        List<string> lista = ListarTodosAlunos();
        List<string> listaFiltrada = lista.FindAll(x => x.Contains(email));
        return listaFiltrada;
    }

    private int ObterProximoId()
    {
        List<string> lista = ListarTodosAlunos();

        if (lista.Count == 0)
        {
            return 1;
        }
        else
        {
            string ultimoElemento = lista[lista.Count - 1];
            string[] vetor = ultimoElemento.Split(";");
            int ultimoIndice = int.Parse(vetor[0]);
            return ultimoIndice + 1;
        }
    }
}
