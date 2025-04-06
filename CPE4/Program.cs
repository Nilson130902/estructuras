using System;
using System.Collections.Generic;

class Program
{
    // Representación de un vuelo
    class Edge
    {
        public string Destination;
        public int Cost;

        public Edge(string destination, int cost)
        {
            Destination = destination;
            Cost = cost;
        }
    }

    // Algoritmo de Dijkstra
    static Dictionary<string, int> Dijkstra(Dictionary<string, List<Edge>> graph, string start)
    {
        var distances = new Dictionary<string, int>();
        var visited = new HashSet<string>();
        var queue = new PriorityQueue<string, int>();

        // Inicializa todas las distancias como infinitas
        foreach (var city in graph.Keys)
            distances[city] = int.MaxValue;

        distances[start] = 0;
        queue.Enqueue(start, 0);

        while (queue.Count > 0)
        {
            string current = queue.Dequeue();

            if (visited.Contains(current)) continue;
            visited.Add(current);

            foreach (var edge in graph[current])
            {
                int newDist = distances[current] + edge.Cost;
                if (newDist < distances[edge.Destination])
                {
                    distances[edge.Destination] = newDist;
                    queue.Enqueue(edge.Destination, newDist);
                }
            }
        }

        return distances;
    }

    static void Main()
    {
        // Grafo de vuelos
        var graph = new Dictionary<string, List<Edge>>
        {
            ["A"] = new List<Edge> { new Edge("B", 100), new Edge("C", 300) },
            ["B"] = new List<Edge> { new Edge("C", 50), new Edge("D", 200) },
            ["C"] = new List<Edge> { new Edge("E", 100) },
            ["D"] = new List<Edge> { new Edge("E", 30) },
            ["E"] = new List<Edge>()
        };

        Console.Write("Ciudad de origen: ");
        string origen = Console.ReadLine().ToUpper();

        Console.Write("Ciudad de destino: ");
        string destino = Console.ReadLine().ToUpper();

        var result = Dijkstra(graph, origen);

        if (result.ContainsKey(destino) && result[destino] != int.MaxValue)
        {
            Console.WriteLine($"El costo mínimo de {origen} a {destino} es: {result[destino]}");
        }
        else
        {
            Console.WriteLine("No existe ruta disponible entre esas ciudades.");
        }
    }
}