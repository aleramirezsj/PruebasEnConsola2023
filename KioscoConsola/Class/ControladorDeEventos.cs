using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Class
{
    public class ControladorDeEventos
    {
        public event EventHandler TituloGenericsEvento;
        public event EventHandler ListaColoresEvento;
        public event EventHandler ListaTelefonosEvento;

        public void MostrarTituloGenerics()
        {
            TituloGenericsEvento?.Invoke(this, EventArgs.Empty);
        }
        public void MostrarListaColores()
        {
            ListaColoresEvento?.Invoke(this, EventArgs.Empty);
        }
        public void MostrarListaTelefonos()
        {
            ListaTelefonosEvento?.Invoke(this, EventArgs.Empty);
        }
    }
}
