namespace ConsoleApp1.Observer;

public class CarConcreteObserver: IObserver
{
    public void Update()
    {
        Console.Write("Car is notified");
    }
}