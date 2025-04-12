using Ex02.Entities;
using Ex02.Exceptions;

namespace Ex02;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("STOCK CONTROL");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(name, quantity);
            Console.WriteLine(product);

            Console.Write("\nQuantity to remove: ");
            quantity = int.Parse(Console.ReadLine());

            product.RemoveFromStock(quantity);
            Console.WriteLine(product);
        }
        catch (InsufficientStockException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }
}