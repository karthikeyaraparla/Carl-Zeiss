//Single cast
 using System;
 delegate int MathOperation(int a, int b);

 class Program
 {
     static int Add(int a, int b)
     {
         return a + b;
     }

     static int Multiply(int a, int b)
     {
         return a * b;
     }

     static void Main()
     {
         MathOperation op = Add;
         Console.WriteLine(op(3,4));

         op = Multiply;
         Console.WriteLine(op(3,4));
     }
 }

 //storing A and B as reference and only prints the last C

 using System;
 delegate string Playlist(string songa, string songb, string songc);

 class Program
 {
     static string A(string songa, string songb, string songc) => songa;
     static string B(string songa, string songb, string songc) => songb;
     static string C(string songa, string songb, string songc) => songc;

     static void Main()
     {
         Playlist P = A;
         P += B;
         P += C;

         string result = P("Into it", "Swim", "Heaven and Back");
         Console.WriteLine(result);

     }
     
 }

 //Multicast
 using System;

 delegate void del();

 class Program
 {
     static void A() => Console.WriteLine("This is A");
     static void B() => Console.WriteLine("This is B");
     static void C() => Console.WriteLine("This is C");

     static void Main()
     {
         del d = A;
         d += B;
         d += C;
         d();
     }
     

 }

 //Anonymus Method
 using System;

 delegate int Mathop(int a, int b);

 class Program
 {
     static void Main()
     {
         Mathop op = delegate(int a, int b) //this is anonymus method
         {
             return a + b;
         };
         Console.WriteLine(op(3,4));

     }
 }

 //Lambda expressions
 using System;

 delegate int MathOp(int a, int b);

 class Program
 {
     static void Main()
     {
         MathOp op = (a, b) => a + b;
         Console.WriteLine(op(5,7));
     }
 }
