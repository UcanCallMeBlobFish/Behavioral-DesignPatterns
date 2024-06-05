namespace ConsoleApp1.ChainOfResponsibility;

public class TwentyHandler : Handler
{
    public TwentyHandler(Handler _next) : base(_next)
    {
    }

    public override void DoHandler(int final)
    {
        final += 20;
        if (Next is null) Console.WriteLine(final);
        else Next.DoHandler(20);
    }
}