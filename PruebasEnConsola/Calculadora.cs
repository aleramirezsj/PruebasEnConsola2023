using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasEnConsola
{
    public class Calculadora
    {
        private double num1;
        private double num2;
        private Operacion operacion;
        public double resultado;

        public Calculadora(double num1, double num2, Operacion operacion)
        {
            this.num1 = num1;
            this.num2 = num2;
            switch (operacion.Denominación)
            {
                case "suma":
                    resultado = Suma();
                    break;
                case "resta":
                    resultado = Resta();
                    break;
                case "multiplicación":
                    resultado= Multiplicacion();
                    break;
                case "dividir":
                    resultado= Division();
                    break;
                default:
                    break;
            }

        }

        public double Suma()
        {
            return num1 + num2;
        }

        public double Resta()
        {
            return num1 - num2;
        }

        public double Multiplicacion()
        {
            return num1 * num2;
        }

        public double Division()
        {
            if (num2 == 0)
            {
                throw new ArgumentException("No se puede dividir por cero.");
            }
            return num1 / num2;
        }

        // Métodos para establecer y obtener los números utilizados en las operaciones
        public void SetNum1(double num)
        {
            this.num1 = num;
        }

        public void SetNum2(double num)
        {
            this.num2 = num;
        }

        public double GetNum1()
        {
            return num1;
        }

        public double GetNum2()
        {
            return num2;
        }
    }
}
