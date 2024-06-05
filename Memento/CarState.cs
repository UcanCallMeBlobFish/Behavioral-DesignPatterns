namespace ConsoleApp1.Memento;

public class CarState // Memento
{
    
    public string Id { get; set; }
    public string Model { get; set; }
    public int MaxSpeed { get; set; }
    
    public CarState(string _Id, string _Model, int _maxSpeed)
    {
        Id = _Id;
        Model = _Model;
        MaxSpeed = _maxSpeed;
    }

}