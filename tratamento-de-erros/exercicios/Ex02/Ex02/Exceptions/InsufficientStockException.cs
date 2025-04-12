namespace Ex02.Exceptions;

public class InsufficientStockException : ApplicationException
{
    public InsufficientStockException(string message) : base(message) { }
}
