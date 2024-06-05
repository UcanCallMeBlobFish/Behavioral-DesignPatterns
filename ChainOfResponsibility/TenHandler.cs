namespace ConsoleApp1.ChainOfResponsibility;

public class TenHandler : Handler
{
    public TenHandler(Handler _next) : base(_next)
    {
    }

    public override void DoHandler(int final)
    {
        final += 10;
        if(Next is null) Console.WriteLine(final);
        else Next.DoHandler(final);
    }
}