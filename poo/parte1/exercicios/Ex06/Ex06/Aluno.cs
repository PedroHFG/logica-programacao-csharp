using System.Text;
using System.Globalization;

namespace Ex06;

public class Aluno
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double CalcularMediaFinal()
    {
        return (Nota1 +  Nota2 + Nota3) / 3.0;
    }

    public override string ToString()
    {
        double media = CalcularMediaFinal();
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Boletim Escolar");
        sb.AppendLine($"Aluno: {Nome}");
        sb.AppendLine($"Nota 1º Trimestre: {Nota1.ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Nota 2º Trimestre: {Nota2.ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Nota 3º Trimestre: {Nota3.ToString("F2", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Nota Final: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        if (media >= 60)
        {
            sb.AppendLine("APROVADO!");
        }
        else
        {
            sb.AppendLine("REPROVADO!");
            sb.AppendLine($"Faltaram {(60 - media).ToString("F2", CultureInfo.InvariantCulture)} pontos.");
        }

        return sb.ToString();
    }
}
