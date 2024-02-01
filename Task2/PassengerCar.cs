public class PassengerCar : Car
{
    public int Passenger { get; set; }
    public PassengerCar(){}
    public PassengerCar(string name,int speed,int passenger,int door)    
    {
        Passenger = passenger;
    }
    public void SetPassenger(int passenger)
    {
        Passenger = passenger;
    }
    public string ToString()
    {
        return $"{base.ToString()}  Passenger: {Passenger}";
    }
}