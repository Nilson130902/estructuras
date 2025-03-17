using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear catálogo de revistas
        List<string> catalogo = new List<string>()
        {
            "National Geographic",
            "Scientific American",
            "Time",
            "Forbes",
            "The Economist",
            "Popular Science",
            "Wired",
            "Nature",
            "Harvard Business Review",
            "IEEE Spectrum"
        };

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- Catálogo de Revistas ---");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el título a buscar: ");
                    string busqueda = Console.ReadLine();

                    if (catalogo.Contains(busqueda))
                    {
                        Console.WriteLine("Resultado: Encontrado");
                    }
                    else
                    {
                        Console.WriteLine("Resultado: No encontrado");
                    }
                    break;

                case "2":
                    salir = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
    }
}
