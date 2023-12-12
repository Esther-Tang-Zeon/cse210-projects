// Derived class for Lecture type events
public class Lecture : Event
{
    // Attributes for a Lecture
    public string _speaker { get; private set; }
    public int _capacity { get; private set; }

    // Constructor for Lecture
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Overriding method to include lecture-specific details
    public override string GetFullDetails()
    {
        return $"Type: Lecture, {base.GetFullDetails()}, Speaker: {_speaker}, Capacity: {_capacity}";
    }
}