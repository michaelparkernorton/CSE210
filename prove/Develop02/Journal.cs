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
		Console.WriteLine("What is the filename?");
		this._fileName = Console.ReadLine();
		this.Entries = new List<Entry>();
		string[] lines = System.IO.File.ReadAllLines(this._fileName);
		int count = 0;
		for (int i = 0; i < lines.Length; i++)
		{
			if (i % 3 == 0)
			{
				Entry entry = new Entry();
				string[] parts = lines[i].Split(":");
				string[] date = parts[1].Split(" ");
				entry.Date = Convert.ToDateTime(date[1]);
				entry.Prompt = parts[2];
				this.Entries.Add(entry);
			}
			if ((i - 1) % 3 == 0)
			{
				this.Entries[count].Response = lines[i];
				count++;
			}
		}
	}
	// public void LoadJson()
	// {
	// 	Console.WriteLine("What is the filename?");
	// 	this._fileName = Console.ReadLine();
	// 	this.Entries = new List<Entry>();
	// 	string[] lines = System.IO.File.ReadAllLines(this._fileName);
	// 	int count = 0;
	// 	for (int i = 0; i < lines.Length; i++)
	// 	{
	// 		if (i % 3 == 0)
	// 		{
	// 			Entry entry = new Entry();
	// 			string[] parts = lines[i].Split(":");
	// 			string[] date = parts[1].Split(" ");
	// 			entry.Date = Convert.ToDateTime(date[1]);
	// 			entry.Prompt = parts[2];
	// 			this.Entries.Add(entry);
	// 		}
	// 		if ((i - 1) % 3 == 0)
	// 		{
	// 			this.Entries[count].Response = lines[i];
	// 			count++;
	// 		}
	// 	}
	// }

	// public void LoadJson()
  //   {
  //       using (StreamReader r = new StreamReader("file.json"))
  //       {
  //           string json = r.ReadToEnd();
  //           this.Entries = JsonConvert.DeserializeObject<List<Entry>>(json);
  //       }
  //   }

	public void Save()
	{
		Console.WriteLine("What is the filename?");
		this._fileName = Console.ReadLine();

		using (StreamWriter outputFile = new StreamWriter(this._fileName))
		{
			foreach (Entry entry in Entries)
			{
				outputFile.WriteLine($"Date: {entry.Date:d} - Prompt: {entry.Prompt}");
				outputFile.WriteLine($"{entry.Response}");
				outputFile.WriteLine("");
			}
		}
	}
	public void SaveJson()
	{
		Console.WriteLine("What is the filename?");
		this._fileName = Console.ReadLine();
		int count = 1;

		using (StreamWriter outputFile = new StreamWriter(this._fileName))
		{
			outputFile.WriteLine("[");
			foreach (Entry entry in Entries)
			{
				outputFile.WriteLine("\t{");
				outputFile.WriteLine($"\t\t\"date\": \"{entry.Date:d}\",");
				// the prompts for some reason have an extra space
				outputFile.WriteLine($"\t\t\"prompt\": \"{entry.Prompt}\",");
				outputFile.WriteLine($"\t\t\"response\": \"{entry.Response}\"");
				outputFile.WriteLine("\t}");
				if (count != Entries.Count()) {
					outputFile.WriteLine(",");
				}
				count++;
			}
			outputFile.WriteLine("]");
		}
	}
	public void SaveJson2()
	{
    string jsonString = JsonSerializer.Serialize(this.Entries);
    Console.WriteLine(jsonString);

		Console.WriteLine("What is the filename?");
    this._fileName = Console.ReadLine();

		File.WriteAllText(this._fileName, jsonString);
	}
}