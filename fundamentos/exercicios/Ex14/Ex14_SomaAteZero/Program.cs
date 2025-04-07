namespace Exercicio14;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SOMA ATÉ ZERO");
        /*Console.Write("Digite um número inteiro diferente de 0 (Digite 0 para sair): ");
        int numero = int.Parse(Console.ReadLine());

        int soma = 0;

        while (numero != 0)
        {
            soma += numero;
            Console.Write("Digite um número inteiro diferente de 0 (Digite 0 para sair): ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"SOMA = {soma}");*/

        // Versão mais simplificada com o do-while
        int numero;
        int soma = 0;

        do
        {
            Console.Write("Digite um número inteiro diferente de 0 (Digite 0 para sair): ");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        }
        while (numero != 0);

        Console.WriteLine($"SOMA = {soma}");
    }
}