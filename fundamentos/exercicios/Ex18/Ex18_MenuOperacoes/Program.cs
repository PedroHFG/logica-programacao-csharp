namespace Exercicio18;

public class Program
{
    static void Main(string[] args)
    {
        bool rodando = true;
        int numero1, numero2;

        while (rodando)
        {
            MostrarMenu();
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe os valores para a soma.");
                    Console.Write("Primeiro valor: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Segundo valor: ");
                    numero2 = int.Parse(Console.ReadLine());
                    Somar(numero1, numero2);
                    break;

                case 2:
                    Console.WriteLine("Informe os valores para a subtração.");
                    Console.Write("Primeiro valor: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Segundo valor: ");
                    numero2 = int.Parse(Console.ReadLine());
                    Subtrair(numero1, numero2);
                    break;

                case 3:
                    Console.WriteLine("Informe os valores para a multiplicação.");
                    Console.Write("Primeiro valor: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Segundo valor: ");
                    numero2 = int.Parse(Console.ReadLine());
                    Multiplicar(numero1, numero2);
                    break;

                case 4:
                    Console.WriteLine("Programa finalizado.");
                    rodando = false;
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("====== MENU DE OPERAÇÕES ======");
        Console.WriteLine("[1] Somar");
        Console.WriteLine("[2] Subtrair");
        Console.WriteLine("[3] Multiplicar");
        Console.WriteLine("[4] Sair");
        Console.Write("Escolha sua opção: ");
    }

    static void Somar(int valor1, int valor2)
    {
        Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}\n");
    }

    static void Subtrair(int valor1, int valor2)
    {
        Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}\n");
    }

    static void Multiplicar(int valor1, int valor2)
    {
        Console.WriteLine($"{valor1} x {valor2} = {valor1 * valor2} \n");
    }
}