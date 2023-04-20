using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasEnConsola
{
    static class Pantalla
    {
        public static void ImprimirLinea(string textoAImprimir)
        {
            Console.WriteLine(textoAImprimir);
        }
        public static void Imprimir(string textoAImprimir)
        {
            Console.Write(textoAImprimir);
        }

        public static string? LeerLinea()
        {
            return Console.ReadLine();
        }

        public static int LeerNumero()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void Borrar()
        {
            Console.Clear();
        }
    }
}
