namespace PruebasEnConsola
{ 
    public class EjercicioNombreEdad
    {
        //método constructor
        public EjercicioNombreEdad()
        {
            //imprimimos un título en la pantalla
            Pantalla.ImprimirLinea("Pruebas en C# 2023");
            Pantalla.ImprimirLinea("******************");
            PedirNombreYSaludar();
            PedirEdadYCalcularDias();
        }


        private void PedirEdadYCalcularDias()
        {
            int edad=0;
            int diasDeVida = 0;
            Pantalla.Imprimir("Ingrese la edad: ");
            edad = Pantalla.LeerNumero();
            diasDeVida = edad * 365;
            Pantalla.ImprimirLinea($"Los días aproximados de vida son:{diasDeVida}");
        }

        private void PedirNombreYSaludar()
        {
            //pedimos el nombre
            string? nombre;
            Pantalla.Imprimir("Ingrese el nombre: ");
            nombre=Pantalla.LeerLinea();

            //saludamos
            Pantalla.ImprimirLinea("Bienvenido "+nombre+" al sistema");
            Pantalla.ImprimirLinea($"Bienvenido {nombre} al sistema");
        }
    }
    
    
}