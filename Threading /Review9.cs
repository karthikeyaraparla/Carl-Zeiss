using System;
using System.Threading;
using System.Threading.Tasks;

class paymentProcess
{
    private static SemaphoreSlim semaphore = new SemaphoreSlim(3);

    public static async Task ProcessPayment(int paymentId)
    {
        Console.WriteLine($"Payment {paymentId} waiting");

        await semaphore.WaitAsync();
        try
        {
            Console.WriteLine($"Payment {paymentId} started");
            await Task.Delay(2000);

            Console.WriteLine($"Payment {paymentId} completed");
        }
        finally
        {
            semaphore.Release(); 
        }
    }
}
class Program
{
    static async Task Main()
    {
        Task[] tasks = new Task[10];

        for (int i = 0; i < tasks.Length; i++)
        {
            int id = i + 1;
            tasks[i] = paymentProcess.ProcessPayment(id);
        }
        await Task.WhenAll(tasks);
        Console.WriteLine("All payments processed");
    }
}
