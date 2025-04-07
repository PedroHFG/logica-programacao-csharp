namespace Ex07;

public class Calculadora
{
    public static double PI = 3.14;

    public static double Circunferencia(double raio)
    {
        return 2.0 * PI * raio;
    }

    public static double VolumeEsfera(double raio)
    {
        return (4.0 * PI * Math.Pow(raio, 3)) / 3.0;
    }
}
