namespace Ex03.Entities;

public class Funcionario
{
    public String Name { get; set; }
    public String Cargo { get; set; }
    public String  Email { get; set; }

    public Funcionario()
    {

    }

    public Funcionario(string name, string cargo, string email)
    {
        Name = name;
        Cargo = cargo;
        Email = email;
    }
}
