using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Stretch created a Library class to load additional scriptures from
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Library l = new Library();
        Scripture scripture = l.GetScripture();
        // string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // Scripture scripture = new Scripture(reference, scriptureText);
        string quit = "";
        bool running = true;
        do {
            scripture.DisplayScripture();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            quit = Console.ReadLine();
            if (quit == "quit" || scripture.IsHidden())
            {
                running = false;;
            }
            else
            {
                Console.Clear();
                scripture.HideWords();
            }
        } while (running);
    }
}