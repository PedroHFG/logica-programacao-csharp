namespace Ex05;

public class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto { Nome = "TV 4K", Preco = 2899.00, Quantidade = 3};
        Console.WriteLine(p.Nome);
    }
}