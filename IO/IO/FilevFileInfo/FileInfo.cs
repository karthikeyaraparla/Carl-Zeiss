using System;
using System.IO;

class FileI
{
    public static void Run()
    {
        FileInfo fi = new FileInfo("MyData/info.txt");
        using (StreamWriter sw = fi.CreateText())
        {
            sw.WriteLine("Hello from FileInfo!");
        }

        Console.WriteLine("File Size: " + fi.Length + " bytes");
        Console.WriteLine("Created At: " + fi.CreationTime);
    }
   
}
