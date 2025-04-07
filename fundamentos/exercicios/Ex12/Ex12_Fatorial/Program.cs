namespace Exercicio12;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FATORIAL");
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = ObterFatorial(numero);
        Console.WriteLine($"Fatorial de {numero} é {resultado}");
    }

    static int ObterFatorial(int numero)
    {
        int fatorial = 1;

        if (numero == 0)
        {
            return fatorial;
        }
        else
        {
            for (int i = numero; i >= 1; i--)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}