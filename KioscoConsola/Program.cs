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

        Console.WriteLine(coca.Imprimir());
        Console.WriteLine(gaseosas);

        Cliente ale = new Cliente("Alejandro Ramirez", 3498447106, "Bv Roque Saenz Peña 2942", SituacionIvaEnum.Monotributista,25326070);
        Console.WriteLine(ale);

        Usuario juan = new Usuario("Juan Perez", 3498454545, "9 de julio 2323", "jperez", "unicornio");
        Console.WriteLine(juan);

        //implementamos un uso polimórfico de los objetos derivados de la clase abstracta Persona
        List<Persona> personas= new List<Persona>();
        personas.Add(juan);
        personas.Add(ale);
        foreach (Persona persona in personas)
        {
            Console.WriteLine(persona.Imprimir());
        }
        Lista<Cliente> clientes = new Lista<Cliente>();
        clientes.AgregarElemento(ale);
        Console.WriteLine(clientes.ObtenerElemento(0).ToString());
    }
}