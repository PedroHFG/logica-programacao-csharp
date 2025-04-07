using System.Text;
using System.Globalization;

namespace Ex09;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque()
    {
        return Quantidade * Preco;
    }

    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade)
    {
        if (quantidade <= Quantidade)
        {
            Quantidade -= quantidade;
        }
        else
        {
            Console.WriteLine("Quantidade a remover excede o estoque disponível!");
        }
        
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("\nRESUMO ESTOQUE");
        sb.AppendLine($"Produto: {Nome}");
        sb.AppendLine($"Preço: $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Quantidade: {Quantidade}");
        sb.AppendLine($"Valor Estoque: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        return sb.ToString();
    }
}
