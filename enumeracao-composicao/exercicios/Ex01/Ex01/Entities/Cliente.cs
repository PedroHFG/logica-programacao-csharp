namespace Ex01.Entities;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public Cliente()
    {
    }

    public Cliente(int id, string nome, string email)
    {
        Id = id;
        Nome = nome;
        Email = email;
    }

    public override string ToString()
    {
        return $"{Id}, {Nome}, {Email}";
    }
}
