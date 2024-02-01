public class CargoCar : Car
{
    public int Passenger { get; set; }
    public double Weight { get; set; }
    public CargoCar(){}
    public CargoCar(string name,int speed,int door,int passenger,double weight)
    {
        Passenger = passenger;
        Weight = Weight;
    }
    public void SetPassenger(int passenger)
    {
        Passenger = passenger;
    }
     public void SetWeight(double weight)
    {
        Weight = weight;
    }
    public string ToString()
    {
        return $"{base.ToString()} Passenger: {Passenger} Weight: {Weight}";
    }
}