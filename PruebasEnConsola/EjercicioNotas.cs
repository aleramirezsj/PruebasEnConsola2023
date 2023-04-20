using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasEnConsola
{
    public class EjercicioNotas
    {
        public EjercicioNotas()
        {
            PedirNotas();
        }

        public static void PedirNotas()
        {
            Pantalla.ImprimirLinea("Ejercicio de Notas");
            Pantalla.ImprimirLinea("******************");
            int nota1, nota2, nota3;
            float promedio;
            Pantalla.Imprimir("Ingrese la Nota 1:");
            nota1 = Pantalla.LeerNumero();
            Pantalla.Imprimir("Ingrese la Nota 2:");
            nota2 = Pantalla.LeerNumero();
            Pantalla.Imprimir("Ingrese la Nota 3:");
            nota3 = Pantalla.LeerNumero();
            promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio >= 7)
                Pantalla.ImprimirLinea("Promocionado");
            else
                Pantalla.ImprimirLinea("Adeuda Materias");
        }
    }
}
