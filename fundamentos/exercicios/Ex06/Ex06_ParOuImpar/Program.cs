namespace Exercicio06;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um úmero inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é par.");
        }
        else
        {
            Console.WriteLine($"{numero} é ímpar.");
        }
    }
}