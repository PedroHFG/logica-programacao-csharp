using SistemaCursos.Enums;
using SistemaCursos.Exceptions;

namespace SistemaCursos.Entities;

public class Curso
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public NivelCurso Nivel { get; set; }

    public Curso()
    {

    }

    public Curso(string titulo, int valor)
    {
        if (string.IsNullOrWhiteSpace(titulo))
        {
            throw new ArgumentException("O título do curso não pode ser vazio ou nulo");
        }
        if (!Enum.IsDefined(typeof(NivelCurso), valor))
        {
            throw new NivelInvalidoException("Valor inválido para o nível do curso. O nível deve ser 0 (Básico), 1 (Intermediário) ou 2 (Avançado).");
        }

        Titulo = titulo;
        Nivel = (NivelCurso)valor;
    }

    public Curso(string titulo, NivelCurso nivel)
    {
        Titulo = titulo;
        Nivel = nivel;
    }

    public Curso(int id, string titulo, NivelCurso nivel)
    {
        Id = id;
        Titulo = titulo;
        Nivel = nivel;
    }

    public override string ToString()
    {
        return $"{Id};{Titulo};{Nivel}";
    }
}
