namespace ConsoleApp1.State;

public class MakeSound   // Context
{
    private readonly IAnimal _animal;

    public MakeSound(IAnimal animal)
    {
        _animal = animal;
    }

    public void Speak()
    {
        _animal.Talk();
    }


}