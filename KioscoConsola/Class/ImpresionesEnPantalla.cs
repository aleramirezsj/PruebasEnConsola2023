using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Class
{
    public class ImpresionesEnPantalla
    {
        public void ImprimirTituloGenerics(object sender, EventArgs e)
        {
            Console.WriteLine("***********PROBANDO GENERICS**********");
        }
        public void ImprimirListaTelefonos(object sender, EventArgs e)
        {
            Console.WriteLine("Imprimiendo la lista de teléfonos");
        }
        public void ImprimirListaColores(object sender, EventArgs e)
        {
            Console.WriteLine("Imprimiendo la lista de colores");

        }
    }
}
