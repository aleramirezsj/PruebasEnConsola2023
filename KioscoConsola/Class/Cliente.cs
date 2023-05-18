using KioscoConsola.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Class
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public uint Teléfono { get; set; }
        public string Dirección { get; set; }
        public SituacionIvaEnum SituacionIva { get; set; }

        public Cliente(string nombre, uint teléfono, string dirección, SituacionIvaEnum situacionIva)
        {
            Nombre = nombre;
            Teléfono = teléfono;
            Dirección = dirección;
            SituacionIva = situacionIva;
        }
        public override string ToString()
        {
            return $"Cliente: {this.Nombre} Teléfono: {this.Teléfono} Dirección: {this.Dirección} Situación IVA: {this.SituacionIva}";
        }
    }
}
