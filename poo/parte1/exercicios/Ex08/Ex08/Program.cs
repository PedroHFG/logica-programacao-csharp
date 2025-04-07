using System.Globalization;

namespace Ex08;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe valor em dólar: $ ");
        double valorReal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Cotação do dólar: R$ ");
        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Valor em real: R$ {ConversorDeMoeda.DolarParaReal(valorReal, cotacao).ToString("F2", CultureInfo.InvariantCulture)}");

    }
}