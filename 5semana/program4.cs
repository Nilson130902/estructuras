using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            // Convertimos la palabra a minúsculas para ignorar mayúsculas
            palabra = palabra.ToLower();

            // Invertimos la palabra
            string palabraInvertida = "";
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraInvertida += palabra[i];
            }

            // Comparamos la palabra original con la invertida
            if (palabra == palabraInvertida)
            {
                Console.WriteLine("La palabra es un palíndromo.");
            }
            else
            {
                Console.WriteLine("La palabra no es un palíndromo.");
            }
        }
    }
}