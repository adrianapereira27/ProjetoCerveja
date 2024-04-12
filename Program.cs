using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        List<Cerveja> listaCervejas = new List<Cerveja>();

        listaCervejas.Add(new Spaten("Spaten", "Puro Malte", 5.2, 355.0));
        listaCervejas.Add(new Corona("Corona", "Pilsen", 4.5, 330.0));
        listaCervejas.Add(new Becks("Becks", "German Lager", 5.0, 330.0));

        foreach (var cerveja in listaCervejas)
        {
            Console.WriteLine(cerveja.Descrever(cerveja.Marca, cerveja.TeorAlcoolico, cerveja.Volume));            
        }
        Console.ReadLine();
    }
}

public class Cerveja
{
    public Cerveja(string marca, string tipo, double teorAlcoolico, double volume)
    {
        Marca = marca;
        Tipo = tipo;
        TeorAlcoolico = teorAlcoolico;
        Volume = volume;                
    }

    public string Marca { get; private set; }
    public string Tipo { get; private set; }
    public double TeorAlcoolico { get; private set; }
    public double Volume { get; private set; }

    public virtual string Descrever(string marca, double teorAlcoolico, double volume)
    {
        return "Cerveja " + marca + " é do tipo Pilsen com teor alcoólico de " + teorAlcoolico + " e volume " + volume;
    }

    public double CalcularPrecoCerveja(double teorAlcoolico, double volume)
    {       
        return volume * (teorAlcoolico / 10);
    }
}

public class Spaten : Cerveja
{    
    public Spaten(string marca, string tipo, double teorAlcoolico, double volume) 
        : base(marca, tipo, teorAlcoolico, volume)
    {
        
    }

    public override string Descrever(string marca, double teorAlcoolico, double volume)
    {
        return "Cerveja " + marca + " é do tipo Puro Malte com teor alcoólico de " + teorAlcoolico + "%, volume " + volume + "ml e preço: R$ " + CalcularPrecoCerveja(TeorAlcoolico, Volume);
    }
}

public class Corona : Cerveja
{
    public Corona(string marca, string tipo, double teorAlcoolico, double volume)
        : base(marca, tipo, teorAlcoolico, volume)
    {

    }

    public override string Descrever(string marca, double teorAlcoolico, double volume)
    {
        return "Cerveja " + marca + " é do tipo Pilsen com teor alcoólico de " + teorAlcoolico + "%, volume " + volume + "ml e preço: R$ " + CalcularPrecoCerveja(TeorAlcoolico, Volume);
    }
}

public class Becks : Cerveja
{
    public Becks(string marca, string tipo, double teorAlcoolico, double volume)
        : base(marca, tipo, teorAlcoolico, volume)
    {

    }        

    public override string Descrever(string marca, double teorAlcoolico, double volume)
    {
        return "Cerveja " + marca + " é do tipo German Lager com teor alcoólico de " + teorAlcoolico + "%, volume " + volume + "ml e preço: R$ " + CalcularPrecoCerveja(TeorAlcoolico, Volume);
    }
}


