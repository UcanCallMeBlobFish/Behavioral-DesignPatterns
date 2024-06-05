namespace ConsoleApp1.Template;

public abstract class KillWithGun
{

    private void OpenDoor()
    {
        Console.WriteLine("Door Is Open");
    }
    
    public void Execute()   //OpensTheDoor And kill with specific GUn
    {
           OpenDoor();
           Shot();
    }

    protected abstract void Shot();


}