class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------\n");

        Console.WriteLine("Welcome to the Product Ordering System!");

        Console.WriteLine("\n---------------------------------------\n");

        // Define orders
        List<Order> orders = new List<Order>();

        // Create products for order 1
        Product product1 = new Product("Laptop", 1001, 1200, 1);
        Product product2 = new Product("Mouse", 1002, 20, 2);

        // Create address for customer 1
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");

        // Create customer 1
        Customer customer1 = new Customer("John Doe", address1);

        // Create order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        orders.Add(order1);

        // Create products for order 2
        Product product3 = new Product("Keyboard", 1003, 50, 1);
        Product product4 = new Product("Monitor", 1004, 300, 1);

        // Create address for customer 2 (from Brazil)
        Address address2 = new Address("789 Copacabana Ave", "Rio de Janeiro", "RJ", "Brazil");

        // Create customer 2
        Customer customer2 = new Customer("Maria da Silva", address2);

        // Create order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        orders.Add(order2);

        // Process orders
        foreach (var order in orders)
        {
            Console.WriteLine("\n---------------------------------------\n");

            // Loading spinner animation
            order.DisplayLoadingOrderNotification();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }

            Console.WriteLine();
            Console.WriteLine("\n---------------------------------------\n");

            // Display order information
            order.DisplayOrderInformation();

            // Divider between orders
            Console.WriteLine("\n---------------------------------------\n");
        }
    }
}
