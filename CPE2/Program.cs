using System;
using System.Collections.Generic;
using System.Linq;

public class SimulacionAsignacionAsientos
{
    public static void Main(string[] args)
    {
        int cantidadAsientos = 30;
        Queue<string> filaEspera = new Queue<string>();
        List<string> asientos = Enumerable.Repeat("Disponible", cantidadAsientos).ToList(); // Inicializa asientos como "Disponible"

        // Simulación de llegada de personas a la fila
        filaEspera.Enqueue("Persona 1");
        filaEspera.Enqueue("Persona 2");
        filaEspera.Enqueue("Persona 3");
        // ... (añade más personas a la fila)

        // Asignación de asientos
        while (filaEspera.Count > 0)
        {
            string persona = filaEspera.Dequeue();
            int asientoAsignado = -1;

            // Encuentra un asiento disponible
            for (int i = 0; i < asientos.Count; i++)
            {
                if (asientos[i] == "Disponible")
                {
                    asientos[i] = persona;
                    asientoAsignado = i + 1; // Los asientos se numeran desde 1
                    break;
                }
            }

            if (asientoAsignado != -1)
            {
                Console.WriteLine($"{persona} ha sido asignado al asiento {asientoAsignado}");
            }
            else
            {
                Console.WriteLine($"Ya no hay asientos disponibles. {persona} deberá esperar.");
            }
        }

        // Reporte de asientos
        Console.WriteLine("\n--- Reporte de Asientos ---");
        for (int i = 0; i < asientos.Count; i++)
        {
            Console.WriteLine($"Asiento {i + 1}: {asientos[i]}");
        }
    }
}