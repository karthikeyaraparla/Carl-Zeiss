using System;
using System.IO;

class Writer{
    public static void Run(){
        using (StreamWriter writer = new StreamWriter("MyData/log.txt")){
            writer.WriteLine("Line 1");
            writer.WriteLine("Line 2");
            writer.WriteLine("Line 3");
        }
        Console.WriteLine("Text written using streamwriter");
    }
}