using System.Text;

namespace Ex08;

internal class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string DataNascimento { get; private set; }

    public Cliente()
    {
    }

    public Cliente(string nome, string email, string dataNascimento)
    {
        Nome = nome;
        Email = email;
        DataNascimento = dataNascimento;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("DADOS CLIENTE");
        sb.AppendLine($"Nome: {Nome}");
        sb.AppendLine($"Email: {Email}");
        sb.AppendLine($"Data de Nascimento: {DataNascimento}");
        return sb.ToString();
    }
}
