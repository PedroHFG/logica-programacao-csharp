/*Exercício 1: Declare variáveis dos tipos int, double, char, string, bool.
Atribua valores e imprima-os com Console.WriteLine(). */

using System.Globalization;

namespace Exercicio1;

public class Program
{
    private static void Main(string[] args)
    {
        int idade = 21;
        double salario = 3735.25;
        char genero = 'M';
        string nome = "John Green";
        bool maiorDeIdade = true;

        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine("Salario: $ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine($"Gênero: {genero}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Maior idade: {maiorDeIdade}");
        Console.WriteLine();
    }
}