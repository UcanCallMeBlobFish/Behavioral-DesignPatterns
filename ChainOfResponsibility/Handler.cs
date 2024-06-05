namespace ConsoleApp1.ChainOfResponsibility;

public abstract class Handler
{
    protected Handler Next;

    public Handler(Handler _next)
    {
        Next = _next;
    }

    public abstract void DoHandler(int final);
    
}