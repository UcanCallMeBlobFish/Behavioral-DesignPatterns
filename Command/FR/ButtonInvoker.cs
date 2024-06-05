namespace ConsoleApp1.Command.FR;

public class ButtonInvoker
{
    private readonly ICommand _command;
    public ButtonInvoker(ICommand command)
    {
        _command = command;
    }

    public void ClickInvoke()
    {
        _command.Execute();
    }
}