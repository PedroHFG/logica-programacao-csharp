namespace Exercicio03;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual o seu nome? ");
        string nome = Console.ReadLine();
        Console.Write("Qual a sua idade? ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nOlá {nome}! Você tem {idade} anos.");
    }
}