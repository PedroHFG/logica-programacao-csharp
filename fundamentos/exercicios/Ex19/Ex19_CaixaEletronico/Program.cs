using System.Globalization;

namespace Exercicio19;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o valor: ");
        int saldo = int.Parse(Console.ReadLine());
        int qtdNotasDe100 = 0;
        int qtdNotasDe50 = 0;
        int qtdNotasDe20 = 0;
        int qtdNotasDe10 = 0;
        int qtdNotasDe5 = 0;
        int qtdNotasDe1 = 0;
        int resto = 0;

        if (saldo >= 100)
        {
            resto = saldo % 100;
            qtdNotasDe100 = (saldo - resto) / 100;
            saldo -= qtdNotasDe100 * 100;
        }

        if (saldo >= 50)
        {
            resto = saldo % 50;
            qtdNotasDe50 = (saldo - resto) / 50;
            saldo -= qtdNotasDe50 * 50;
        }

        if (saldo >= 20)
        {
            resto = saldo % 20;
            qtdNotasDe20 = (saldo - resto) / 20;
            saldo -= qtdNotasDe20 * 20;
        }

        if (saldo >= 10)
        {
            resto = saldo % 10;
            qtdNotasDe10 = (saldo - resto) / 10;
            saldo -= qtdNotasDe10 * 10;
        }

        if (saldo >= 5)
        {
            resto = saldo % 5;
            qtdNotasDe5 = (saldo - resto) / 5;
            saldo -= qtdNotasDe5 * 5;
        }

        if (saldo >= 1)
        {
            resto = saldo % 1;
            qtdNotasDe1 = (saldo - resto) / 1;
            saldo -= qtdNotasDe1 * 1;
        }

        if (qtdNotasDe100 > 0) Console.WriteLine($"Qtd. notas de 100: {qtdNotasDe100}");
        if (qtdNotasDe50 > 0) Console.WriteLine($"Qtd. notas de 50: {qtdNotasDe50}");
        if (qtdNotasDe20 > 0) Console.WriteLine($"Qtd. notas de 20: {qtdNotasDe20}");
        if (qtdNotasDe10 > 0) Console.WriteLine($"Qtd. notas de 10: {qtdNotasDe10}");
        if (qtdNotasDe5 > 0) Console.WriteLine($"Qtd. notas de 5: {qtdNotasDe5}");
        if (qtdNotasDe1 > 0) Console.WriteLine($"Qtd. notas de 1: {qtdNotasDe1}");

    }
}