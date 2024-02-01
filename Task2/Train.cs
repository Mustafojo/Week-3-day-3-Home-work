
public class Train : Transport
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public int Passenger { get; set; }
    public Train(){}
    public Train(string model,string color,int year,string name,int speed,int passenger)
    :base(model, color,year)
    {
        Name = name;
        Speed = speed;
        Passenger = passenger;
    }
    public void SetName(string name)
    {
        Name = name;
    }
    public void SetSpeed(int speed)
    {
        Speed = speed;
    }
    public void SetPlace(int passenger)
    {
        Passenger = passenger;
    }
    public override string  ToString()
    {
        return $"{base.ToString()} Name: {Name} Speed: {Speed} Place: {Passenger}";
    }
}