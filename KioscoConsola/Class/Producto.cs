using KioscoConsola.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Class
{
    public class Producto: IProducto
    {
        public string Descripción { get; set; }
        public decimal Precio { get; set; }
        public Rubro Rubro { get; set; }
        public int Id { get; set ; }

        public Producto(string descripción, decimal precio, Rubro rubro)
        {
            this.Id= new Random().Next(1,1000);
            this.Descripción = descripción;
            this.Precio = precio;
            this.Rubro = rubro;
        }

        public override string ToString()
        {
            return $"Producto: {this.Descripción} Precio:{this.Precio} {this.Rubro}";
        }

        public string Imprimir()
        {
           return $"Código:{this.Id} {this.ToString()}";
        }
    }
}
