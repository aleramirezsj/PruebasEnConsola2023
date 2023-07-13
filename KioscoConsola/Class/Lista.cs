using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoConsola.Class
{
    class Lista<T>
    {
        private List<T> elementos;

        public Lista()
        {
            elementos = new List<T>();
        }

        public void AgregarElemento(T elemento)
        {
            elementos.Add(elemento);
        }

        public T ObtenerElemento(int indice)
        {
            if (indice >= 0 && indice < elementos.Count)
            {
                return elementos[indice];
            }
            else
            {
                throw new IndexOutOfRangeException("Índice fuera de rango");
            }
        }
        public string ImprimirLista()
        {
            string retorno = $"Lista:{Environment.NewLine}";
            foreach (T elemento in elementos)
            {
                retorno += elemento + Environment.NewLine;
            }
            return retorno;
        }
    }
}
