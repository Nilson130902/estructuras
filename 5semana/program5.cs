using System;
using System.Collections.Generic;
using System.Linq;

namespace Precios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una lista con los precios
            List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };

            // Encontramos el precio mínimo y máximo usando LINQ
            int precioMinimo = precios.Min();
            int precioMaximo = precios.Max();

            // Mostramos los resultados
            Console.WriteLine($"El precio mínimo es: {precioMinimo}");
            Console.WriteLine($"El precio máximo es: {precioMaximo}");
        }
    }
}