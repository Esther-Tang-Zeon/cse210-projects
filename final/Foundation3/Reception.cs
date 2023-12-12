// Derived class for Reception type events
public class Reception : Event
{
        // Attributes to Reception
    public string _registerRSVP { get; private set; }

    public Reception(string title, string description, DateTime date, string time, Address address, string registerRSVP)
        : base(title, description, date, time, address)
    {
        _registerRSVP = registerRSVP;
    }

    // Overriding method to include reception-specific details
    public override string GetFullDetails()
    {
        return $"Type: Reception, {base.GetFullDetails()}, RSVP at: {_registerRSVP}";
    }
}