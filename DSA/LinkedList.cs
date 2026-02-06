 using System;
 using System.Runtime.ExceptionServices;
 
 //Create and Traverse Linked List
 class Node
 {
     public int data;
     public Node next;
     public Node prev;
 }
 
 class Program
 {
     static void Main()
     {
         Node n1 = new Node();
         n1.prev = null;
         n1.data = 10;
         n1.next = null;
 
         Node n2 = new Node();
         n2.prev = null;
         n2.data = 20;
         n2.next = null;
 
         Node n3 = new Node();
         n3.prev = null;
         n3.data = 30;
         n3.next = null;
 
         n2.prev = n1;
         n3.prev = n2;
         n1.next = n2;
         n2.next = n3;
        // new node and inserting an element at beginning
         Node newNode = new Node();
         newNode.data = 5;
         newNode.next = n1;
         
         
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
         
         Node temp = newNode;
         
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
 
 
 
 using System;
 using System.Runtime.ExceptionServices;
 
 class Node
 {
     public int data;
     public Node next;
 }
 
 class program
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
         
         //newnode
         Node NewNode = new Node();
         NewNode.data = 5;
         NewNode.next = null;
 
         NewNode.next = n1;
         n1.next = n2;
         n2.next = n3;
         
         
         //Insertion of element at the end
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
 
         Node temp = NewNode;
         while (temp != null)
         {
             Console.WriteLine(temp.data);
             temp = temp.next;
         }
     }
     
 }
 
 
 using System;
 using System.Runtime.Versioning;
 
 class Node
 {
     public int data;
     public Node next;
     public Node prev;
 }
 
 class Program
 {
     static void Main()
     {
         Node n1 = new Node();
         n1.data = 10;
         n1.prev = null;
         n1.next = null;
 
         Node n2 = new Node();
         n2.prev = null;
         n2.data = 20;
         n2.next = null;
 
         Node n3 = new Node();
         n3.prev = null;
         n3.data = 30;
         n3.next = null;
         
         //New node at the beginning
         Node NewNode = new Node();
         NewNode.prev = null;
         NewNode.data = 10;
         NewNode.next = n1;
 
         n1.prev = NewNode;
         n1 = NewNode;
         
         n2.prev = n1;
         n3.prev = n2;
         n1.next = n2;
         n2.next = n3;
         
         //Insert at end
         Node end = new Node();
         end.data = 40;
         end.next = null;
         end.prev = n3;
 
         Node t = n1;
         if (n1 == null)
         {
             n1 = end;
         }
         else
         {
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
 