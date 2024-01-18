public class Journal
{
	public List<Entry> _entries = new List<Entry>();
	public string fileName = "";

	public void Display()
	{
		foreach (Entry entry in _entries)
		{
			entry.Display();
		}
	}

	public void AddEntry(Entry entry)
	{
		this._entries.Add(entry);
	}

	public void Load()
	{
		Console.WriteLine("What is the filename?");
		this.fileName = Console.ReadLine();
		string[] lines = System.IO.File.ReadAllLines(this.fileName);


		int count = 0;
		for (int i = 0; i < lines.Length; i++)
		{
			if (i % 3 == 0)
			{
				Entry entry = new Entry();
				string[] parts = lines[i].Split(":");
				string[] date = parts[1].Split(" ");
				entry._date = Convert.ToDateTime(date[1]);
				entry._prompt = parts[2];
				this._entries.Add(entry);
			}
			if ((i - 1) % 3 == 0)
			{
				this._entries[count]._response = lines[i];
				count++;
			}
		}
	}

	public void Save()
	{
		Console.WriteLine("What is the filename?");
		this.fileName = Console.ReadLine();

		using (StreamWriter outputFile = new StreamWriter(this.fileName))
		{
			foreach (Entry entry in _entries)
			{
				outputFile.WriteLine($"Date: {entry._date:d} - Prompt: {entry._prompt}");
				outputFile.WriteLine($"{entry._response}");
				outputFile.WriteLine("");
			}
		}
	}
}