using Ex02.Enums;
using System.Text;

namespace Ex02.Entities;

public class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public NivelAcesso Nivel { get; set; }

    public Usuario(string nome, string email, NivelAcesso nivel)
    {
        Nome = nome;
        Email = email;
        Nivel = nivel;
    }

    public bool TemPermissaoParaEditar()
    {
        return Nivel == NivelAcesso.Moderador || Nivel == NivelAcesso.Administrador;
    }

    public bool TemPermissaoParaExcluir()
    {
        return Nivel == NivelAcesso.Administrador;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nome: {Nome}");
        sb.AppendLine($"Email: {Email}");
        sb.AppendLine($"Nivel de Acesso: {Nivel}");
        return sb.ToString();
    }
}
