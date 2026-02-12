namespace Collections;

class Closures
{
    static void Main()
    {
        int x = 10;
        Func<int, int> add = y => x + y;
        Console.WriteLine(add(10));

         x = 20;
        Console.WriteLine(add(10));
    }
}

//Closure with counter
using System;

class program
{
    static Func<int> CreateCounter()
    {
        int count = 0;
        return () =>
        {
            count++;
            return count;
        };
    }

    static void Main()
    {
        var counter = CreateCounter();
        Console.WriteLine(counter());
        Console.WriteLine(counter());
    }
}
