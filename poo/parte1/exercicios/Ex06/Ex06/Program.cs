using System.Globalization;

namespace Ex06;

public class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();
        Console.Write("Nota Trimestre 1: ");
        aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Nota Trimestre 2: ");
        aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Nota Trimestre 3: ");
        aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine(aluno);
    }
}