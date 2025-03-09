using System;
using System.Collections.Generic;

class Programa
{
    static void Main()
    {
        HashSet<string> biblioteca = new HashSet<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n--- Sistema de Registro de Libros ---");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Mostrar libros");
            Console.WriteLine("3. Buscar libro");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    AgregarLibro(biblioteca);
                    break;
                case 2:
                    MostrarLibros(biblioteca);
                    break;
                case 3:
                    BuscarLibro(biblioteca);
                    break;
                case 4:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }

    static void AgregarLibro(HashSet<string> biblioteca)
    {
        Console.Write("Ingrese el nombre del libro: ");
        string libro = Console.ReadLine().Trim();

        if (string.IsNullOrEmpty(libro))
        {
            Console.WriteLine("El nombre del libro no puede estar vacío.");
            return;
        }

        if (biblioteca.Add(libro))
        {
            Console.WriteLine("Libro agregado correctamente.");
        }
        else
        {
            Console.WriteLine("El libro ya está registrado.");
        }
    }

    static void MostrarLibros(HashSet<string> biblioteca)
    {
        if (biblioteca.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        Console.WriteLine("\nLibros en la biblioteca:");
        foreach (var libro in biblioteca)
        {
            Console.WriteLine("- " + libro);
        }
    }

    static void BuscarLibro(HashSet<string> biblioteca)
    {
        Console.Write("Ingrese el nombre del libro a buscar: ");
        string libro = Console.ReadLine().Trim();

        if (biblioteca.Contains(libro))
        {
            Console.WriteLine("El libro está registrado en la biblioteca.");
        }
        else
        {
            Console.WriteLine("El libro NO está registrado.");
        }
    }
}
