namespace ConsoleApp1.Iterator;

public class History
{
    public Stack<string> urls = new Stack<string>();

    public Iterator<string> CreateIterator()
    {
        return new StackConcreteIterator(this);
    }
}