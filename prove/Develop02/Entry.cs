public class Entry
{
    public DateTime _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date:d} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine("");
    }
}