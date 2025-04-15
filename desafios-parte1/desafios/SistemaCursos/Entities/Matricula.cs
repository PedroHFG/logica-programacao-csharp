using SistemaCursos.Enums;

namespace SistemaCursos.Entities;

public class Matricula
{
    public int AlunoId { get; set; }
    public int CursoId { get; set; }
    public StatusMatricula Status { get; set; }
    public DateTime DataMatricula { get; set; }

    public Matricula(Aluno aluno, Curso curso, StatusMatricula status, DateTime dataMatricula)
    {
        AlunoId = aluno.Id;
        CursoId = curso.Id;
        Status = status;
        DataMatricula = dataMatricula;
    }
}
