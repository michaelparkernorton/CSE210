public class Order {
	public List<StoreProduct> _storeProducts;
	public Customer _customer;

	public Order(List<StoreProduct> storeProducts, Customer customer)
	{
		_storeProducts = storeProducts;
		_customer = customer;
	}

	public void GetOrder() {}

	public void CreatePackingLabel() {}
	public void CreateShippingLabel() {}

	public double CalcTotalCost () {
		double total = 0;
		foreach (var storeProduct in _storeProducts)
		{
			total += storeProduct.CalcTotalCost();	
		}
		return total;
	}

	public double CalcShipping() {
		return 0;
	}
}