using System.Globalization;

namespace Exercicio17;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a 1ª nota: ");
        double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Informe a 2ª nota: ");
        double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Informe a 3ª nota: ");
        double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double mediaPonderada = ObterMediaPonderada(nota1, nota2, nota3);

        Console.WriteLine($"Média Ponderada = {mediaPonderada.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    static double ObterMediaPonderada(double valor1, double valor2, double valor3)
    {
       return (valor1 * 2 + valor2 * 3 + valor3 * 5) / (2 + 3 + 5);
    }
}