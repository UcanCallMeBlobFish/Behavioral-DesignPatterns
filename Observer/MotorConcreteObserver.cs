namespace ConsoleApp1.Observer;

public class MotorConcreteObserver : IObserver
{
    public void Update()
    {
        Console.Write("motor notified");
    }
}