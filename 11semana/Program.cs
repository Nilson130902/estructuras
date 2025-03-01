using System;
using System.Collections.Generic;

class Traductor
{
    static void Main(string[] args)
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            { "hola", "hi" },
            { "tiempo", "time" },
            { "persona", "person" },
            { "año", "year" },
            { "camino", "way" },
            { "forma", "way" },
            { "día", "day" },
            { "cosa", "thing" },
            { "hombre", "man" },
            { "mundo", "world" },
            { "vida", "life" },
            { "mano", "hand" },
            { "parte", "part" },
            { "niño", "child" },
            { "niña", "child" },
            { "ojo", "eye" },
            { "mujer", "woman" },
            { "lugar", "place" },
            { "trabajo", "work" },
            { "semana", "week" },
            { "caso", "case" },
            { "punto", "point" },
            { "tema", "point" },

        };

        int opcion;
        do
        {
            Console.WriteLine("\nMENU");
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
                    string frase = Console.ReadLine();
                    string[] palabras = frase.Split(' ');
                    Console.Write("Su frase traducida es: ");
                    foreach (var item in palabras)
                    {
                        if (diccionario.ContainsKey(item.ToLower()))
                        {
                            Console.Write(diccionario[item.ToLower()] + " ");
                        }
                        else
                        {
                            Console.Write(item + " ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Ingrese la palabra en inglés: ");
                    string palabraIngles = Console.ReadLine().ToLower();
                    Console.Write("Ingrese la traducción en español: ");
                    string palabraEspanol = Console.ReadLine().ToLower();

                    if (!diccionario.ContainsKey(palabraIngles))
                    {
                        diccionario.Add(palabraIngles, palabraEspanol);
                        Console.WriteLine("Palabra agregada con éxito.");
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
