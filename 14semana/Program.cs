using System;

class Nodo
{
    public int Valor;
    public Nodo Izquierdo, Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = Derecho = null;
    }
}

class ArbolBinario
{
    public Nodo Raiz;

    public void Insertar(int valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);

        return nodo;
    }

    public void Inorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Inorden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            Inorden(nodo.Derecho);
        }
    }

    public void Preorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            Preorden(nodo.Izquierdo);
            Preorden(nodo.Derecho);
        }
    }

    public void Postorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izquierdo);
            Postorden(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }

    public bool Buscar(int valor)
    {
        return BuscarRecursivo(Raiz, valor);
    }

    private bool BuscarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null) return false;
        if (nodo.Valor == valor) return true;

        return valor < nodo.Valor
            ? BuscarRecursivo(nodo.Izquierdo, valor)
            : BuscarRecursivo(nodo.Derecho, valor);
    }
}

class Programa
{
    static void Main()
    {
        ArbolBinario arbol = new ArbolBinario();
        int opcion;

        do
        {
            Console.WriteLine("\n----- MENÚ -----");
            Console.WriteLine("1. Inserta nota");
            Console.WriteLine("2. Buscar nota");
            Console.WriteLine("3. Recorrer Inorden");
            Console.WriteLine("4. Recorrer Preorden");
            Console.WriteLine("5. Recorrer Postorden");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Introduce un valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    arbol.Insertar(valor);
                    break;
                case 2:
                    Console.Write("Nota a buscar: ");
                    int buscado = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(buscado) ? "Encontrado" : "No encontrado");
                    break;
                case 3:
                    Console.WriteLine("Recorrido Inorden:");
                    arbol.Inorden(arbol.Raiz);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Recorrido Preorden:");
                    arbol.Preorden(arbol.Raiz);
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("Recorrido Postorden:");
                    arbol.Postorden(arbol.Raiz);
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 6);
    }
}