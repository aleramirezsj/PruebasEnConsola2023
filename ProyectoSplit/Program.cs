using ProyectoSplit.Class;
using ProyectoSplit.Enums;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("PROYECTO SPLIT!");
        Split split1 = new Split(balanceo: false, dirección: 0, consumo: 2500, temperatura: 0, tamaño: "grande", modoOperacion: ModoOperacionEnum.Frio, marca: "Samsung",encendido:false,frigorias:4500);
        Console.WriteLine(split1.ToString());
        //creamos otro split
        Split split2 = new Split();
        
        split2.Marca = "Midea";
        split2.Frigorias = 3000;
        split2.Consumo = 2500;
        split2.Tamaño = "mediano";
        Console.WriteLine(split2.ToString());

        Split split3 = new Split(consumo: 1500, tamaño: "chico", marca:"Marshal", frigorias:2500) ;
        Console.WriteLine(split3.ToString());
        Console.WriteLine("Impresión de estados de los Splits");
        Console.WriteLine(split1.Status());
        Console.WriteLine(split2.Status());
        split3.Encender();
        Console.WriteLine(split3.Status());
        split3.Apagar();
        Console.WriteLine(split3.Status());

    }
}