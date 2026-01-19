//Self Problems

using System;

class Program
{
    static void Main()
    {
        //1. Calculate Simple Interest
        Console.Write("Principal: ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write(("Enter the Rate: "));
        double rate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the Time(in years): ");
        double time = double.Parse(Console.ReadLine());

        double interest = (principal * rate * time)/100;
        
        Console.WriteLine("Simple Interest = " + interest);
        
        //2. Perimeter of a Rectangle
        Console.Write("Length: ");
        double length = double.Parse(Console.ReadLine());
        
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());

        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of Rectangle: " + perimeter);
        
        //3.Power Calculation
        Console.Write("Exponent: ");
        double exponent = double.Parse(Console.ReadLine());
        
        Console.Write("Base: ");
        double BaseNumber = double.Parse(Console.ReadLine());

        double expo = Math.Pow(BaseNumber, exponent);
        Console.WriteLine("Exponent: " + expo);

        //4.Calculate Average of Three Numbers
        Console.Write("First num: ");
        double first = double.Parse(Console.ReadLine());
        
        Console.Write("Second num: ");
        double sec = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Third num:");
        double third = double.Parse(Console.ReadLine());

        double average = (first + sec + third) / 3;
        Console. WriteLine("Average of three numbers: " + average);

        //5. Convert Kilometers to Miles
        Console.Write("Kilometers");
        double kilo = double.Parse(Console.ReadLine());
        double miles = kilo * 0.621371;
        Console.WriteLine("Miles = " + miles);
    }
}
