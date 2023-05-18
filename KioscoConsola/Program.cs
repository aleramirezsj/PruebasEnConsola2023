using KioscoConsola.Class;
using KioscoConsola.Enums;

public class Program
{
    private static void Main(string[] args)
    {
        Rubro gaseosas = new Rubro("Gaseosas");
        Producto coca= new Producto("Coca Cola 2lts",650,gaseosas);
        Producto pepsi = coca;
        pepsi.Descripción = "Cola Cola Sabor Original 2lts";
        bool sonIguales=coca.Equals(pepsi);
        var hash1= coca.GetHashCode();
        var hash2= pepsi.GetHashCode();

        Console.WriteLine(coca);
        Console.WriteLine(gaseosas);

        Cliente ale = new Cliente("Alejandro Ramirez", 3498447106, "Bv Roque Saenz Peña 2942", SituacionIvaEnum.Monotributista);
        Console.WriteLine(ale);
    }
}