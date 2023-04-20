using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasEnConsola
{
    public class EjercicioCalculadora
    {
        Operacion operacion = null;
        Dictionary<int, Operacion> operaciones = new Dictionary<int, Operacion>();
        string continuar = "S";
        
        
        
        public EjercicioCalculadora()
        {
            operaciones.Add(1,new Operacion() { Denominación="suma", PalabraOperación="más", TituloMenu = "1-Sumar" });
            operaciones.Add(2, new Operacion() { Denominación = "resta", PalabraOperación = "menos", TituloMenu = "2-Resta" });
            operaciones.Add(3, new Operacion() { Denominación = "multiplicación", PalabraOperación = "por", TituloMenu = "3-Multiplicar" });
            operaciones.Add(4, new Operacion() { Denominación = "división", PalabraOperación = "dividido por", TituloMenu = "4-Dividir" });
            while (continuar == "S")
            {
                operacion = PintarMenuYPedirUnaOpción();
                PedirNumerosYCalcularOperacion();
                continuar = PreguntarSiContinua();
                Pantalla.Borrar();
            }

        }

        private Operacion PintarMenuYPedirUnaOpción()
        {
            Pantalla.ImprimirLinea("Calculadora");
            Pantalla.ImprimirLinea("***********");
            foreach (KeyValuePair<int, Operacion> elemento in operaciones)
            {
                Pantalla.ImprimirLinea(elemento.Value.TituloMenu);
                
            }
            Pantalla.Imprimir("Ingrese una opción:");
            return operaciones[Pantalla.LeerNumero()];
        }
        private void PedirNumerosYCalcularOperacion()
        {
            Pantalla.Imprimir("Ingrese el número 1:");
            var num1 = Pantalla.LeerNumero();
            Pantalla.Imprimir("Ingrese el número 2:");
            var num2 = Pantalla.LeerNumero();
            var miCalculadora=new Calculadora(num1, num2,operacion);
            Pantalla.ImprimirLinea($"El resultado de la {operacion.Denominación} de {num1} {operacion.PalabraOperación} {num2} es igual a {miCalculadora.resultado}");
            Pantalla.LeerLinea();
        }

        private string PreguntarSiContinua()
        {
            Pantalla.Imprimir("Desea realizar otra operación?(S/N)");
            return Pantalla.LeerLinea();
        }

        
    }
}
