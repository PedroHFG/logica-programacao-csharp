namespace Ex08;

public class ConversorDeMoeda
{
    public static double IOF = 6;

    public static double DolarParaReal(double valor, double cotacao)
    {
        double total = valor * cotacao;
        return total + (total * (IOF / 100.0));
    }
}
