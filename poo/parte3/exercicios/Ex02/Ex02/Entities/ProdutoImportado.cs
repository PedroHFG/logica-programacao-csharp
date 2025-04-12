using System.Globalization;
using System.Text;

namespace Ex02.Entities;

public class ProdutoImportado : Produto
{
    public double TaxaAlfandega { get; set; }

    public ProdutoImportado()
    {

    }

    public ProdutoImportado(string nome, double preco, double taxaAlfandega) : base(nome, preco)
    {
        TaxaAlfandega = taxaAlfandega;
    }

    public override string Etiqueta()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nome: {Nome}");
        sb.AppendLine($"Preço: $ {(Preco + TaxaAlfandega).ToString("F2", CultureInfo.InvariantCulture)}");
        return sb.ToString();
    }
}
