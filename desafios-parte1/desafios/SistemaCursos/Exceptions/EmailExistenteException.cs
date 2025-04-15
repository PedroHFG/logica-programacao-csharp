namespace SistemaCursos.Exceptions;

public class EmailExistenteException : ApplicationException
{
    public EmailExistenteException(string? message) : base(message)
    {
    }
}
