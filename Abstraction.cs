//Abstraction is achieved using Abstract class and Interface
//Abstraction using Interface
using System;

interface Ivehicle
{
    void Start();
}

class car : Ivehicle
{
    public void Start()
    {
        Console.WriteLine("Car starts with keys");
    }
}

class bike : Ivehicle
{
    public void Start()
    {
        Console.WriteLine("Bike starts with kick");
    }
}

class program
{
    static void Main()
    {
        Ivehicle v1 = new bike();
        Ivehicle v2 = new car();
        v1.Start();
        v2.Start();
    }
}

//Abstraction using Abstract class
using System;

abstract class Vehicle
{
    public abstract void Start();
    public abstract void Stop();

    public void Fuel()
    {
        Console.WriteLine("Vehicle Needs Fuel");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car starts with key");
    }

    public override void Stop()
    {
        Console.WriteLine("Push the button");
    }
}

class program
{
    static void Main()
    {
        Vehicle v = new Car();
        v.Start();
        v.Fuel();
        v.Stop();
    }
}
