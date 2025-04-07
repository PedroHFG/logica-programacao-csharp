using System.Globalization;

namespace Ex02;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("RETÂNGULO");

        Retangulo retangulo = new Retangulo();

        Console.WriteLine("Informe as dimensões do retângulo:");
        Console.Write("Largura: ");
        retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Altura: ");
        retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = retangulo.Area();
        double perimetro = retangulo.Perimetro();
        double diagonal = retangulo.Diagonal();

        Console.WriteLine($"Área = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Perímetro = {perimetro.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Diagonal = {diagonal.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}