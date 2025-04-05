namespace Exercicio09;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ANO BISSEXTO");
        Console.Write("Informe o ano: ");
        int ano = int.Parse(Console.ReadLine());

        if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
        {
            Console.WriteLine("Ano é bissexto.");
        }
        else
        {
            Console.WriteLine("Ano não é bissexto");
        }

    }
}