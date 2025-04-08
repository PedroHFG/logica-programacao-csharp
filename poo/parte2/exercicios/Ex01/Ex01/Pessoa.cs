namespace Ex01;

public class Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa()
    {
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
    }
}
