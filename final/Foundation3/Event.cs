using System;

public class Event {
    protected string _title;
    protected string _description;
    protected DateOnly _date;
    protected TimeOnly _time;
    protected Address _address;

    public Event(string title, string description, DateOnly date, TimeOnly time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual void FullDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public void StandardDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Type: {GetType().Name}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}
