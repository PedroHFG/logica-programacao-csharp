namespace Exercicio10;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MAIOR NÚMERO");

        Console.Write("Informe o 1º número: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o 2º número: ");
        int valor2 = int.Parse(Console.ReadLine());

        int resultado = ObterMaior(valor1, valor2);

        Console.WriteLine($"Maior valor digitado: {resultado}");

    }

    static int ObterMaior(int valor1, int valor2)
    {
        /*
        int maior;

        if (valor1 > valor2)
        {
            maior = valor1;
        }
        else
        {
            maior = valor2;
        }

        return maior;
        */

        // Outra forma de resolver, mais enxuto
        return (valor1 > valor2) ? valor1 : valor2;
    }
}