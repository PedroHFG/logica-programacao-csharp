namespace Ex10;

public class Program
{
    static void Main(string[] args)
    {
        Champion champion1 = ReadChampionData(1);
        Champion champion2 = ReadChampionData(2);

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

    static Champion ReadChampionData(int number)
    {
        Console.WriteLine($"\nDigite os dados do {number}º campeão:");
        Console.Write("Nome: ");
        string name = Console.ReadLine();
        Console.Write("Vida inicial: ");
        int life = int.Parse(Console.ReadLine());
        Console.Write("Ataque: ");
        int attack = int.Parse(Console.ReadLine());
        Console.Write("Armadura: ");
        int armor = int.Parse(Console.ReadLine());

        return new Champion(name, life, attack, armor);
    }
}