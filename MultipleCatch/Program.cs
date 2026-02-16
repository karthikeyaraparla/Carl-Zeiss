using System;

class Program
{
    static void Main()
    {
        try
        {
            string text = null;
            Console.WriteLine(text.Length);

            int x = 10;
            int y = 0;
            Console.WriteLine(x / y);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Error: Object is null!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero!");
        }
        catch (Exception)
        {
            Console.WriteLine("Some other error occurred!");
        }
    }
}