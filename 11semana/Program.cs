using System;
using System.Collections.Generic;

class Traductor
{
    static void Main(string[] args)
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>();
        diccionario.Add("tiempo", "time");
        diccionario.Add("persona", "person");
        diccionario.Add("año", "year");
        diccionario.Add("camino", "way");
        diccionario.Add("día", "day");
        diccionario.Add("cosa", "thing");
        diccionario.Add("hombre", "man");
        diccionario.Add("mujer", "woman");
        diccionario.Add("mundo", "world");
        diccionario.Add("vida", "life");
        diccionario.Add("ojo", "eye");
        diccionario.Add("hola", "hi");

        int opcion;
        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la frase: ");
                    string frase = Console.ReadLine().ToLower();
                    string[] palabras = frase.Split(' ');
                    Console.Write("Su frase traducida es: ");
                    foreach (var palabra in palabras)
                    {
                        if (diccionario.ContainsKey(palabra))
                        {
                            Console.Write(diccionario[palabra] + " ");
                        }
                        else
                        {
                            Console.Write(palabra + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Ingrese la palabra en español: ");
                    string palabraEsp = Console.ReadLine().ToLower();
                    Console.Write("Ingrese la palabra en inglés: ");
                    string palabraIng = Console.ReadLine().ToLower();
                    if (!diccionario.ContainsKey(palabraEsp))
                    {
                        diccionario.Add(palabraEsp, palabraIng);
                        Console.WriteLine("Palabra agregada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("La palabra ya existe en el diccionario.");
                    }
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        } while (opcion != 0);
    }
}