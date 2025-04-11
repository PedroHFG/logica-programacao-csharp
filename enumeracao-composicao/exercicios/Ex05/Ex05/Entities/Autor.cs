namespace Ex05.Entities;

public class Autor
{
    public string Nome { get; set; }
    public string Bio { get; set; }

    public List<Comentario> Comentarios { get; private set; } = new List<Comentario>();

    public Autor()
    {

    }

    public Autor(string nome, string bio)
    {
        Nome = nome;
        Bio = bio;
    }

    public void AddComentarios(Comentario comentario)
    {
        Comentarios.Add(comentario);
    }

    public void RemoveComentarios(Comentario comentario)
    {
        Comentarios.Remove(comentario);
    }
}
