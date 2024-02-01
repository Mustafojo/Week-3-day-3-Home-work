
public class Aiplane : Transport
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public string Country { get; set; }
    public Aiplane(){}
    public Aiplane(string model,string color,int year,string name,int speed,string country)
    :base(model, color,year)
    {
        Name = name;
        Speed = speed;
        Country = country;
       
    }
    public void SetName(string name)
    {
        Name = name;
    }
    public void SetSpeed(int speed)
    {
        Speed = speed;
    }
    public void SetCountry(string country)
    {
        Country = country;
    }
    public string ToString()
    {
        return $"{base.ToString()} Name: {Name} Speed: {Speed} Country: {Country}";
    }
}