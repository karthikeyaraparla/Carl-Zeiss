using System;

class StackArray
{
    public int[] stack;
    public int size;
    public int top;

    void Push(int value)
    {
        if (top == size - 1)
        {
            Console.WriteLine("It is Overflow");
        }
        else
        {
            top = top + 1;
            stack[top] = value;
            Console.WriteLine("pushed: " + value);
        }
    }

    void Pop()
    {
        if (top == -1)
        {
           Console.WriteLine("It is underflow");
        }
        else
        {
            int popped = stack[top];
            top--;
            Console.WriteLine("Popped: "+popped);
        }
    }

    void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
        }
        else
        {
            Console.WriteLine(stack[top]);
        }
    }

    void display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is emoty");
        }
        else
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }

    public static void Main()
    {
        StackArray s = new StackArray();
        s.size = 5;
        s.stack = new int[s.size];
        s.top = -1;
        s.Push(5);
        s.Push(7);
        s.Push(7);
        s.Pop();
        s.display();   
        Console.WriteLine(s.top);
    }
    
}

//stack using LL

 class Node
 {
     public int data;
     public Node next;
 }

 class StackLL
 {
     public Node top;

     public StackLL()
     {
         top = null;
     }

     void Push(int value)
     {
         Node newNode = new Node();
         newNode.data = value;
         newNode.next = top;
         
     }

     void Pop()
     {
         if (top == null)
         {
             Console.WriteLine("It is underflow");
         }
         else
         {
             int popped = top.data;
             top = top.next;
             Console.WriteLine(popped);
         }
     }

     void Peek()
     {
         if (top == null)
         {
             Console.WriteLine("Stack is Empty");
         }
         else
         {
             Console.WriteLine("Top element is " + top.data);
         }
     }

     void Display()
     {
         if (top == null)
         {
             Console.WriteLine("Stack is elements: ");
         }

         else
         {
             Console.WriteLine("Stack elements: ");
             Node temp = top;
             while (temp != null)
             {
                 
             }
         }
     }
     

     public static void Main()
     {
         StackLL s1 = new StackLL();
         s1.Push(10);
         s1.Push(20);
         s1.Push(30);
         s1.Pop();
         s1.Peek();
         
     }
 }






