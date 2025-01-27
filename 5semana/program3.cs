using System;
using System.Collections.Generic;

namespace Asignaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una lista de cadenas para almacenar las asignaturas
            List<string> asignaturas = new List<string>() { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            // Mostramos las asignaturas por pantalla
            Console.WriteLine("Las asignaturas del curso son:");
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine(asignatura);
            }
        }
    }
}