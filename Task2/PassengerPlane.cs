
public class PassengerPlane : Aiplane
{
    public int Passenger { get; set; }
    public PassengerPlane(){}
    public PassengerPlane(string name,int speed,string country,int passenger)
    {
        Passenger = passenger;  
    }
    public void SetBor(int passenger)
    {
        Passenger = passenger;  
    }
    public string ToString()
    {
        return $"{base.ToString()} Passenger: {Passenger}";
    }
}