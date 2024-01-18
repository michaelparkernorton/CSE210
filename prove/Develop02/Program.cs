using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
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
                    entry._date = DateTime.Now;
                    entry._prompt = "If I had one thing I could do over today, what would it be?";
                    Console.WriteLine(entry._prompt);
                    Console.Write("> ");
                    entry._response = Console.ReadLine();
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
                default:
                    // code block
                    break;
            }

            Console.WriteLine("");
        }

    }
}