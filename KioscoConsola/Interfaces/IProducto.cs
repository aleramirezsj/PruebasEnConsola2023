using KioscoConsola.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Interfaces
{
    public interface IProducto
    {
        int Id { get; set; }
        string Descripción { get; set; }
        decimal Precio { get; set; }
        Rubro Rubro { get; set; }
        string Imprimir();
    }
}
