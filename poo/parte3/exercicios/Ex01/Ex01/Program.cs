using Ex01.Entities;
using System.Globalization;

namespace Ex01;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantidade de funcionários: ");
        int quantidade = int.Parse(Console.ReadLine());

        List<Funcionario> funcionarios = new List<Funcionario>();

        for (int i = 1; i <= quantidade; i++)
        {
            Funcionario func;
            Console.WriteLine($"\nFuncionário #{i}");
            Console.Write($"Nome: ");
            string nome = Console.ReadLine();
            Console.Write($"Horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write($"Valor por hora: $ ");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Funcionário comum ou terceirizado (C/T)? ");
            string tipo = Console.ReadLine().ToUpper().Trim();

            while (tipo != "C" && tipo != "T")
            {
                Console.Write("Tipo incompatível. Funcionário comum ou terceirizado (C/T)? ");
                tipo = Console.ReadLine().ToUpper().Trim();
            }

            if (tipo == "T")
            {
                Console.Write("Despesa Adicional: $ ");
                double despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func = new FuncionarioTerceirizado(nome, horas, valorPorHora, despesaAdicional);
            }
            else
            {
                func = new Funcionario(nome, horas, valorPorHora);
            }

            funcionarios.Add(func);
        }

        Console.WriteLine("\nFOLHA DE PAGAMENTO");
        foreach (var func in funcionarios)
        {
            Console.WriteLine(func);
        }
    }
}