using Ex03.Entities;
using System.Globalization;

namespace Ex03;

public class Program
{
    static void Main(string[] args)
    {
        List<Projeto> projetos = new List<Projeto>();

        Console.Write("Quantos funcionários? ");
        int numeroFuncionario = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroFuncionario; i++)
        {
            Console.WriteLine($"\nFuncionário #{i}");
            Console.Write("Nome Funcionário: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Funcionario funcionario = new Funcionario(nomeFuncionario, cargo, email);

            Console.Write($"\nQuantos projetos para o funcionário {funcionario.Name}? ");
            int quantidadeProjetos = int.Parse(Console.ReadLine());

            for (int j = 1; j <= quantidadeProjetos; j++)
            {
                int id = projetos.Count + 1;
                Console.WriteLine($"\nProjeto #{j}");
                Console.Write("Nome Projeto: ");
                string nomeProjeto = Console.ReadLine();
                Console.Write("Descrição: ");
                string descricao = Console.ReadLine();
                Console.Write("Data início (dd/mm/yyyy): ");
                DateTime dataInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Data fim (dd/mm/yyyy): ");
                DateTime dataFim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                
                projetos.Add(new Projeto(id, nomeProjeto, descricao, dataInicio, dataFim, funcionario));
            }

        }

        Console.WriteLine("\nLista de Projetos:");

        foreach (Projeto projeto in projetos)
        {
            Console.WriteLine(projeto);
        }
    }
}