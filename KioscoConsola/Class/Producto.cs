using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Class
{
    public class Producto
    {
        public string Descripción { get; set; }
        public decimal Precio { get; set; }
        public Rubro Rubro { get; set; }

        public Producto(string descripción)
        {
            Descripción = descripción;
        }
    }
}
