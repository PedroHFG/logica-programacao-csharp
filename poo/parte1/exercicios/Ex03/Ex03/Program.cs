using System.Globalization;

namespace Ex03;

public class Program
{
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario();
        
        Console.WriteLine("FUNCIONÁRIO");
        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();
        Console.Write("Salário Bruto: $ ");
        func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto (%): ");
        func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine(func);

        Console.Write("\nAumento salarial (%): ");
        double aumentoPercent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        func.AumentarSalario(aumentoPercent);
        Console.WriteLine(func);
    }
}