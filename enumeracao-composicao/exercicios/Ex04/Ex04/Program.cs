using Ex04.Entities;
using Ex04.Enums;
using System.Globalization;

namespace Ex04;

public class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Console.WriteLine("LojaTech");

        Console.Write("\nPara quantos clientes deseja fazer o registro de pedidos? ");
        int clientQuantity = int.Parse(Console.ReadLine());

        for (int i = 1; i <= clientQuantity; i++)
        {
            Console.WriteLine($"\nCliente #{i}");
            Console.Write("Nome Cliente: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            DateOnly birthDate = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy");
            Client client = new Client(clientName, email, birthDate);

            Console.Write($"\nStatus do pedido do cliente {client.Name} ([0] PAGAMENTO PENDENTE/[1] PROCESSANDO/[2] ENVIADO/[3] ENTREGUE): ");
            OrderStatus status = (OrderStatus)int.Parse(Console.ReadLine());
            DateTime moment = DateTime.Now.ToUniversalTime();

            Order order = new Order(moment, status, client);

            Console.Write($"\nQuantos itens de pedido para o cliente {client.Name}? ");
            int itemsQuantity = int.Parse(Console.ReadLine());

            for (int j = 1; j <= itemsQuantity; j++)
            {
                Console.WriteLine($"\nProduto #{j}");
                Console.Write("Nome: ");
                string productName = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantity, product.Price, product);

                order.AddItem(item);
            }

            orders.Add(order);
        }

        Console.WriteLine("\nRESUMO PEDIDOS");
        foreach (Order order in orders)
        {
            order.Summary();
        }
    }
}



