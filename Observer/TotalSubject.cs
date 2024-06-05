namespace ConsoleApp1.Observer;

public abstract class TotalSubject
{
    protected List<IObserver> Items = new List<IObserver>();

    public void attach(IObserver obs)
    {
        Items.Add(obs);
    }

    public void Detach(IObserver obs)
    {
        Items.Remove(obs);
    }

    public void NotifyAll()
    {
        foreach (var obs in Items)
        {
             obs.Update();   
        }
    }
}