public class Product
{
    public string _productName { get; private set; }
    public string _productID { get; private set; }
    public decimal _pricePerUnit { get; private set; }
    public int _quantity { get; private set; }

    public Product(string productName, string productID, decimal pricePerUnit, int quantity) 
    {
        _productName = productName;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public decimal CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

}