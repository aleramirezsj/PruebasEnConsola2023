using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasEnConsola
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }
        public Empleado()
        {
            PedirDatos();
            ImprimirDatos();
            MostrarSiPagaImpuestoALasGanancias();
        }

        private void MostrarSiPagaImpuestoALasGanancias()
        {
            if(Sueldo>404000)
            {
                Pantalla.ImprimirLinea("Debe pagar impuesto a las ganancias");
            }
            else
            {
                Pantalla.ImprimirLinea("no debe pagar impuesto a las ganancias");
            }
        }

        private void ImprimirDatos()
        {
            Pantalla.ImprimirLinea($"Nombre de la persona: {Nombre}");
            Pantalla.ImprimirLinea($"Sueldo de la persona: {Sueldo}");
        }

        private void PedirDatos()
        {
            Pantalla.Imprimir("Ingrese el nombre:");
            Nombre = Pantalla.LeerLinea();
            Pantalla.Imprimir("Ingrese el sueldo:");
            Sueldo=Pantalla.LeerNumero();
        }
    }

}
