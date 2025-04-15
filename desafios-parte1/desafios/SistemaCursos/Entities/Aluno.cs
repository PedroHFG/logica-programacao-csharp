namespace SistemaCursos.Entities;

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public List<Matricula> Matriculas { get; private set; } = new List<Matricula>();

    public Aluno()
    {

    }

    public Aluno(string nome, string email)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do aluno não pode ser vazio ou nulo");
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("O email do aluno não pode ser vazio ou nulo");
        }

        Nome = nome;
        Email = email;
    }

    public Aluno(int id, string nome, string email)
    {
        Id = id;
        Nome = nome;
        Email = email;
    }

    public void AddMatricula(Matricula matricula)
    {
        Matriculas.Add(matricula);
    }

    public void RemoveMatricula(Matricula matricula)
    {
        Matriculas.Remove(matricula);
    }

    public override string ToString()
    {
        return $"{Id};{Nome};{Email}";
    }
}
