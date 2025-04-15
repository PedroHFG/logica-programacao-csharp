using SistemaCursos.Entities;
using SistemaCursos.Enums;
using SistemaCursos.Repositories;

namespace SistemaCursos.Services;

public class CursoService
{
    private CursoRepository _cursoRepository;

    public string Arquivo { get; set; }
    public Curso Curso { get; set; }
    public List<Curso> Cursos { get; set; } = new List<Curso>();

    public CursoService()
    {

    }

    public CursoService(string arquivo)
    {
        Arquivo = arquivo;
        _cursoRepository = new CursoRepository(Arquivo);
    }

    public CursoService(string arquivo, Curso curso)
    {
        Arquivo = arquivo;
        Curso = curso;
        _cursoRepository = new CursoRepository(Arquivo);
    }

    public List<Curso> ListarTodosCursos()
    {
        List<string> lista = _cursoRepository.ListarTodosCursos();

        foreach (var linha in lista)
        {
            string[] vetor = linha.Split(";");
            int id = int.Parse(vetor[0]);
            string titulo = vetor[1];
            NivelCurso nivel = Enum.Parse<NivelCurso>(vetor[2]);
            Cursos.Add(new Curso(id, titulo, nivel));
        }

        return Cursos;
    }

    public void CadastrarCurso(string titulo, int nivel)
    {
        _cursoRepository.CadastrarCurso(new Curso(titulo, nivel));
    }
}
