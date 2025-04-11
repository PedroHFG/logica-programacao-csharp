using System.Globalization;

namespace Ex04.Entities;

public class OrderItem
{
    public int Quantidade { get; set; }
    public double Price { get; set; }
    public Product Product { get; set; }

    public OrderItem()
    {

    }

    public OrderItem(int quantidade, double price, Product product)
    {
        Quantidade = quantidade;
        Price = price;
        Product = product;
    }

    public double SubTotal()
    {
        return Quantidade * Price;
    }

    public override string ToString()
    {
        return $"{Quantidade}x {Product.Name} - $ {Price.ToString("F2", CultureInfo.InvariantCulture)} - Subtotal: $ {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
