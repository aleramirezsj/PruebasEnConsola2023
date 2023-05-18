using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Class
{
    public class Usuario : Persona
    {

        public string User { get; set; }
        public string Pass { get; set; }
        public Usuario(string nombre, uint teléfono, string dirección, string user, string pass) : base(nombre, teléfono, dirección)
        {
            User = user;
            Pass = pass;
        }

        public override string ToString()
        {
            return $"Usuario: {base.ToString()} User: {this.User} Pass: {this.Pass}";
        }

        public override string Saludar()
        {
            return $"Buenos días, soy el empleado {this.Nombre}";
        }
        public override string Imprimir()
        {
            string retorno= base.Imprimir();
            retorno += $"User:{this.User}{Environment.NewLine}";
            retorno += $"Pass:{this.Pass}{Environment.NewLine}";
            return retorno ;
        }
    }
}
