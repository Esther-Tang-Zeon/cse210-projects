public class Customer 
{
    public string _customerName { get; private set; }
    public Address _address { get; private set; }

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool CustomerIsInUSA()
    {
        return _address.AddressIsInUSA();
    }


}