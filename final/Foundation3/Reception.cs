public class Reception : Event {
    private string _email;

    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"Email us to RSVP: {_email}");
    }
}