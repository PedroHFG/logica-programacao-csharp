namespace Ex05;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;
    public Produto()
    {
    }

    public Produto(string nome, double preco)
    {
        this.Nome = nome;
        this.Preco = preco;
    }

    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        this.Quantidade = quantidade;
    }
}