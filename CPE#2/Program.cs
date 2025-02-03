using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> colaEspera = new Queue<string>();
        List<string> asientosAsignados = new List<string>();
        int totalAsientos = 30;

        Console.WriteLine("Asignación de Asientos para una Atracción (30 asientos)");

        // Ingreso de personas a la cola
        for (int i = 1; i <= 35; i++) // 35 personas para ver cómo se gestionan los asientos llenos
        {
            colaEspera.Enqueue($"Persona {i}");
        }

        Console.WriteLine("\nPersonas en la cola:");
        foreach (var persona in colaEspera)
        {
            Console.WriteLine(persona);
        }

        Console.WriteLine("\nAsignación de Asientos:");
        int asientoNumero = 1;

        while (colaEspera.Count > 0 && asientoNumero <= totalAsientos)
        {
            string persona = colaEspera.Dequeue();
            asientosAsignados.Add($"Asiento {asientoNumero}: {persona}");
            Console.WriteLine($"Asiento {asientoNumero} asignado a {persona}");
            asientoNumero++;
        }

        // Asientos asignados
        Console.WriteLine("\nReporte de Asientos Asignados:");
        foreach (var asiento in asientosAsignados)
        {
            Console.WriteLine(asiento);
        }

        // Personas que se quedaron sin asiento
        if (colaEspera.Count > 0)
        {
            Console.WriteLine("\nPersonas que no obtuvieron asiento:");
            foreach (var persona in colaEspera)
            {
                Console.WriteLine(persona);
            }
        }
        else
        {
            Console.WriteLine("\nTodos los asistentes obtuvieron un asiento.");
        }
    }
}
