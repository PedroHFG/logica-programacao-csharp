using Ex01.Enums;

namespace Ex01.Entities;

public class Pedido
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public DateTime Data { get; set; }
    public StatusPedido Status { get; set; }

    public Pedido()
    {
    }

    public Pedido(int id, Cliente cliente, DateTime data, StatusPedido status)
    {
        Id = id;
        Cliente = cliente;
        Data = data;
        Status = status;
    }

    public override string ToString()
    {
        return $"{Id}, {Cliente.Nome}, {Data}, {Status}";
    }
}
