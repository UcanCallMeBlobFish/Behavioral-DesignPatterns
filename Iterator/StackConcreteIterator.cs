namespace ConsoleApp1.Iterator;

public class StackConcreteIterator : Iterator<string>
{
    private History _obj;
    private int count = 0;
    
    public StackConcreteIterator(History obj)
    {
        _obj = obj;
    }
    public bool hasNext()
    {
        return count <= _obj.urls.Count;
    }

    public string Current()
    {
        return _obj.urls.Peek();
    }

    public void Next()
    {
        _obj.urls.Pop();
        count++;
    }
}