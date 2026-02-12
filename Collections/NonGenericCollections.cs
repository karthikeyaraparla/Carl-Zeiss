 //Arraylist
 using System;
 using System.Collections;

 class Program
 {
     static void Main()
     {
         ArrayList list = new ArrayList();
         list.Add(10);
         list.Add("Hello");
         list.Add(3.14);
         list.Remove(3.14);
         list.Insert(0, "karthik");
         list.RemoveAt(2);
         foreach (var item in list)
         {
             Console.WriteLine(item);
         }
     }
 }

//Student database
 using System;
 using System.Collections;

 class Program
 {
     static void Main()
     {
         ArrayList students = new ArrayList();
         bool running = true;

         while (running)
         {
             Console.WriteLine("1. Add student(Create)");
             Console.WriteLine("2. View Students(Read)");
             Console.WriteLine("3. Update Student(update)");
             Console.WriteLine("4. Delete Student (Delete)");
             Console.WriteLine("5. Exit");
             Console.WriteLine("Enter choice: ");

             int choice = int.Parse(Console.ReadLine());
             switch (choice)
             {
                 case 1:
                     Console.WriteLine("Enter student name: ");
                     string name = Console.ReadLine();
                     students.Add(name);
                     Console.WriteLine("Students added!");
                     break;
                 case 2:
                     Console.WriteLine(("Students List: "));
                     for (int i = 0; i < students.Count; i++)
                     {
                         Console.WriteLine(students[i]);
                     }

                     break;
             }
         }
     }
 }

 //Hashtable

 using System;
 using System.Collections;

 class Program
 {
     static void Main()
     {
         Hashtable students = new Hashtable();
         students.Add(1, "karthik");
         students.Add(2, "karthikeya");
         
         students.Remove(2);

         students[1] = "Nandu";

         foreach (DictionaryEntry item in students)
         {
             Console.WriteLine($"{item.Key} {item.Value}");
         }
     }
 }

//Stack in Nongeneric collections

 using System;
 using System.Collections;

 class Program
 {
     static void Main()
     {
         Stack stack = new Stack();
         
         stack.Push(10);
         stack.Push(20);
         stack.Peek();
         stack.Pop();

         foreach (var item in stack)
         {
             Console.WriteLine(item);
         }
     }
 }

 //Queue 

 using System;
 using System.Collections;

 class Program
 {
     static void Main()
     {
         Queue q1 = new Queue();
         
         q1.Enqueue(10);
         q1.Enqueue(20);
         q1.Enqueue(30);

         q1.Dequeue();
         q1.Peek();

         foreach (var items in q1)
         {
             Console.WriteLine(items);
         }
     }
 }
