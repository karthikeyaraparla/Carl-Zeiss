using System;
using System.IO;

class DirInfo{
    public static void Run(){
        DirectoryInfo dir = new DirectoryInfo("MyData");

        if(!dir.Exists){
            dir.Create();
        }

        Console.WriteLine("Folder Name: "+dir.Name);
        Console.WriteLine("Full Path: " + dir.FullName);
    }
}