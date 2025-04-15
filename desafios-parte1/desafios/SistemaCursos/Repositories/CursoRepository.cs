using SistemaCursos.Entities;

namespace SistemaCursos.Repositories;

public class CursoRepository
{
    public string Arquivo { get; set; }
    public List<string> Cursos { get; private set; } = new List<string>();

    public CursoRepository()
    {

    }

    public CursoRepository(string arquivo)
    {
        Arquivo = arquivo;
    }

    public List<string> ListarTodosCursos()
    {
        if (Cursos.Count >= 0)
        {
            Cursos.Clear();
        }

        using (StreamReader sr = new StreamReader(Arquivo))
        {
            while (!sr.EndOfStream)
            {
                string linha = sr.ReadLine();
                
                if (!linha.Contains("Id"))
                {
                    Cursos.Add(linha);
                }
            }
        }

        return Cursos;  
    }

    public void CadastrarCurso(Curso curso)
    {
        int id = ObterProximoId();
        curso.Id = id;
        using (StreamWriter sr = new StreamWriter(Arquivo, true))
        {
            sr.WriteLine(curso.ToString());
        }
    }

    private int ObterProximoId()
    {
        List<string> lista = ListarTodosCursos();

        if (lista.Count == 0)
        {
            return 1;
        }
        else
        {
            string ultimoElemento = lista[lista.Count - 1];
            string[] vetor = ultimoElemento.Split(";");
            int ultimoIndice = int.Parse(vetor[0]);
            return ultimoIndice + 1;
        }
    }
}
