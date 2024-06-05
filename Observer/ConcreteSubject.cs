namespace ConsoleApp1.Observer;

public class ConcreteSubject : TotalSubject
{
    private int total { get; set; }

    public ConcreteSubject(int t)
    {
        total = t;
    }


    public void set(int p)
    {
        total = p;
        NotifyAll();
    }
}