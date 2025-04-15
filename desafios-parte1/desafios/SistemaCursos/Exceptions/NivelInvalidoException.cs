namespace SistemaCursos.Exceptions;

public class NivelInvalidoException : ApplicationException
{
    public NivelInvalidoException(string? message) : base(message)
    {
    }
}
