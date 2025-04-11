using Ex04.Enums;
using System.Text;
using System.Globalization;

namespace Ex04.Entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public Client Client { get; set; }

    public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

    public Order()
    {

    }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public double Total()
    {
        
        double total = 0;
        foreach (OrderItem item in Items)
        {
            total += item.SubTotal();
        }
        return total;
    }

    public void Summary()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("--------------------------");
        sb.AppendLine($"Data: {Moment.ToLocalTime()}");
        sb.AppendLine($"Status: {Status}\n");
        sb.AppendLine($"{Client}");
        sb.AppendLine($"Items:");
        
        foreach (OrderItem item in Items)
        {
            sb.AppendLine($"{item}");
        }

        sb.AppendLine($"\nTotal: $ {Total().ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine("--------------------------");
        Console.WriteLine(sb.ToString());
    }
}
