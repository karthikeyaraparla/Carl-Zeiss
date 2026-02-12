 //List<T> is like a dynamic array
 using System;
 using System.Collections.Generic;

 class Program
 {
     static void Main()
     {
         List<int> numbers = new List<int>();
         
         numbers.Add(10);
         numbers.Add(20);
         numbers.Add(30);
         
         Console.WriteLine("First Element: "+ numbers[0]);

         foreach (int n in numbers)
         {
             Console.WriteLine(n);
         }
     }
 }

 //LinkedList<T>
 using System;
 using System.Collections.Generic;

 class Program
 {
     static void Main()
     {
         LinkedList<int> list = new LinkedList<int>();
         
         list.AddFirst(10);
         list.AddLast(20);
         list.AddLast(30);

         foreach (int x in list)
         {
             Console.WriteLine(x);
         }
     }
 }
 //Stack<T> (LIFO)
 using System;
 using System.Collections.Generic;

 class Program
 {
     static void Main()
     {
         Stack<int> s1 = new Stack<int>();

         s1.Push(10);
         s1.Push(20);
         
         Console.WriteLine("Top: " + s1.Peek());
         Console.WriteLine("Popped: " + s1.Pop());
         

         foreach (int x in s1)
         {
             Console.WriteLine("Left out elements are: " + x);
         }
     }
 }
 //Queue<T> (FIFO)
 using System;
 using System.Collections.Generic;

 class Program
 {
     static void Main()
     {
         Queue<int> queue = new Queue<int>();
         queue.Enqueue(10);
         queue.Enqueue(20);
         queue.Enqueue(30);
         
         Console.WriteLine("Top: " + queue.Peek());
         Console.WriteLine("Removed: " + queue.Dequeue());

         foreach (int i in queue)
         {
             Console.WriteLine("Remaining elements are: " + i);
         }
     }
 }

 //Hashset

 using System;
 using System.Collections.Generic;

 class Program
 {
     static void Main()
     {
         HashSet<int> set = new HashSet<int>();
         set.Add(10);
         set.Add(20);
         set.Add(30);
         set.Add(20);

         foreach (int x in set)
         {
             Console.WriteLine("Elements are: " + x);
         }
     }
 }
}

