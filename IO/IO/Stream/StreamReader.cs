using System;
using System.IO;

class Reader
{
    public static void Run()
    {
        using (StreamReader reader = new StreamReader("MyData/log.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
