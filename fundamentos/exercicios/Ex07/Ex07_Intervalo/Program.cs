namespace Exercicio07;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 10 && numero <= 20)
        {
            Console.WriteLine($"{numero} dentro do intervalo de 10 a 20.");
        }
        else
        {
            Console.WriteLine($"{numero} fora do intervalo de 10 a 20.");
        }

    }
}