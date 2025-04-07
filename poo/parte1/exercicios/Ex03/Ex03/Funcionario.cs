using System.Text;
using System.Globalization;

namespace Ex03;

public class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double Salarioliquido()
    {
        return SalarioBruto - (SalarioBruto * Imposto/100.0);
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0); 
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Contra-cheque:");
        sb.AppendLine($"Funcionário: {Nome}");
        sb.AppendLine($"Salário Bruto: $ {SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Imposto sobre salário: {Imposto}%");
        sb.AppendLine($"Salário Líquido: $ {Salarioliquido().ToString("F2", CultureInfo.InvariantCulture)}");
        
        return sb.ToString();
    }
}
