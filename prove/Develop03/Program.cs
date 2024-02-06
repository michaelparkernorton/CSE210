using System;
using System.Text.Json;
using System.Text.Json.Serialization;


class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, scriptureText);
        Console.Clear();
        scripture.DisplayScripture();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string quit = "";
        quit = Console.ReadLine();
        bool running = true;
        if (quit == "quit")
        {
            running = false;
        }
        while (running) {
            Console.Clear();
            scripture.HideWords();
            scripture.DisplayScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            quit = Console.ReadLine();
            if (scripture.IsHidden() || quit == "quit")
            {
                running = false;
            }
        };
    }
}