public class Entry
{
    public DateTime _date;
    public string _prompt;
    public string _response;
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date:d} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine("");
    }
}