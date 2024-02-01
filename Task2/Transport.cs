public class Transport
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }
    public Transport(){}
    public Transport(string model,string color,int year)
    {
        Year = year;
        Color = color;
        Model = model;
    }
    public void SetModel(string model)
    {
        Model = model;
    }
    public void SetColor(string color)
    {
        Color = color;
    }
    public void SetYear(int year)
    {
        Year = year;
    }
    public virtual string ToString()
    {
        return $"Transport: Model: {Model} Color: {Color} Year: {Year}";
    }
}