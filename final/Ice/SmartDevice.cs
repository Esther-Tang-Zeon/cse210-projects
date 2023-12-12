public class SmartDevice
{
    public string _name { get; set; }
    public bool _isOn { get; private set; }

    public SmartDevice(string name)
    {
        _name = name;
    }

    public void TurnOn()
    {
        _isOn = true;
        Console.WriteLine($"{_name} turned on.");
    }

    public void TurnOff()
    {
        _isOn = false;
        Console.WriteLine($"{_name} turned off.");
    }
}