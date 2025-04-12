using System.Text;
using System.Globalization;

namespace Ex02.Entities;

public class ProdutoUsado : Produto
{
    public DateOnly DataFabricacao { get; set; }

    public ProdutoUsado()
    {
    }

    public ProdutoUsado(string nome, double preco, DateOnly dataFabricacao) : base(nome, preco)
    {
        DataFabricacao = dataFabricacao;
    }

    public override string Etiqueta()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nome: {Nome}");
        sb.AppendLine($"Preço: $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Data de Fabricação: {DataFabricacao.ToString("dd/MM/yyyy")}");
        return sb.ToString();
    }
}
