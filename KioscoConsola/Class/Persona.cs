using KioscoConsola.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Class
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public uint Teléfono { get; set; }
        public string Dirección { get; set; }
        public abstract string Saludar();
        public virtual string Imprimir()
        {
            string retorno = $"Tipo objeto:{this.GetType()}{Environment.NewLine}";
            retorno += $"Nombre: {this.Nombre}{Environment.NewLine}";
            retorno += $"Dirección: {this.Dirección} {Environment.NewLine}";
            retorno += $"Teléfono: {this.Teléfono}{Environment.NewLine}";
            return retorno ;
        }

        public Persona(string nombre, uint teléfono, string dirección)
        {
            Nombre = nombre;
            Teléfono = teléfono;
            Dirección = dirección;
        }

        

        public override string ToString()
        {
            return $"{this.Nombre} Teléfono: {this.Teléfono} Dirección: {this.Dirección}";
        }
    }
}
