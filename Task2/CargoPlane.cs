
public class CargoPlane : Aiplane
{
    public double Bor { get; set; }
    public CargoPlane(){}
    public CargoPlane(string name,int speed,string country,double bor)
    {
        Bor = bor;  
    }
    public void SetBor(double bor)
    {
        Bor = bor;
    }
    public string ToString()
    {
        return $"{base.ToString()} Bor: {Bor}";
    }
}