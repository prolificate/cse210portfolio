using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "12 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Product product1 = new Product(
            "Laptop",
            "P100",
            1200,
            1
        );

        Product product2 = new Product(
            "Mouse",
            "P200",
            25,
            2
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address(
            "45 Allen Avenue",
            "Lagos",
            "Abuja",
            "Nigeria"
        );

        Customer customer2 = new Customer(
            "Eniola",
            address2
        );

        Product product3 = new Product(
            "Phone",
            "P300",
            800,
            1
        );

        Product product4 = new Product(
            "Headphones",
            "P400",
            100,
            2
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}