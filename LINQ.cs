using System;
using System.Collections.Generic;
using System.Linq;
using LINQ.Models;

public class Linq
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 50, 20, 20, 100, 60, 30 };
        List<int> resultwithoutlinq = new List<int>();
        foreach (int n in numbers)
        {
            if (n > 50)
            {
                resultwithoutlinq.Add(n);
            }
        }

        Console.WriteLine("Without LINQ: ");
        foreach (var x in resultwithoutlinq)
        {
            Console.WriteLine(x);
        }

        var resultwithLinq = numbers.Where(n => n > 50);
        Console.WriteLine("with Linq");
        foreach (var n in resultwithLinq)
        {
            Console.WriteLine(n);
        }

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Karthikeya", Department = "NWC", Salary = 50000 },
            new Employee { Id = 2, Name = "Nandu", Department = "SOC", Salary = 60000 }
        };
        var highpaid = employees.Where(e => e.Salary > 50000);
        employees.Add(new Employee{Id = 3, Name = "Nandan", Department = "IT", Salary = 80000});
        Console.WriteLine("Highest Paid: ");

        foreach (var e in highpaid)
        {
            Console.WriteLine(e.Name);
        }


        List<Student> students = new List<Student>
        {
            new Student {Name = "Karthik", RollNo = 22, Marks = 25},
            new Student {Name = "Nandu", RollNo = 23, Marks = 75}
        };
        var highestmarks = students.Where(s => s.Marks > 50);
        foreach (var st in highestmarks)
        {
            Console.WriteLine($"Highest marks: {st.Name}");
        }
        
        // Aggregations
        List<Product> products = new List<Product>
        {
            new Product { Name = "Airpods", Category = "Electronics", price = 20000 },
            new Product { Name = "Shirt", Category = "Fashion", price = 2000 }
        };

        Console.WriteLine("How many products are there: " + products.Count);
        Console.WriteLine("Sum: "+products.Sum(p => p.price));
        Console.WriteLine("Min: "+products.Min(p => p.price));
        Console.WriteLine("Max: "+products.Max(p => p.price));
        Console.WriteLine("Avg: " + products.Average(p => p.price));
    }
}
