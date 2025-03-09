using System;
using System.Collections.Generic;

public class Libro
{
    public string ISBN { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public int AñoPublicacion { get; set; }

    public override string ToString()
    {
        return $"ISBN: {ISBN}, Título: {Titulo}, Autor: {Autor}, Género: {Genero}, Año: {AñoPublicacion}";
    }
}

public class Biblioteca
{
    private Dictionary<string, Libro> libros = new Dictionary<string, Libro>();
    private HashSet<string> isbnSet = new HashSet<string>();

    public void AgregarLibro(Libro libro)
    {
        if (libros.ContainsKey(libro.ISBN))
        {
            Console.WriteLine("Libro con ISBN ya existente.");
            return;
        }
        libros.Add(libro.ISBN, libro);
        isbnSet.Add(libro.ISBN);
        Console.WriteLine($"Libro \"{libro.Titulo}\" agregado correctamente.");
    }
    public void MostrarLibros()
    {
        if (libros.Count == 0)
        {
            Console.WriteLine("La biblioteca está vacía.");
            return;
        }

        Console.WriteLine("Lista de libros:");
        foreach (var libro in libros.Values)
        {
            Console.WriteLine(libro);
        }
    }
    public void BuscarLibroPorTitulo(string titulo)
    {
        bool encontrado = false;
        foreach (var libro in libros.Values)
        {
            if (libro.Titulo.ToLower().Contains(titulo.ToLower()))
            {
                Console.WriteLine(libro);
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine($"No se encontraron libros con el título \"{titulo}\".");
        }
    }

    public void BuscarLibroPorAutor(string autor)
    {
        bool encontrado = false;
        foreach (var libro in libros.Values)
        {
            if (libro.Autor.ToLower().Contains(autor.ToLower()))
            {
                Console.WriteLine(libro);
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine($"No se encontraron libros del autor \"{autor}\".");
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Total de libros: {libros.Count}");
        HashSet<string> generos = new HashSet<string>();
        foreach (var libro in libros.Values)
        {
            generos.Add(libro.Genero);
        }
        Console.WriteLine($"Géneros disponibles: {string.Join(", ", generos)}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        while (true)
        {
            Console.WriteLine("\n--- Menú de la Biblioteca ---");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Mostrar libros");
            Console.WriteLine("3. Buscar libro por título");
            Console.WriteLine("4. Buscar libro por autor");
            Console.WriteLine("5. Mostrar información de la biblioteca");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Libro nuevoLibro = new Libro();
                    Console.Write("ISBN(Código Númerico): ");
                    nuevoLibro.ISBN = Console.ReadLine();
                    Console.Write("Título: ");
                    nuevoLibro.Titulo = Console.ReadLine();
                    Console.Write("Autor: ");
                    nuevoLibro.Autor = Console.ReadLine();
                    Console.Write("Género: ");
                    nuevoLibro.Genero = Console.ReadLine();
                    Console.Write("Año de publicación: ");
                    if (int.TryParse(Console.ReadLine(), out int anio))
                    {
                        nuevoLibro.AñoPublicacion = anio;
                    }
                    else
                    {
                        Console.WriteLine("Año inválido.");
                        continue;
                    }
                    biblioteca.AgregarLibro(nuevoLibro);
                    break;
                case "2":
                    biblioteca.MostrarLibros();
                    break;
                case "3":
                    Console.Write("Ingrese el título a buscar: ");
                    biblioteca.BuscarLibroPorTitulo(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Ingrese el autor a buscar: ");
                    biblioteca.BuscarLibroPorAutor(Console.ReadLine());
                    break;
                case "5":
                    biblioteca.MostrarInformacion();
                    break;
                case "6":
                    Console.WriteLine("Saliendo...");
                    return;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}