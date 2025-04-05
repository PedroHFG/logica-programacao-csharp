using System.Globalization;

namespace Exercicio08;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe sua nota: ");
        double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (nota < 5)
        {
            Console.WriteLine("Reprovado");
        }
        else if (nota < 7)
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Aprovado");
        }
    }
}