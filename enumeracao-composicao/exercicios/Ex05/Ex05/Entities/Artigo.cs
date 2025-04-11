using System.Text;

namespace Ex05.Entities;

public class Artigo
{
    public string Titulo { get; set; }
    public string Conteudo { get; set; }
    public DateTime DataPublicacao { get; set; }
    public Autor Autor { get; set; }
    public List<Comentario> Comentarios { get; private set; } = new List<Comentario>();

    public Artigo()
    {

    }

    public Artigo(string titulo, string conteudo, DateTime dataPublicacao, Autor autor)
    {
        Titulo = titulo;
        Conteudo = conteudo;
        DataPublicacao = dataPublicacao.ToUniversalTime();
        Autor = autor;
    }

    public void AddComentario(Comentario comentario)
    {
        Comentarios.Add(comentario);
    }

    public void RemoveComentario(Comentario comentario)
    {
        Comentarios.Remove(comentario);
    }

    public void ExibirArtigo()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("=======  ARTIGO =======");
        sb.AppendLine($"Título: {Titulo}");
        sb.AppendLine($"Autor: {Autor.Nome}");
        sb.AppendLine($"Data Publicação: {DataPublicacao.ToLocalTime()}");
        sb.AppendLine($"Conteúdo:");
        sb.AppendLine($"{Conteudo}\n");
        sb.AppendLine($"---- COMENTÁRIOS ----");

        if (Comentarios.Count == 0)
        {
            sb.AppendLine("Nenhum comentário ainda.");
        }
        else
        {
            foreach (var comentario in Comentarios)
            {
                sb.AppendLine($"{comentario.Autor.Nome} - ({comentario.DataPublicacao.ToLocalTime()}):");
                sb.AppendLine($"{comentario.Texto}");
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
