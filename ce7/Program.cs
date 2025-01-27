// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Stack<int> torre1 = new Stack<int>();
Stack<int> torre2 = new Stack<int>();
Stack<int> torre3 = new Stack<int>();


torre1.Push(3);
torre1.Push(2);
torre1.Push(1);

imprimirPila (torre1,"torre1");
imprimirPila (torre2,"torre2");
imprimirPila (torre3,"torre3");

torre2.Push (torre1.Pop());

void imprimirpila(Stack<int>pila){
    console.Writeline();
    console.Writeline($"los datos de la pila {nombrepila}");
    foreach(var item in pila){
        console.Writeline(item);
    }
}

