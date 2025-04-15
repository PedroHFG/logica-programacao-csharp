using SistemaCursos.Repositories;
using SistemaCursos.Entities;

namespace SistemaCursos.Services;

public class AlunoService
{
    private AlunoRepository _alunoRepository;
    public string Arquivo { get; set; }
    public Aluno Aluno { get; set; }
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();

    public AlunoService()
    {

    }

    public AlunoService(string arquivo)
    {
        Arquivo = arquivo;
        _alunoRepository = new AlunoRepository(Arquivo);
    }

    public List<Aluno> ListarTodosAlunos()
    {
        List<string> lista = _alunoRepository.ListarTodosAlunos();

        foreach (var linha in lista)
        {
            string[] vetor = linha.Split(";");
            int id = int.Parse(vetor[0]);
            string nome = vetor[1];
            string email = vetor[2];
            Alunos.Add(new Aluno(id, nome, email));
        }

        return Alunos;
    }

    public void CadastrarAluno(string nome, string email)
    {
        _alunoRepository.CadastrarAluno(new Aluno(nome, email));
    }
}
