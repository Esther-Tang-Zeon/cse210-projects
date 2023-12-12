// Derived class for Outdoor Gathering events
public class OutdoorGathering : Event
{
    // Weather Attributes to Outdoor Gathering
    public string _weather { get; private set; }

    // Constructor for Outdoor Gathering
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    // Overriding method to include outdoor gathering-specific details
    public override string GetFullDetails()
    {
        return $"Type: Outdoor Gathering, {base.GetFullDetails()}, Weather Forecast: {_weather}";
    }
}