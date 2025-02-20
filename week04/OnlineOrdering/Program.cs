using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "P1001", 1000, 2);
        Product product2 = new Product("Mouse", "P1002", 50, 3);
        Product product3 = new Product("Keyboard", "P1003", 80, 1);
        Product product4 = new Product("Monitor", "P1004", 300, 1);
        
        Customer customer1 = new Customer("Nehpi", new Address("123 Main St", "Bountiful", "UT", "USA"));
        Customer customer2 = new Customer("Lehi", new Address("456 Elm St", "Toronto", "ON", "Canada"));
        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine();
        
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
}