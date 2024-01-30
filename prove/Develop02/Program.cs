using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


    // Exceeding the requirements
    // This project exceeds the requirements by updating the save/load features to
    // save files in json format and to load them as well using the JsonSerialier

class Program
{
    static void Main(string[] args)
    {
        // Create prompt list and journal objects
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.LoadPrompts();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!:");
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
                    // Write
                    journal.Write(promptGenerator);
                    break;
                case 2:
                    // Display
                    journal.Display();
                    break;
                case 3:
                    // Load
                    journal.Load();
                    break;
                case 4:
                    // Save
                    journal.Save();
                    break;
                case 5:
                    // Exit
                    running = false;
                    break;
                default:
                    // code block
                    break;
            }
        }
    }
}