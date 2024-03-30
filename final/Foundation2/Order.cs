using System.Text;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = _customer.IsUSACustomer() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GeneratePackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in _products)
        {
            label.Append($"{product.GetName()} (ID: {product.GetProductId()})\n");
        }
        return label.ToString();
    }

    public string GenerateShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

		
    public void DisplayLoadingOrderNotification()
    {
        Console.Write($"Loading order for {_customer.GetName()} ");
    }

		public void DisplayOrderInformation()
    {
        Console.WriteLine($"Order for {_customer.GetName()}:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(GeneratePackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(GenerateShippingLabel());
        Console.WriteLine("\nTotal Price:");
        Console.WriteLine("$" + CalculateTotalCost());
    }
}