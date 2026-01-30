using System;
//Create and Traverse Linked List
class Node
{
    public int data;
    public Node next;
}

class Program
{
    static void Main()
    {
        Node n1 = new Node();
        n1.data = 10;
        n1.next = null;

        Node n2 = new Node();
        n2.data = 20;
        n2.next = null;

        Node n3 = new Node();
        n3.data = 30;
        n3.next = null;

        n1.next = n2;
        n2.next = n3;

        Node temp = n1;
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

}