using System.Text;

namespace Ex07;

public class Temperatura
{
    private double _celsius;

    public double Celsius
    {
        get { return _celsius; }
        set 
        {
            if (value >= -273.15)
            {
                _celsius = value;
            }
            else
            {
                Console.WriteLine("Temperatura inválida!");
            }
        }
    }

    public double Fahrenheit
    {
        get { return (_celsius * (9.0 / 5.0)) + 32; }
    }

    public Temperatura()
    {
    }

    public Temperatura(double celsius)
    {
        Celsius = celsius;
    }

    
}
