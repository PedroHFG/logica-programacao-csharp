using System.Text;

namespace Ex03.Entities;

public class Projeto
{
    public int Id { get; set; }
    public String Nome { get; set; }
    public String Descricao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public Funcionario Responsavel { get; set; }

    public Projeto()
    {

    }

    public Projeto(int id, string nome, string descricao, DateTime dataInicio, DateTime dataFim, Funcionario responsavel)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        DataInicio = dataInicio;
        DataFim = dataFim;
        Responsavel = responsavel;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"\nId: {Id}");
        sb.AppendLine($"Nome Projeto: {Nome}");
        sb.AppendLine($"Descrição: {Descricao}");
        sb.AppendLine($"Data de início: {DataInicio.ToString("dd/MM/yyyy")}");
        sb.AppendLine($"Data de término: {DataFim.ToString("dd/MM/yyyy")}");
        sb.AppendLine($"Responsável: {Responsavel.Name}");
        sb.AppendLine($"Cargo: {Responsavel.Cargo}");
        sb.AppendLine($"Email: {Responsavel.Email}");

        return sb.ToString();
    }
}
