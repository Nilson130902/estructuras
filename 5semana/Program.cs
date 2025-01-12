
// Crear y llenar la lista con los números del 1 al 10
List<int> numeros = new List<int>();
for (int i = 1; i <= 10; i++)
{
    numeros.Add(i);
}
// Mostrar los números en orden inverso separados por comas
numeros.Reverse(); // Invierte el orden de la lista
Console.WriteLine("Números en orden inverso:");
Console.WriteLine(string.Join(", ", numeros));