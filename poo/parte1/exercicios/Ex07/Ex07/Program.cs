using System.Globalization;

namespace Ex07;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o raio do círculo: ");
        double raioCirc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe o raio da esfera: ");
        double raioEsf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Circunferência círculo: {Calculadora.Circunferencia(raioCirc).ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume da esfera: {Calculadora.VolumeEsfera(raioEsf).ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor de PI: {Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
