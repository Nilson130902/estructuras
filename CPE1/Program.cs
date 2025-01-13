using System;
using System.Collections.Generic;

// Clase que representa un contacto en la agenda
class Contacto
{
    public string Nombre { get; set; } // Propiedad para el nombre del contacto
    public string Telefono { get; set; } // Propiedad para el teléfono del contacto

    
    public Contacto(string nombre, string telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
    }
}

// Clase para agenda telefónica
class AgendaTelefonica
{
    private List<Contacto> contactos; // Lista para guardar los contactos

    
    public AgendaTelefonica()
    {
        contactos = new List<Contacto>();
    }

    // Método para agregar contactos
    public void AgregarContacto(string nombre, string telefono)
    {
        Contacto nuevoContacto = new Contacto(nombre, telefono); // Crear un nuevo contacto
        contactos.Add(nuevoContacto); // Agregar un contacto 
        Console.WriteLine("Contacto agregado correctamente.");
    }

    // Método para mostrar los contactos
    public void MostrarContactos()
    {
        if (contactos.Count == 0) // Verificar si la lista está vacía
        {
            Console.WriteLine("No hay contactos en la agenda."); 
        }
        else
        {
            // Mostrar contactos de la lista
            foreach (var contacto in contactos)
            {
                Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}");
            }
        }
    }

    // Método para buscar un contacto por el nombre
    public void BuscarContacto(string nombre)
    {
        // Buscar el contacto ignorando mayúsculas o minúsculas
        var contacto = contactos.Find(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (contacto != null) // Si el contacto existe
        {
            Console.WriteLine($"Contacto encontrado: Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}");
        }
        else // Si no se encuentra el contacto
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }

    // Método para eliminar un contacto por el nombre
    public void EliminarContacto(string nombre)
    {
        // Buscar el contacto que coincida con el nombre ingnorando mayusculas y minisculas
        var contacto = contactos.Find(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (contacto != null) // Si el contacto existe
        {
            contactos.Remove(contacto); // Eliminar el contacto de la lista
            Console.WriteLine("Contacto eliminado.");
        }
        else // Si no se encuentra el contacto
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }
}

// Clase principal para el menú
class Program
{
    static void Main()
    {
        AgendaTelefonica agenda = new AgendaTelefonica(); // Crear una instancia de la agenda

        while (true) // Bucle mostrar el menú 
        {
            // Opciones del menú
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Eliminar contacto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            
            // Para leer la opción seleccionada por el usuario
            int opcion = int.Parse(Console.ReadLine());

            // Casos para las opciones dadas
            switch (opcion)
            {
                case 1:
                    // Solicitar datos para agregar un contacto
                    Console.Write("Ingrese el nombre del contacto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el teléfono del contacto: ");
                    string telefono = Console.ReadLine();
                    agenda.AgregarContacto(nombre, telefono); // Llamada del método para agregar el contacto
                    break;
                case 2:
                    agenda.MostrarContactos(); // Mostrar todos los contactos
                    break;
                case 3:
                    // Solicitar el nombre del contacto a buscar
                    Console.Write("Ingrese el nombre del contacto a buscar: ");
                    string nombreBuscar = Console.ReadLine();
                    agenda.BuscarContacto(nombreBuscar); // Llamada del método para buscar el contacto
                    break;
                case 4:
                    // Solicitar el nombre del contacto a eliminar
                    Console.Write("Ingrese el nombre del contacto a eliminar: ");
                    string nombreEliminar = Console.ReadLine();
                    agenda.EliminarContacto(nombreEliminar); // Llamada del método para eliminar el contacto
                    break;
                case 5:
                    Console.WriteLine("Saliendo de la agenda."); 
                    return; // Finalizacion del programa
                default:
                    Console.WriteLine("Opción no válida."); // Mensaje si la opción es incorrecta
                    break;
            }
        }
    }
}
