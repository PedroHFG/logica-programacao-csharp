namespace Ex02;

public class Program
{
    static void Main(string[] args)
    {
        Estudante[] estudantes = new Estudante[10];

        Console.Write("Quantos quartos serão alugados? ");
        int numeroDeQuartos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroDeQuartos; i++)
        {
            Console.WriteLine($"Aluguel #{i}");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());

            estudantes[quarto] = new Estudante(nome, email);
            Console.WriteLine();
        }

        Console.WriteLine("Quartos ocupados:");
        for (int i = 0; i < estudantes.Length; i++)
        {
            if (estudantes[i] is not null)
            {
                Console.WriteLine($"{i}: {estudantes[i]}");
            }
        }
    }
}