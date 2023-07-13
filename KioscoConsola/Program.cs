using KioscoConsola.Class;
using KioscoConsola.Enums;
using System.Drawing;

public class Program
{
    public delegate void DelegadoImprimir(string mensaje);

    private static void ImprimirEnLaConsola(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
    private static void Main(string[] args)
    {
        //PROBAMOS DELEGADOS
        DelegadoImprimir delegadoImpresión = ImprimirEnLaConsola;
        //PROBAMOS MANEJADORES DE EVENTOS
        ControladorDeEventos controlador=new ControladorDeEventos();
        ImpresionesEnPantalla impresiones=new ImpresionesEnPantalla();
        controlador.TituloGenericsEvento += impresiones.ImprimirTituloGenerics;
        controlador.ListaColoresEvento += impresiones.ImprimirListaColores;
        controlador.ListaTelefonosEvento += impresiones.ImprimirListaTelefonos;

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

        controlador.MostrarTituloGenerics();
        Lista<Cliente> clientes = new Lista<Cliente>();
        clientes.AgregarElemento(ale);
        Console.WriteLine(clientes.ObtenerElemento(0));
        Lista<string> teléfonos= new Lista<string>();
        teléfonos.AgregarElemento("3498 447106");
        teléfonos.AgregarElemento("3498 428576");
        teléfonos.AgregarElemento("3498 426023");
        delegadoImpresión($"Imprimiendo el teléfono Nº3 {teléfonos.ObtenerElemento(2)}" );
        Lista<Color> colores= new Lista<Color>();
        colores.AgregarElemento(Color.Red);
        colores.AgregarElemento(Color.Yellow);
        colores.AgregarElemento(Color.Blue);
        delegadoImpresión($"Imprimiendo el Color Nº3 {colores.ObtenerElemento(2)}");
        controlador.MostrarListaTelefonos();
        Console.WriteLine(teléfonos.ImprimirLista());
        controlador.MostrarListaColores();
        Console.WriteLine(colores.ImprimirLista());

    }
}