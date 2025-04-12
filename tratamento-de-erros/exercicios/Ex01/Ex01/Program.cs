namespace Ex01;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Informe um número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Informe outro número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Divisão: {numero1 / numero2}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Erro: não é possível dividir por zero.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Erro: você deve digitar apenas números inteiros.");
        }
        
    }
}