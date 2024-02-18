using System;
using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        var scriptureJson = File.ReadAllText("scripture.json");
        Scripture scripture = JsonSerializer.Deserialize<Scripture>(scriptureJson);
    }
}