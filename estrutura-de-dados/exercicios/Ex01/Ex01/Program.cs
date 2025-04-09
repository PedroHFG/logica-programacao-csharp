using System.Globalization;

namespace Ex01;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantidade de produtos? ");
        int number = int.Parse(Console.ReadLine());

        Product[] products = new Product[number];
        double total = 0;
        double sum = 0;

        for (int i = 0; i < products.Length; i++)
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: $ ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            products[i] = new Product(name, price);
        }

        foreach (Product p in products)
        {
            sum += p.Price;
            total += 1;
        }

        double average = sum / total;

        Console.WriteLine($"Preço médio {average.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}