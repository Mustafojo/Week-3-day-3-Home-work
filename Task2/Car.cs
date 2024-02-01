
public class Car : Transport
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public int Door { get; set; }

    public Car(){}
    public Car(string model,string color,int year,string name,int speed,int door)
    :base(model, color,year)
    {
        Name = name;
        Speed = speed;
        Door = door;
    }
    public void SetName(string name)
    {
        Name = name;
    }
    public void SetSpeed(int speed)
    {
        Speed = speed;
    }
    public string ToString()
    {
        return $"{base.ToString()} Name: {Name} Speed: {Speed} Door: {Door}";
    }
}