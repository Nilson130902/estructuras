using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }

        HashSet<string> vacunadosPfizer = new HashSet<string>(GenerarVacunados(75, ciudadanos));

        HashSet<string> vacunadosAstrazeneca = new HashSet<string>(GenerarVacunados(75, ciudadanos));

        HashSet<string> vacunadosAmbas = new HashSet<string>(vacunadosPfizer.Intersect(vacunadosAstrazeneca));

        HashSet<string> noVacunados = new HashSet<string>(ciudadanos.Except(vacunadosPfizer.Union(vacunadosAstrazeneca)));

        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer.Except(vacunadosAstrazeneca));

        HashSet<string> soloAstrazeneca = new HashSet<string>(vacunadosAstrazeneca.Except(vacunadosPfizer));

        MostrarLista("Ciudadanos no vacunados", noVacunados);
        MostrarLista("Ciudadanos con ambas vacunas", vacunadosAmbas);
        MostrarLista("Ciudadanos con solo Pfizer", soloPfizer);
        MostrarLista("Ciudadanos con solo Astrazeneca", soloAstrazeneca);
    }

    static IEnumerable<string> GenerarVacunados(int cantidad, HashSet<string> ciudadanos)
    {
        Random rnd = new Random();
        List<string> lista = ciudadanos.ToList();
        HashSet<string> vacunados = new HashSet<string>();

        while (vacunados.Count < cantidad)
        {
            string seleccionado = lista[rnd.Next(lista.Count)];
            vacunados.Add(seleccionado);
        }

        return vacunados;
    }

    static void MostrarLista(string titulo, HashSet<string> lista)
    {
        Console.WriteLine($"\n{titulo} ({lista.Count}):");
        foreach (var ciudadano in lista)
        {
            Console.WriteLine(ciudadano);
        }
    }
}

