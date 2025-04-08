namespace Ex02;

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
        Nome = nome;
        Preco = preco;
    }

    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;
    }
}
