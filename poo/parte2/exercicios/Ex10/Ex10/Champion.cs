using System.Text;

namespace Ex10;

public class Champion
{
    public string Name { get; set; }
    public int Life { get; set; }
    public int Attack { get; set; }
    public int Armor { get; set; }

    public Champion()
    {

    }

    public Champion(string name, int life, int attack, int armor)
    {
        Name = name;
        Life = life;
        Attack = attack;
        Armor = armor;
    }

    public void TakeDamage(Champion other)
    {
        int totalDamage = other.Attack - Armor;

        if (totalDamage <= 0)
        {
            Life -= 1;
        }
        else
        {
            Life -= totalDamage;
        }

        if (Life < 0)
        {
            Life = 0;
        }     
    }

    public string Status()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{Name}: {Life} de vida");
        if (Life == 0)
        {
            sb.Append(" (morreu)");
        }

        return sb.ToString();
    }
}
