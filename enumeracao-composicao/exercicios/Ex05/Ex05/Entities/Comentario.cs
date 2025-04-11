namespace Ex05.Entities;

public class Comentario
{
    public string Texto { get; set; }
    public DateTime DataPublicacao { get; set; }

    public Autor Autor { get; set; }

    public Comentario()
    {

    }

    public Comentario(string texto, DateTime dataPublicacao, Autor autor)
    {
        Texto = texto;
        DataPublicacao = dataPublicacao.ToUniversalTime();
        Autor = autor;
    }
}
