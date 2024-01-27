using System.Text.Json;

public class Purchase
{
    public string? ProductName { get; set; }
    public DateTime DateTime { get; set; }
    public decimal ProductPrice { get; set; }

    public void saveFile()
    {
        string jsonString = JsonSerializer.Serialize(this);
        File.WriteAllText("purchase.json", jsonString);
    }
}