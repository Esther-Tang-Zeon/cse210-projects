public class Order 
{
    private List<Product> _products = new List<Product>();
    public Customer _customer { get; private set; }

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal _totalCost = 0;
        foreach (var product in _products)
        {
            _totalCost += product.CalculateTotalCost();
        }
        return _totalCost + (_customer.CustomerIsInUSA() ? 5m : 35m); // Shipping cost
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product._productName} - ID: {product._productID}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer._customerName}\n{_customer._address.GetFullAddress()}";
    }
}
