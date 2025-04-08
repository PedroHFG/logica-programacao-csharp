using System.Globalization;

namespace Ex06;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write($"Número Conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write($"Titular da Conta: ");
        string titular = Console.ReadLine();
        Console.Write($"Saldo: ");
        double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        ContaBancaria conta1 = new ContaBancaria(numero, titular, saldo);

        Console.WriteLine();
        Console.WriteLine(conta1);

        Console.WriteLine();
        Console.Write("Fazer depósito: $ ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta1.Depositar(valor);
        Console.WriteLine();
        Console.WriteLine(conta1);

        Console.WriteLine();
        Console.Write("Fazer saque: $ ");
        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta1.Sacar(valor);
        Console.WriteLine();
        Console.WriteLine(conta1);

        Console.WriteLine();
        Console.Write("Alterar titular: ");
        titular = Console.ReadLine();
        conta1.Titular = titular;
        Console.WriteLine();
        Console.WriteLine(conta1);
    }
}