namespace Exercicio05;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o 1º número: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o 2º número: ");
        int numero2 = int.Parse(Console.ReadLine());
        int maior;

        if (numero1 > numero2)
        {
            maior = numero1;
        }
        else
        {
            maior = numero2;
        }

        Console.WriteLine($"Maior número digitado: {maior}");

    }
}