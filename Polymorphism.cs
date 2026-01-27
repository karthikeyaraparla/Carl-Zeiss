//Runtime Polymorphism (Method Overriding using Inheritance)
using System;
namespace Inheritance;

class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal Eating");
    }
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dog Eating");
    }
}

class Inheritance
{
    public static void Main()
    {
        Animal d = new Dog();
        d.Eat();
    }
}


// Compile-Time Polymorphism (Method Overloading)
using System;

class cal
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class program
{
    static void Main()
    {
        cal c = new cal();
        Console.WriteLine(c.Add(2,3));
        Console.WriteLine(c.Add(2, 3, 4));
    }
}
