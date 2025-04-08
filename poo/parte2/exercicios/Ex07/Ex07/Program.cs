using System.Globalization;

namespace Ex07;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Temperatura em Celsius: ");
        double celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Temperatura temp = new Temperatura(celsius);

        Console.WriteLine($"Temp. Celsius: {temp.Celsius}");
        Console.WriteLine($"Temp. Fahrenheit: {temp.Fahrenheit}");

        Console.Write("Alterar temperatura em Celsius: ");
        celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        temp.Celsius = celsius;
        Console.WriteLine($"Temp. Celsius: {temp.Celsius}");
        Console.WriteLine($"Temp. Fahrenheit: {temp.Fahrenheit}");

    }
}