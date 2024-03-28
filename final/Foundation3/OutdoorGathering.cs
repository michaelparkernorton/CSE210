
public class OutdoorGathering : Event {
	private string _forecast;

	public OutdoorGathering(string title, string description, DateOnly date, TimeOnly time, Address address, string forecast) : base(title, description, date, time, address)
	{
		_forecast = forecast;
	}

	public override void FullDetails () {}

}