using System;
using System.IO;

class Fi{

    public static void Run(){
        string path = "Mydata/hello.txt";

        File.WriteAllText(path, "Hello from File class!");
        Console.WriteLine("File written!");

        string content = File.ReadAllText(path);
        Console.WriteLine("File Cotent: " + content);

    }
}