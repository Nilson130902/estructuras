using System;

namespace ListaEnlazada
{
    // Clase Nodo para representar cada elemento de la lista
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    // Clase ListaEnlazada que contiene los métodos para manipular la lista
    public class ListaEnlazada
    {
        public Nodo? Cabeza { get; set; }

        public ListaEnlazada()
        {
            Cabeza = null;
        }

        // Método para agregar un nodo al final de la lista
        public void Agregar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);

            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        // Método para calcular el número de elementos en la lista
        public int CalcularLongitud()
        {
            int contador = 0;
            Nodo actual = Cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Agregando elementos a la lista
            lista.Agregar(10);
            lista.Agregar(20);
            lista.Agregar(30);
            lista.Agregar(40);

            // Calculando la longitud de la lista
            Console.WriteLine("La longitud de la lista es: " + lista.CalcularLongitud());
        }
    }
}
