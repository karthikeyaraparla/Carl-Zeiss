namespace Collections;

public class Alarm
{
    public event Action OnRing;

    public void Ring()
    {
        Console.WriteLine("Alarm is ringing");
        OnRing?.Invoke();
    }
}

class Program
{
    static void Main()
    {
        Alarm alarm = new Alarm();

        alarm.OnRing += () => Console.WriteLine("Wake up! Event Received.");
        alarm.Ring();
    }
}