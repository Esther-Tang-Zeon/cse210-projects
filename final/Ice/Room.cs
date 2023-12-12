public class Room
{
    public string _name { get; set; }
    public List<SmartDevice> _devices { get; private set; } = new List<SmartDevice>();

    public Room(string name)
    {
        _name = name;
    }

    public void AddDevice(SmartDevice device)
    {
        _devices.Add(device);
    }

    public void TurnOffAllDevices()
    {
        foreach (var device in _devices)
        {
            device.TurnOff();
        }
    }

    public void TurnOnAllDevices()
    {
        foreach (var device in _devices)
        {
            device.TurnOn();
        }
    }

    public void ReportAllDevicesStatus()
    {
        foreach (var device in _devices)
        {
            Console.WriteLine($"{device.Name} is {(device.IsOn ? "on" : "off")}.");
        }
    }
}