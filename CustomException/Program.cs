using System;

// Custom exception class
public class InsufficientBalanceException : Exception
{
    public decimal RequiredAmount { get; set; }
    public decimal CurrentBalance { get; set; }

    public InsufficientBalanceException(decimal required, decimal current)
        : base($"Insufficient balance. Required: {required}, Available: {current}")
    {
        RequiredAmount = required;
        CurrentBalance = current;
    }
}

class BankAccount
{
    private decimal balance = 1000;

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException(amount, balance);
        }
        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}, Remaining: {balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        try
        {
            account.Withdraw(1500);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Shortage: {ex.RequiredAmount - ex.CurrentBalance}");
        }
    }
}