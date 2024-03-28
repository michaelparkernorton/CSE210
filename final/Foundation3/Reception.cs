
public class Reception : Event {
	private List<string> _registeredGuests;

	public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, List<string> registeredGuests) : base(title, description, date, time, address)
	{
		_registeredGuests = registeredGuests;
	}

	public override void FullDetails () {}

}