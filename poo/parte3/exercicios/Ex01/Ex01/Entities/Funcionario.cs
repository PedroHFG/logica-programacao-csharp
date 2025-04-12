using System.Text;
using System.Globalization;

namespace Ex01.Entities;

public class Funcionario
{
    public string Nome { get; set; }
    public int Horas { get; set; }
    public double ValorPorHora { get; set; }

    public Funcionario()
    {

    }

    public Funcionario(string nome, int horas, double valorPorHora)
    {
        Nome = nome;
        Horas = horas;
        ValorPorHora = valorPorHora;
    }

    public virtual double Pagamento()
    {
        return ValorPorHora * Horas;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"\nNome: {Nome}");
        sb.AppendLine($"Pagamento: $ {Pagamento().ToString("F2", CultureInfo.InvariantCulture)}");
        return sb.ToString();
    }
}
