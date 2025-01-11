// ///
// using System.Runtime.CompilerServices;

// Console.WriteLine("clases de matrices!");
// string[] nombres = {"ana", "pedro"}; 
// string[] cursos = {"primero", "segundo","tercero"};

// Console.WriteLine();

// Console.WriteLine(nombres[1]);

// Console.WriteLine("el elemto del vector nombres en la posicon 0 es:" + nombres[0]);
// Console.WriteLine("el elemto del vector nombres en la posicon 1 es:" + nombres[1]);
// Console.WriteLine("el elemto del vector nombres en la posicon  " + 1 + " es: " + nombres[1]);
// Console.WriteLine("El elemento del vector nombre en la posicion {0} es: {1}", 1, nombres[1]);
// int elemento = 1;
// Console.WriteLine($"El elemento del vector nombre en la posicion {elemento} es: {nombres[elemento]} y ha isdo un guston {nombres[elemento]}");

// for (int i = 0; i < nombres.Length; i++)
// {
//     Console.WriteLine(nombres[i]);
// }

// foreach (var item in nombres)//var indentifica que tipo de datos es 
// {
//     Console.WriteLine(item.ToUpper());//ToUpper hace mayusculas
// }
// ///
// int a =5 ;
// string [] estudiantes = new string [10];

 List<string> nombres =["ana", "felipe", "carlos"];

// foreach (var item in nombres)
// {
//     Console.WriteLine(item.ToUpper());
// }

// Console.WriteLine($"el elemnto de la lista estudiantes en la posicion 2 es: {nombres[2]}");

String buscar ="tatiana";
var indice = nombres.IndexOf("buscar");
if (indice == -1)
{
    Console.WriteLine($"elelemnto {buscar} no esxite en la lista de nombres");
} else{
     Console.WriteLine($"elelemnto {buscar} se encuentra en al posicon {indice} de la lista de nombre");
     
}