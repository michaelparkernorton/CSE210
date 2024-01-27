using System.Text.Json;

public class Order
{
    public List<Purchase> Purchases = new List<Purchase>();

    public void saveFile()
    {
        string jsonString = JsonSerializer.Serialize(this);
        File.WriteAllText("purchase.json", jsonString);
    }
}