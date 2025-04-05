namespace Exercicio04;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;
        int multiplicacao = numero1 * numero2;
        

        Console.WriteLine($"\nSoma = {soma}");
        Console.WriteLine($"Subtração = {subtracao}");
        Console.WriteLine($"Multiplicação = {multiplicacao}");

        if ( numero2 == 0 )
        {
            Console.WriteLine("Não é possível dividir por zero!");
        }
        else
        {
            double divisao = (double)numero1 / numero2;
            Console.WriteLine($"Divisão = {divisao}");
        }
        
    }
}