namespace Ex03.Exceptions;

public class LimitExceededException : ApplicationException
{
    public LimitExceededException(string? message) : base(message)
    {
    }
}
