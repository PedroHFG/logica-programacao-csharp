using System.Text;
using System.Globalization;

namespace Ex06;

public class ContaBancaria
{
    private int _numero;
    private string _titular;
    private double _saldo;

    public ContaBancaria()
    {
    }

    public ContaBancaria(int numero, string titular, double saldo)
    {
        _numero = numero;
        _titular = titular;
        _saldo = saldo;
    }

    public string Titular
    {
        get { return _titular; } 
        set { _titular = value; }
    }

    public double Saldo
    {
        get { return _saldo; }
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            _saldo += valor;
        }
        else
        {
            Console.WriteLine("É preciso informar o valor do depósito.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor <= _saldo)
        {
            _saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("EXTRATO BANCÁRIO:");
        sb.AppendLine($"Conta: {_numero}");
        sb.AppendLine($"Titular: {_titular}");
        sb.AppendLine($"Saldo: $ {_saldo.ToString("F2", CultureInfo.InvariantCulture)}");

        return sb.ToString();
    }
}

