namespace Exercicio11;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("NÚMERO PRIMO");
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        bool resultado = NumeroEPrimo(numero);

        if (resultado)
        {
            Console.WriteLine($"{numero} é primo.");
        }
        else
        {
            Console.WriteLine($"{numero} não é primo.");
        }

        
    }

    static bool NumeroEPrimo(int numero)
    {
        int contRestoZero = 0;
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                contRestoZero += 1;
            }
        }

        return (contRestoZero == 2) ? true : false;
    }
}