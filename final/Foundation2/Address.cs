public class Address
{
    public string _streetAddress { get; private set; }
    public string _city { get; private set; }
    public string _state { get; private set; }
    public string _country { get; private set; }

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool AddressIsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}