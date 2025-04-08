using System.Text;

namespace Ex03;

public class Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;

    public Livro()
    {
    }

    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }

    public string Exibir()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Título: {Titulo}");
        sb.AppendLine($"Autor: {Autor}");
        sb.AppendLine($"Ano: {Ano}");
        return sb.ToString();
    }
}
