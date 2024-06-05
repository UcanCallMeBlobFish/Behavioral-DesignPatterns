namespace ConsoleApp1.Memento;

public class Car // originator
{
    //Fields
    public string Id { get; set; }
    public string Model { get; set; }
    public int MaxSpeed { get; set; }

    public Car(string _Id, string _Model, int _maxSpeed)
    {
        Id = _Id;
        Model = _Model;
        MaxSpeed = _maxSpeed;
    }



    //Functions

    public Car CreateState()
    {
        return new Car(Id, Model, MaxSpeed);
    }

    public void RestoreState(Car obj)
    {
        Id = obj.Id;
        Model = obj.Model;
        MaxSpeed = obj.MaxSpeed;
    }
    
}