// Base class for all event types
public class Event
{
    // Attributes of any event
    public string _title { get; private set; }
    public string _description { get; private set; }
    public DateTime _date { get; private set; }
    public string _time { get; private set; }
    public Address _address { get; private set; }

    // Constructor to initialize an event
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}, Description: {_description}, Date: {_date.ToShortDateString()}, Time: {_time}, Address: {_address.GetFullAddress()}";
    }

    // Method to return full details about the event
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // Method to return short description about the event
    public string GetShortDescription()
    {
        return $"Event: {_title}, Date: {_date.ToShortDateString()}";
    }
}