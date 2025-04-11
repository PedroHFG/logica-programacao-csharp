using Ex05.Entities;

namespace Ex05;

public class Program
{
    static void Main(string[] args)
    {
        // Criar autores
        Autor autor1 = new Autor("João Silva", "Desenvolvedor e escritor de tecnologia.");
        Autor autor2 = new Autor("Maria Souza", "Apaixonada por ciência e educação.");
        Autor autor3 = new Autor("Carlos Mendes", "Engenheiro de software e palestrante.");
        Autor autor4 = new Autor("Ana Costa", "Especialista em IA e machine learning.");

        // Criar artigo
        Artigo artigo1 = new Artigo(
            "O Futuro da Inteligência Artificial",
            "Conteúdo interessante sobre IA...",
            DateTime.Now,
            autor1
        );

        Artigo artigo2 = new Artigo(
            "Como a Educação Pode Ser Transformada Pela Tecnologia",
            "Reflexão sobre educação e inovação digital.",
            DateTime.Now.AddDays(-1),
            autor2
        );

        Artigo artigo3 = new Artigo(
            "Boas Práticas em Desenvolvimento de Software",
            "Dicas práticas para melhorar a qualidade do código.",
            DateTime.Now.AddDays(-2),
            autor3
        );

        // Criar comentários
        Comentario comentario1 = new Comentario("Muito bom artigo!", DateTime.Now, autor2);
        Comentario comentario2 = new Comentario("Achei o tema muito relevante!", DateTime.Now, autor3);
        Comentario comentario3 = new Comentario("Parabéns pelo conteúdo!", DateTime.Now, autor4);
        Comentario comentario4 = new Comentario("Excelente reflexão!", DateTime.Now, autor1);
        Comentario comentario5 = new Comentario("Gostei bastante da abordagem!", DateTime.Now, autor4);
        Comentario comentario6 = new Comentario("Artigo bem escrito e informativo.", DateTime.Now, autor2);

        // Adicionar comentários ao artigo
        artigo1.AddComentario(comentario1);
        artigo1.AddComentario(comentario2);

        artigo2.AddComentario(comentario3);
        artigo2.AddComentario(comentario4);

        artigo3.AddComentario(comentario5);
        artigo3.AddComentario(comentario6);

        // Lista de artigos
        List<Artigo> artigos = new List<Artigo> { artigo1, artigo2, artigo3 };

        // Exibir artigo com comentários
        // Exibir todos os artigos com seus comentários
        foreach (var artigo in artigos)
        {
            artigo.ExibirArtigo();
            Console.WriteLine(new string('-', 40));
        }
    }
}