using KioscoConsola.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Class
{
    public class Cliente: Persona
    {
        public SituacionIvaEnum SituacionIva { get; set; }
        public int Dni { get; set; }

        public Cliente(string nombre, uint teléfono, string dirección, SituacionIvaEnum situacionIva, int dni):base(nombre,teléfono,dirección)
        {
            SituacionIva = situacionIva;
            Dni = dni;
        }
        public override string ToString()
        {
            return $"Cliente: {base.ToString()} Situación IVA: {this.SituacionIva} DNI: {this.Dni}";
        }

        public override string Saludar()
        {
            return $"Hola soy {this.Nombre}";
        }
        public override string Imprimir()
        {
            string retorno= base.Imprimir();
            retorno += $"Situación Iva: {this.SituacionIva}{Environment.NewLine}";
            retorno += $"DNI: {this.Dni}";
            return retorno ;
        }
    }
}
