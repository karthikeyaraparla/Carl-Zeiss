using System;


class Parent
{
    protected List<int> numbers;

    public Parent(List<int> numbers)
    {
        this.numbers = numbers;
    }
    public virtual void Process()
    {
        Console.WriteLine("Processing");
    }
}
class NumProcessor : Parent
{
    public NumProcessor(List<int> numbers) : base(numbers)
    {
    }

    public override void Process()
    {
        var filtered = numbers.Where(n => n >= 0).ToList();
        var squared = filtered.Select(n => n * n).ToList();
        squared.Sort();

        foreach (int num in squared)
        {
            Console.Write(num + " ");
        }
    }
}
class Program
{
    static void Main()
    {
        List<int> inputNums = new List<int> { -4, -1, 0, 3, 10 };
        NumProcessor processor = new NumProcessor(inputNums);
        processor.Process();
    }
}