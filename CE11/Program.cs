// See https://aka.ms/new-console-template for more information
Console.WriteLine("Universidad estatal amazonica");
Console.WriteLine("Estructura de datos");
Console.WriteLine();


//discionari
// Dictionary<int, string> estudiante = new Dictionary<int, string>();
// estudiante.Add(1,"Ana");
// estudiante.Add(2,"Jose");

//error al repetir la clave(key)

// try
// {
//     estudiante.Add(2,"Arturo");
// }
// catch (System.Exception)
// {
    
//     System.Console.WriteLine("Ha ocurrido un error, contactese con el administrador");
//     throw;
// }

//diccionario español ingles 
Dictionary<string, string> diccionario = new Dictionary<string, string>();
diccionario.Add("dia","day");
diccionario.Add("noche","night");
diccionario.Add("paz","peace");
diccionario["noche"]= "Night";

string frase = "Noche de paz , noche de amor , todo brilla";//

string[] palabras = frase.Split(" ");

//System.Console.WriteLine(frase);
foreach (var item in palabras) // recorre cada una de las palabras de la frase
{
    if (diccionario.ContainsKey(item) )
    {
        System.Console.WriteLine(diccionario[item]);
    }else {
        System.Console.WriteLine(item);
    }   
}
