using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("you entered: " + num);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a number");
        }
        finally
        {
            Console.WriteLine("This will always execute (cleanup code");
        }
    }
}