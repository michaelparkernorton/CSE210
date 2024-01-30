using System.Text.Json;
// https://www.youtube.com/watch?v=w6M-Bj-tfv4
public class Journal
{
	public List<Entry> _entries = new List<Entry>();
	public string _fileName = "";

	public void Display()
	{
		foreach (Entry entry in _entries)
		{
			entry.Display();
		}
	}
	public void Write(PromptGenerator promptGenerator)
	{
		Entry entry = new Entry();
		entry._date = DateTime.Now;
		entry._prompt = promptGenerator.RandomPrompt();
		Console.WriteLine(entry._prompt);
		Console.Write("> ");
		entry._response = Console.ReadLine();
		this._entries.Add(entry);
	}

	public void Load()
	{
		Console.WriteLine("What is the filename?");
    this._fileName = Console.ReadLine();
		var journalJson = File.ReadAllText(this._fileName);
		this._entries = JsonSerializer.Deserialize<List<Entry>>(journalJson);
	}

	public void Save()
	{
		var options = new JsonSerializerOptions();
		options.WriteIndented = true;
		string jsonString = JsonSerializer.Serialize<List<Entry>>(this._entries, options);
		Console.WriteLine("What is the filename?");
		this._fileName = Console.ReadLine();
		File.WriteAllText(this._fileName, jsonString);
	}
}