namespace Ex02;

public class Retangulo
{
    public double Largura;
    public double Altura;

    public double Area()
    {
        return Altura * Largura;
    }

    public double Perimetro()
    {
        return 2 * (Altura + Largura);
    }

    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
    }
}
