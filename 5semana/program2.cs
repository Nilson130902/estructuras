using System;
using System.Collections.Generic;

namespace MostrarAsignaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una lista de cadenas para almacenar las asignaturas
            List<string> asignaturas = new List<string>() { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            // Recorremos la lista y mostramos el mensaje para cada asignatura
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }
}