namespace Exercicio15;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TABUADA");
        Console.Write("Informe um número de 1 a 10: ");
        int numero = int.Parse(Console.ReadLine());

        while (numero < 1 || numero > 10)
        {
            Console.Write("Número fora do intervalo. Informe um número de 1 a 10: ");
            numero = int.Parse(Console.ReadLine());
        }

        MostrarTabuada(numero);
    }

    static void MostrarTabuada(int numero)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}