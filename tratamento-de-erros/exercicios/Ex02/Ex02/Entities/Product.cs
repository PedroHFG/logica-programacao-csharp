using Ex02.Exceptions;

namespace Ex02.Entities;

public class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public Product()
    {

    }

    public Product(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public void RemoveFromStock(int quantity)
    {
        if (quantity > Quantity)
        {
            throw new InsufficientStockException($"Requested quantity exceeds available stock. Requested: {quantity}, Available: {Quantity}.");
        }

        Quantity -= quantity;
    }

    public override string ToString()
    {
        return $"Name: {Name}; Quantity: {Quantity}";
    }
}
