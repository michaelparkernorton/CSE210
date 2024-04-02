public class OutdoorGathering : Event {
    private string _forecast;

    public OutdoorGathering(string title, string description, DateOnly date, TimeOnly time, Address address, string forecast) : base(title, description, date, time, address)
    {
        _forecast = forecast;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"Weather Forecast: {_forecast}");
    }
}