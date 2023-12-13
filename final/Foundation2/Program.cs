using System;

namespace Foundation2
{

    class Program
    {
        static void Main(string[] args)
        {
            Address usaAddress = new Address("123 Main St", "Idaho", "ID", "USA");
            Customer usCustomer = new Customer("Jack Jones", usaAddress);

            Address intlAddress = new Address("456 World Ave", "Spain", "ESP", "EU");
            Customer intlCustomer = new Customer("Amy Smith", intlAddress);

            Product product1 = new Product("Product A", 1, 10.0m, 2);
            Product product2 = new Product("Product B", 2, 15.0m, 3);

            Order order1 = new Order(usCustomer);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(intlCustomer);
            order2.AddProduct(product1);

            // Displaying information for order 1
            Console.WriteLine("Order 1 - Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());

            Console.WriteLine("\nOrder 1 - Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine("\nOrder 1 - Total Cost:");
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

            // Displaying information for order 2
            Console.WriteLine("\nOrder 2 - Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());

            Console.WriteLine("\nOrder 2 - Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());

            Console.WriteLine("\nOrder 2 - Total Cost:");
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
        }
    }
}