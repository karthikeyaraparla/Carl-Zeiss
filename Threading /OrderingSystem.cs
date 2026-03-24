using System.Threading;

public class BankAccount
{
    static object _lock = new object();
    static int balance = 1000;
    private static SemaphoreSlim semaphore = new SemaphoreSlim(1);
    static async Task Depositasync()
    {
        
        for (int i = 0; i < 5; i++)
        {
            // lock (_lock)
            // {
            //     balance += 100;
            //     Console.WriteLine($"Deposited 100, New Balance: {balance}");
            //     
            // }
            await semaphore.WaitAsync();
            try
            {
                balance += 100;
                Console.WriteLine($"Deposited 100, New Balance: {balance}");
            }
            finally
            {
                semaphore.Release();
            }

           await Task.Delay(1000);
        }
    }
    
    static void CheckBalance()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Checking Balance: {balance}");
            Thread.Sleep(1000);
        }
    }

    static async Task Withdraw()
    {
        for (int i = 0; i < 5; i++)
        {
            await semaphore.WaitAsync();
            try
            {
                if (balance >= 100)
                {
                    balance -= 100;
                    Console.WriteLine($"Withdrawn 100, Current balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
            finally
            {
                semaphore.Release();
            }

            await Task.Delay(1000);
        }
    }
    public static async Task Main()
    {
        Thread t1 = new Thread(Deposit);
        t1.Start();
        Thread t2 = new Thread(CheckBalance);
        t2.Start();
        Thread t3 = new Thread(Deposit);
        t3.Start();
        
        var t1 = Depositasync();
        var t2 = Withdraw();
        
        await Task.WhenAll(t1,t2);
    }
}