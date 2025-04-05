/*Converta um valor double para int e exiba os dois valores.*/

namespace Exercicio02;

public class Program
{
    private static void Main(string[] args)
    {
        double valor1 = 3.456;
        int valor2 = (int) valor1;

        Console.WriteLine($"Valor em double: {valor1:F3}");
        Console.WriteLine($"Valor em int: {valor2}");
    }
}