namespace ConsoleApp1.ChainOfResponsibility;

public class FiveHandler : Handler
{
    public FiveHandler(Handler _next) : base(_next)
    {
    }

    public override void DoHandler(int final)
    {
        final += 5;
        if (Next is  null) Console.Write(final);
        else Next.DoHandler(final);
    }
}