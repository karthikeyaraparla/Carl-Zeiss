 using System;
 using System.Runtime.ExceptionServices;
 
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
        // new node and inserting an element at beginning
         Node newNode = new Node();
         newNode.data = 5;
         newNode.next = n1;
         n1 = newNode;
         
         //Insert at End
         Node end = new Node();
         end.data = 40;
         end.next = null;
         if (n1 == null)
         {
             n1 = end;
         }
         else
         {
             Node t = n1;
             while (t.next != null)
             {
                 t = t.next;
             }
 
             t.next = end;
         }
         
         Node temp = n1;
         
         while (temp != null)
         {
             Console.WriteLine(temp.data);
             temp = temp.next;
         }
     }
 
 }
 
 using System;
 
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
   n1.data = 5;
   n1.next = null;
   
   Node n2 = new Node();
   n2.data = 10;
   n2.next = null;
   
   Node n3 = new Node();
   n3.data = 20;
   n3.next = null;
   
   Node n4 = new Node();
   n4.data = 30;
   n4.next = null;
   
 
   n1.next = n2;
   n2.next = n3;
   n3.next = n4;
 
   Node prev = null;
   Node curr = n1;
   Node next = null;
 
   while (curr != null)
   {
    next = curr.next;
    curr.next = prev;
    prev = curr;
    curr = next;
   }
   n1 = prev;
   Node temp = n1;
   while (temp != null)
   {
    Console.WriteLine(temp.data);
    temp = temp.next;
   }
   {
    
   }
  }
 }
 
 using System;
 
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
 
         Node n2 = new Node();
         n2.data = 20;
 
         Node n3 = new Node();
         n3.data = 30;
 
         n1.next = n2;
         n2.next = n3;
 
         int value = 10;
 
         if (n1 == null)
         {
             Console.WriteLine("List is empty");
             return;
         }
 
         if (n1.data == value)
         {
             n1 = n1.next;
             return;
         }
 
         Node prev = n1;
         Node curr = n1.next;
 
         while (curr != null && curr.data != value)
         {
             prev = curr;
             curr = curr.next;
         }
 
         if (curr == null)
         {
             Console.WriteLine("Value is not found");
         }
         else
         {
             prev.next = curr.next;
         }
     }
 }
 
 
