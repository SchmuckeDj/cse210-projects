using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA customer
        Address address1 = new Address("123 Main St", "Miami", "FL", "USA");
        Customer customer1 = new Customer("Jose Diaz", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "K001", 25.99, 2));
        order1.AddProduct(new Product("Mouse", "M002", 15.50, 1));

        // Order 2 - International customer
        Address address2 = new Address("456 Central Ave", "Santo Domingo", "DN", "Dominican Republic");
        Customer customer2 = new Customer("Carlos Perez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "L003", 45.00, 1));
        order2.AddProduct(new Product("Webcam", "W004", 30.00, 2));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
