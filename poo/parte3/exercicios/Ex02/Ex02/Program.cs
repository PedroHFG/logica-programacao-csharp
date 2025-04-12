using Ex02.Entities;
using System.Globalization;

namespace Ex02;

public class Program
{
    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>();
        Produto produto;

        Console.Write("Quantidade de produtos a serem etiquetados: ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine($"\nProduto #{i}");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: $ ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Produto Usado ou Produto importado (U/I)? ");
            string tipo = Console.ReadLine().ToUpper().Trim();

            while (tipo != "U" && tipo != "I")
            {
                Console.Write("Tipo Inválido. Produto Usado ou Produto importado (U/I)? ");
                tipo = Console.ReadLine().ToUpper().Trim();
            }

            if (tipo == "I")
            {
                Console.Write("Taxa da Alfândega: $ ");
                double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto = new ProdutoImportado(nome, preco, taxa);
            }
            else
            {
                Console.Write("Data de Fabricação (dd/MM/yyyy): ");
                DateOnly data = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy");
                produto = new ProdutoUsado(nome, preco, data);
            }

            produtos.Add(produto);
        }

        Console.WriteLine("\nETIQUETAS");
        foreach (Produto prod in produtos)
        {
            Console.WriteLine($"\n{prod.Etiqueta()}");
        }
    }
}