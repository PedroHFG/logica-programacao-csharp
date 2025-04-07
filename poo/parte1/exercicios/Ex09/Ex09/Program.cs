using System.Globalization;

namespace Ex09;

public class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();

        Console.Write("Nome Produto: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: $ ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade: ");
        p.Quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine(p);

        Console.Write("Quantidade a adicionar no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(quantidade);
        Console.WriteLine(p);

        Console.Write("Quantidade a remover no estoque: ");
        quantidade = int.Parse(Console.ReadLine());
        p.RemoverProdutos(quantidade);
        Console.WriteLine(p);
    }
}