using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "TECH001", 850.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "TECH002", 25.50, 2));


        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Desk Chair", "FURN100", 150.00, 1));
        order2.AddProduct(new Product("Mechanical Keyboard", "TECH003", 89.99, 1));
        order2.AddProduct(new Product("HDMI Cable", "ELEC010", 12.00, 3));


        Console.WriteLine("========================================");
        Console.WriteLine("               ORDER 1                  ");
        Console.WriteLine("========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine("========================================");
        Console.WriteLine("               ORDER 2                  ");
        Console.WriteLine("========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():0.00}\n");
    }
}