using System.Text;

namespace Ex04.Entities;

public class Client
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateOnly BirthDate { get; set; }

    public Client()
    {

    }

    public Client(string name, string email, DateOnly birthDate)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Cliente: {Name} ({Email})");
        sb.AppendLine($"Data de Nascimento: {BirthDate.ToString("dd/MM/yyyy")}");
        return sb.ToString();
    }
}
