public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    
    public void Display()
    {
        Console.WriteLine($"Date: {Date:d} - Prompt: {Prompt}");
        Console.WriteLine($"{Response}");
        Console.WriteLine("");
    }
}