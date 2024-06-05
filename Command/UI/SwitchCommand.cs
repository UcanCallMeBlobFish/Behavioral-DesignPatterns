using ConsoleApp1.Command.FR;

namespace ConsoleApp1.Command.UI;

public class SwitchCommand : ICommand
{
    private readonly CustomerReciever _command;
    public SwitchCommand(CustomerReciever command)
    {
        _command = command;
    }
    public void Execute()
    {
        _command.turnoff();
    }
}