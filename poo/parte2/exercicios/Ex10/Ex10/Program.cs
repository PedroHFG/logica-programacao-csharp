namespace Ex10;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os dados do primeiro campeão:");
        Console.Write("Nome: ");
        string name = Console.ReadLine();
        Console.Write("Vida inicial: ");
        int life = int.Parse(Console.ReadLine());
        Console.Write("Ataque: ");
        int attack = int.Parse(Console.ReadLine());
        Console.Write("Armadura: ");
        int armor = int.Parse(Console.ReadLine());
        Champion champion1 = new Champion(name, life, attack, armor);

        Console.WriteLine("\nDigite os dados do segundo campeão:");
        Console.Write("Nome: ");
        name = Console.ReadLine();
        Console.Write("Vida inicial: ");
        life = int.Parse(Console.ReadLine());
        Console.Write("Ataque: ");
        attack = int.Parse(Console.ReadLine());
        Console.Write("Armadura: ");
        armor = int.Parse(Console.ReadLine());
        Champion champion2 = new Champion(name, life, attack, armor);

        Console.Write("\nQuantos turnos você deseja executar? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n;  i++)
        {
            champion1.TakeDamage(champion2);
            champion2.TakeDamage(champion1);
            Console.WriteLine($"\nResultado do turno {i + 1}:");
            Console.WriteLine(champion1.Status());
            Console.WriteLine(champion2.Status());

            if (champion1.Life == 0 || champion2.Life == 0)
            {
                break;
            }
        }

        Console.WriteLine("\nFIM DO COMBATE");

    }
}