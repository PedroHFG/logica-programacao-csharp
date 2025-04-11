using Ex02.Entities;
using Ex02.Enums;

namespace Ex02;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("USUÁRIO");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Nivel (Comum[0], Moderador[1], Administrador[2]): ");
        int nivelId = int.Parse(Console.ReadLine());
        NivelAcesso nivel = (NivelAcesso)nivelId;
        
        Usuario usuario = new Usuario(nome, email, nivel);
        Console.WriteLine(usuario.Nivel.ToString() == "Administrador");

        MostrarMenu();
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Tela: Visualizar");
                break;
            case 2:
                if (usuario.TemPermissaoParaEditar())
                {
                    Console.WriteLine("Tela: Editar");
                }
                else
                {
                    Console.WriteLine("Acesso negado!");
                }
                break;
            case 3:
                if (usuario.TemPermissaoParaExcluir())
                {
                    Console.WriteLine("Tela: Excluir");
                }
                else
                {
                    Console.WriteLine("Acesso negado!");
                }
                break;
            default:
                Console.WriteLine("Tela inexistente");
                break;
        }
        
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nMENU DE OPÇÔES");
        Console.WriteLine("[1] Visualizar");
        Console.WriteLine("[2] Editar");
        Console.WriteLine("[3] Excluir");
    }
}