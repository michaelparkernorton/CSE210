using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


// Exceeding the requirements
// catch errors if the user types a filename that is not found during loading
// save / load as JSON files
// csv file

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.LoadPrompts();
        Console.WriteLine("Welcome to the Journal Program!:");


        Entry entry1 = new Entry
        {
			Date = DateTime.UtcNow,
			Prompt = "This is a test",
			Response = "This is a test",
		};
        Entry entry2 = new Entry
        {
			Date = DateTime.UtcNow,
			Prompt = "This is a test2",
			Response = "This is a test2",
		};

        Journal journal = new Journal();
        journal.Entries.Add(entry1);
        journal.Entries.Add(entry2);
        // string jsonString = JsonSerializer.Serialize(journal.Entries);



        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // code block
                    Entry entry = new Entry();
                    entry.Date = DateTime.Now;
                    entry.Prompt = promptGenerator.RandomPrompt();
                    Console.WriteLine(entry.Prompt);
                    Console.Write("> ");
                    entry.Response = Console.ReadLine();
                    journal.AddEntry(entry);
                    break;
                case 2:
                    // code block
                    journal.Display();
                    break;
                case 3:
                    // code block
                    journal.Load();
                    break;
                case 4:
                    // code block
                    journal.Save();
                    break;
                case 5:
                    // code block
                    running = false;
                    break;
                case 6:
                    // code block
                    journal.SaveJson();
                    break;
                case 7:
                    // code block
                    journal.SaveJson2();
                    
                    break;
                default:
                    // code block
                    break;
            }

            Console.WriteLine("");
        }

    }
}