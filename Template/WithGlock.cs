namespace ConsoleApp1.Template;

public class WithGlock : KillWithGun
{
    protected override void Shot()
    {
        Console.WriteLine("Shot with Glock");
    }
}