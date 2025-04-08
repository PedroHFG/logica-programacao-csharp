namespace Ex08;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Data de Nascimento (dd/MM/yyyy): ");
        string dataNascimento = Console.ReadLine();

        Cliente c = new Cliente(nome, email, dataNascimento);
        Console.WriteLine();

        Console.WriteLine(c);

        Console.WriteLine();
        Console.Write("Alterar nome: ");
        nome = Console.ReadLine();
        c.Nome = nome;
        Console.Write("Alterar email: ");
        email = Console.ReadLine();
        c.Email = email;

        Console.WriteLine(c);

    }
}