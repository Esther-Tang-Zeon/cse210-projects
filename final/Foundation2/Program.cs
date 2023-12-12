using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address instances
        Address addressUSA = new Address("667 S 2nd E", "Rexburg", "ID", "USA");
        Address addressNonUSA = new Address("34 Laluan Lapangan Perdana 3", "Ipoh", "Perak", "Malaysia");

        // Create Customer instances
        Customer customerUSA = new Customer("Taylor Swift", addressUSA);
        Customer customerNonUSA = new Customer("Esther Tang", addressNonUSA);

        // Create Order instances
        Order order1 = new Order(customerUSA);
        order1.AddProduct(new Product("Piano", "ID444", 444.00m, 1));
        order1.AddProduct(new Product("Violin", "ID666", 666.00m, 2));

        Order order2 = new Order(customerNonUSA);
        order2.AddProduct(new Product("Cello", "ID777", 77.00m, 3));
        order2.AddProduct(new Product("Viola", "ID888", 888.00m, 4));

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost()}");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost()}");
    }
}
