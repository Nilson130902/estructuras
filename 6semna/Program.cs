public class Node
{
    public int data;
    public Node? next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

public class LinkedList
{
    public Node? head;

    public Node ReverseList(Node head)
    {
        // Caso base: lista vacía o con un solo nodo
        if (head == null || head.next == null)
        {
            return head;
        }
        

        // Recursión: invertir el resto de la lista
        Node newHead = ReverseList(head.next);

        // Invertir el enlace del nodo actual
        head.next.next = head;
        head.next = null;

        // Retornar la nueva cabeza
        return newHead;
    }
}