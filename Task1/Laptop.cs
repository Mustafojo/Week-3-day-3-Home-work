public class Laptop : Computer
{
    private int _weight;
    public Laptop(int ram,int storage,string keyboard,int weight):base(ram,storage,keyboard)
    {
        _weight = weight;
    }
    public void WeightCheck()
    {
        System.Console.WriteLine($"Vazni komputeri shumo {_weight}kg ast ");
    }
    public string GetFullInfo()
    {
        return $"Opertivkai laptopi shumo {GetRam()}gb ast.Pamyatash {GetStorage()} buda, klaviaturaash bo zaboni {GetKyboard()} ast.";
    }
}