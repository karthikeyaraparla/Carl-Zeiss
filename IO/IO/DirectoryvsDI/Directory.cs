using System;
using System.IO;

class Dir{
    public static void Run(){
        string folderPath = "MyData";

        if(!Directory.Exists(folderPath)){
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Folder");
        }
        else{
            Console.WriteLine("Folder already exists");
        }
    }
}