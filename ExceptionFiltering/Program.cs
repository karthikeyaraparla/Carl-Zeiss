using System;

class Program
{
    static void Main()
    {
        try
        {
            int age = -5;
            ValidateAge(age);
        }
        catch (ArgumentException ex) when (ex.ParamName == "age")
        {
            Console.WriteLine("Age validation failed!");
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Other argument error: {ex.Message}");
        }
    }

    static void ValidateAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("Age cannot be negative", "age");
        }
    }
}