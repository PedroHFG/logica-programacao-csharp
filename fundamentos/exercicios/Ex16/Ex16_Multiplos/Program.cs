namespace Exercicio16;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MÚLTIPLOS DE 3 E 5");

        int contMultiplos = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                contMultiplos++;
                Console.WriteLine(i);
            }
        }

        Console.WriteLine($"Quantidade de numeros multiplos de 3 e 5 entre 1 e 100: {contMultiplos}");
    }
}