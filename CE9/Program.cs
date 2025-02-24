// See https://aka.ms/new-console-template for more information
// Console.WriteLine("universidad estatal amazonicas");
// HashSet<string> ciudadanos = new HashSet<string>(); //500
// HashSet<string> astraseneca = new HashSet<string>(); //500
// HashSet<string> pfizer = new HashSet<string>(); //500
// //metodo 1
// for (int i=0; i<500; i++)
// {
//     //System.Console.WriteLine();
//     ciudadanos.add ("ciudadanos" +(i+1));

// }

// for (int j=0; j<501; j++)
// {
//    // System.Console.WriteLine();
//     ciudadanos.add ("ciudadanos" + j);

// } 

// for (int j=0; j<101; j++)
// {
//    // System.Console.WriteLine();
//     ciudadanos.add ("ciudadanos" +j);

// } 
// //imprimir colecciones ciudadanas
//  foreach (var item in astreseneca)
//  {
//     System.Console.WriteLine(item);
//  }
// See https://aka.ms/new-console-template for more information
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

       
        HashSet<string> vacunadosPfizer = new HashSet<string>(ciudadanos.OrderBy(x => Guid.NewGuid()).Take(75));

        
        HashSet<string> vacunadosAstrazeneca = new HashSet<string>(ciudadanos.Except(vacunadosPfizer).OrderBy(x => Guid.NewGuid()).Take(75));
        HashSet<string> vacunadosAmbas = new HashSet<string>(vacunadosPfizer.Take(50).Concat(vacunadosAstrazeneca.Take(50)));

        HashSet<string> noVacunados = new HashSet<string>(ciudadanos.Except(vacunadosPfizer).Except(vacunadosAstrazeneca));

        HashSet<string> vacunadosDosDosis = new HashSet<string>(vacunadosAmbas);

        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer.Except(vacunadosAmbas));

        HashSet<string> soloAstrazeneca = new HashSet<string>(vacunadosAstrazeneca.Except(vacunadosAmbas));

    
        Console.WriteLine("Ministerio de Salud Publica del Ecuador");
        Console.WriteLine("Ciudadanos no vacunados del DISTRISTO D1710 " + noVacunados.Count);
        Console.WriteLine("Ciudadanos con Dos dosis:de Procedencia China " + vacunadosDosDosis.Count);
        Console.WriteLine("Ciudadanos solo con Pfizer: de EEUU: " + soloPfizer.Count);
        Console.WriteLine("Ciudadanos solo con AstraZeneca:Procedencia China " + soloAstrazeneca.Count);
    }
}
