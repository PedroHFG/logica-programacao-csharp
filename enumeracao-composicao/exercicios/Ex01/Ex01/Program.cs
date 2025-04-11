using Ex01.Entities;
using Ex01.Enums;
using System.Globalization;

namespace Ex01;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CLIENTE");
        Console.Write("Id: ");
        int idCliente = int.Parse(Console.ReadLine());
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Cliente cliente = new Cliente(idCliente, nome, email);
        Console.WriteLine();

        Console.WriteLine("PEDIDO");
        Console.Write("Id: ");
        int idPedido = int.Parse(Console.ReadLine());
        Console.Write("Data (dd/MM/yyyy): ");
        DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        StatusPedido status = StatusPedido.AguardandoPagamento;
        Pedido pedido = new Pedido(idPedido, cliente, data, status);
        Console.WriteLine();

        Console.WriteLine(pedido);
        MostrarMenu();
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                pedido.Status = StatusPedido.Processando;
                break;
            case 2:
                pedido.Status = StatusPedido.Enviado;
                break;
            case 3:
                pedido.Status = StatusPedido.Entregue;
                break;
            default:
                break;
        }

        Console.WriteLine();
        Console.WriteLine(pedido);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Alterar Status do Pedido");
        Console.WriteLine("[0] Aguardando Pagamento");
        Console.WriteLine("[1] Processando");
        Console.WriteLine("[2] Enviado");
        Console.WriteLine("[3] Entregue");
    }
}