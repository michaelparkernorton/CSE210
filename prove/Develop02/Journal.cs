using System.Text.Json;
// https://www.youtube.com/watch?v=w6M-Bj-tfv4
public class Journal
{
	public List<Entry> Entries = new List<Entry>();
	public string _fileName = "";

	public void Display()
	{
		foreach (Entry entry in Entries)
		{
			entry.Display();
		}
	}
	public void AddEntry(Entry entry)
	{
		this.Entries.Add(entry);
	}

	public void Load()
	{
		var journalJson = File.ReadAllText("test.json");
		this.Entries = JsonSerializer.Deserialize<List<Entry>>(journalJson);
	}

	public void Save()
	{
		var options = new JsonSerializerOptions();
		options.WriteIndented = true;
    string jsonString = JsonSerializer.Serialize<List<Entry>>(this.Entries, options);
    Console.WriteLine(jsonString);

		Console.WriteLine("What is the filename?");
    this._fileName = Console.ReadLine();

		File.WriteAllText(this._fileName, jsonString);
	}
}