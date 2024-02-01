public class SmartPhone : Computer
{
    private int _weight;
    private int _selfies;
    public SmartPhone(int ram,int storage,string keyboard,int weight,int selfies):base(ram,storage,keyboard)
    {
        _weight = weight;
        _selfies = selfies;
    }
   
    public void Selfies()
    {
        _selfies ++;
    }
    public string GetFullInfo()
    {
        return $"Opertivkai telephoni shumo {GetRam()}gb ast.Pamyatash {GetStorage()} buda, klaviaturaash bo zaboni {GetKyboard()} ast.";
    }
    public void WeightCheck()
    {
        System.Console.WriteLine($"Vazni telephoni shumo {_weight}gr ast va az telephoni shumo {_selfies} bor selfi giriftaand");
    }
}