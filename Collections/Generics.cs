//Generic class

using System;

class Box<T>
{
    public T Value;
}

class Program
{
    static void Main()
    {
        Box<int> b1 = new Box<int>();
        b1.Value = 100;

        Box<string> b2 = new Box<string>();
        b2.Value = "Hello";
        
        Console.WriteLine(b1.Value);
        Console.WriteLine(b2.Value);
    }
}

// Generic method
using System;

class Program
{
    static void Print<T>(T data)
    {
        Console.WriteLine(data);
    }

    static void Main()
    {
        Print<int>(10);
        Print<string>("Hello");
        Print<double>(3.14);
    }
}
//Bounded Type parameters(Constraints)
using System;

class Myclass<T> where T : class
{
    public T data;
}

class Program
{
    static void Main()
    {
        Myclass<string> obj = new Myclass<string>();
    }
}

//Delegate - referance to a method

using System;

delegate int MathOp(int a, int b);
class program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        MathOp op = Add;
        Console.WriteLine(op(3, 4));
    }
}
//Closure - a function that remembers variables outside it
using System;

class Program
{
    static void Main()
    {
        int x = 10;
        Func<int, int> add = y => x + y;
        Console.WriteLine(add(5));
    }
}
//Event - used for notification
using System;

class Alarm
{
    public event Action OnRing;

    public void Ring()
    {
        OnRing?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        Alarm alarm = new Alarm();
        alarm.OnRing += () => Console.WriteLine("Alarm is ringing!");
        
        alarm.Ring();
    }
}

using System;
class Box<T>
{
    private T value;

    public void SetValue(T value)
    {
        this.value = value;
    }

    public T GetValue()
    {
        return value;
    }

    public static void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}

class Program
{
    static void Main()
    {
        Box<int> age = new Box<int>();
        age.SetValue(100);
        Console.WriteLine("Int value: " + age.GetValue());

        Box<int>.Print(10);
    }
}

using System;

class FlightBooking<T>
{
    private T BookingId;
    private T Seatnum;
    private string Name;

    public FlightBooking(T BookingId, T Seatnum, string Name)
    {
        this.BookingId = BookingId;
        this.Name = Name;
        this.Seatnum = Seatnum;
    }

    public override string ToString()
    {
        return $"BookingId: {BookingId}, Seatnum: {Seatnum}, Name: {Name}";
    }

    public static void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}

class Program
{
    static void Main()
    {
        FlightBooking<int> id = new FlightBooking<int>(101, 20,"Karthik");
        Console.WriteLine(id);
        FlightBooking<int>.Print(id);
        
    }
}

using System;

class Warehouse<T>
{
    private T Electronics;
    private T Groceries;
    private T furniture;
    private int id;

    public Warehouse(T electronics, T groceries, T furniture, int id)
    {
        this.Electronics = electronics;
        this.Groceries = groceries;
        this.furniture = furniture;
        this.id = id;
    }

    public override string ToString()
    {
        return $"Electronics: {Electronics}, Groceries: {Groceries}, Furniture: {furniture}, Id: {id}";
    }

    public static void display<T>(T data)
    {
        Console.WriteLine(data);
    }
}

class Program
{
    public static void Main()
    {
        Warehouse<string> w1 = new Warehouse<string>("Phone", "Apple", "Table", 10);
        Console.WriteLine(w1);
        Warehouse<string>.display(w1);
        

    }
}

