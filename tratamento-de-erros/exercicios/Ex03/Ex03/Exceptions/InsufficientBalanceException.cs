namespace Ex03.Exceptions;

public class InsufficientBalanceException : ApplicationException
{
    public InsufficientBalanceException(string? message) : base(message)
    {
    }
}
