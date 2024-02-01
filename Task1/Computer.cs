public class Computer
{
    private int _ram;
    private int _storage;
    private string _keyBoard;
    public Computer(int ram,int storage,string keyboard)
    {
        _ram = ram;
        _keyBoard = keyboard;
        _storage = storage;
    }
    public void AddRum(int ram)
    {
        _ram += ram;
    }
    public void AddStorage(int storage)
    {
        _storage += storage;
    }
    public int GetRam()
    {
        return _ram;
    }
    public int GetStorage()
    {
        return _storage;
    }
    public string GetKyboard()
    {
        return _keyBoard;
    }
    
}