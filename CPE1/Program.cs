using System;
using System.Collections.Generic;

class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }

    public Contacto(string nombre, string telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
    }
}

class AgendaTelefonica
{
    private List<Contacto> contactos;

    public AgendaTelefonica()
    {
        contactos = new List<Contacto>();
    }

    public void AgregarContacto(string nombre, string telefono)
    {
        Contacto nuevoContacto = new Contacto(nombre, telefono);
        contactos.Add(nuevoContacto);
    }

    public void MostrarContactos()
    {
        if (contactos.Count == 0)
        {
            Console.WriteLine("No hay contactos en la agenda.");
        }
        else
        {
            foreach (var contacto in contactos)
            {
                Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}");
            }
        }
    }

    public void BuscarContacto(string nombre)
    {
        var contacto = contactos.Find(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (contacto != null)
        {
            Console.WriteLine($"Contacto encontrado: Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }

    public void EliminarContacto(string nombre)
    {
        var contacto = contactos.Find(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (contacto != null)
        {
            contactos.Remove(contacto);
            Console.WriteLine("Contacto eliminado.");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.");
        }
    }
}

class Program
{
    static void Main()
    {
        AgendaTelefonica agenda = new AgendaTelefonica();

        while (true)
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Eliminar contacto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre del contacto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el teléfono del contacto: ");
                    string telefono = Console.ReadLine();
                    agenda.AgregarContacto(nombre, telefono);
                    break;
                case 2:
                    agenda.MostrarContactos();
                    break;
                case 3:
                    Console.Write("Ingrese el nombre del contacto a buscar: ");
                    string nombreBuscar = Console.ReadLine();
                    agenda.BuscarContacto(nombreBuscar);
                    break;
                case 4:
                    Console.Write("Ingrese el nombre del contacto a eliminar: ");
                    string nombreEliminar = Console.ReadLine();
                    agenda.EliminarContacto(nombreEliminar);
                    break;
                case 5:
                    Console.WriteLine("Saliendo de la agenda.");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
