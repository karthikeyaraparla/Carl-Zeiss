
using System;
namespace MyNamespace;

public class Accessm
{
    public int a;
    protected internal int b;
    protected int c;

    internal int d;
    private protected int e;
    private int f;

    public void dispa()
    {
        a = 100;
        Console.WriteLine("The value of a is {0}",a);
    }

    protected internal void dispb()
    {
        b = 200;
        Console.WriteLine("The value of b is {0}",b);
    }
    protected void dispc()
    {
        c = 300;
        Console.WriteLine("The value of c is {0}",c);
    }
    internal void dispd()
    {
        d = 400;
        Console.WriteLine("The value of d is {0}",d);
    }
    private protected void dispe()
    {
        e = 500;
        Console.WriteLine("The value of e is {0}",e);
    }

    private void dispf()
    {
        f = 600;
        Console.WriteLine("The value of f is {0}", f);
    }

    static void Main(string[] args)
    {
        Accessm ob1 = new Accessm();
        ob1.dispa();
        ob1.dispb();
        ob1.dispc();
        ob1.dispd();
        ob1.dispe();
        ob1.dispf();
    }


}