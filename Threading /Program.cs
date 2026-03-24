using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Threading.Tasks;
using System.Threading.Channels;
public class threading
{
    public static void Main()
    {
        Thread thread = new Thread(() =>
        {
            Thread.Sleep(3000);
            Console.WriteLine(("Running..."));
        });
        
        Console.WriteLine($"State of thread 1 before starting: {thread.ThreadState}");
        
        thread.Start();
        Console.WriteLine($"State of thread 1 after starting: {thread.ThreadState}");
        Console.WriteLine($"Thread 1 is alive or not: {thread.IsAlive}");
        Thread.Sleep(2000);
        Console.WriteLine($"Thread State (During Sleep): {thread.ThreadState}");
        thread.Join();
        Console.WriteLine($"Thread State (After Join): {thread.ThreadState}");
        
    
        Thread thread1 = new Thread(() => Countdown("Timer 1"));
        Thread thread2 = new Thread(()=> Countup("Timer 2"));
        thread1.Start();
        thread2.Start();
        
        
        
    }
    public static void Countdown(string name)
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"Timer 1: {i}");
            Thread.Sleep(1000);
        }
    }
    
    public static void Countup(String name)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Timer 2: {i}");
            Thread.Sleep(1000);
        }
    }

    public static async Task Main()
    {
        Task t1 = Downloadfile("browser", 1000);
        Task t2 = Downloadfile("music", 4000);
        Task t3 = Downloadfile("clock", 10000);
    
        Console.WriteLine("All downloads started>>>>");
    
        await Task.WhenAll(t1, t3, t2);
        Console.WriteLine("All downloads completed!");
    }
    
    public static async Task Downloadfile(string filename, int delay)
    {
        Console.WriteLine($"{filename} started");
        await Task.Delay(delay);
    
        Console.WriteLine($"{filename} completed");
    }
    
}