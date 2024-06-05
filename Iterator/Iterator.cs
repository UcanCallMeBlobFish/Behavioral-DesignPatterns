namespace ConsoleApp1.Iterator;

public interface Iterator<T>
{
    bool hasNext();
    T Current();
    void Next();
}