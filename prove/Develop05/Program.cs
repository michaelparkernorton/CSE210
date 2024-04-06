using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


class Program
{
    static void Main(string[] args)
    {
        // Create a new user
        User user = new User("Mike");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    user.CreateGoal();
                    break;
                case "2":
                    user.ListGoals();
                    break;
                case "3":
                    user.SaveGoals();
                    break;
                case "4":
                    user.LoadGoals();
                    break;
                case "5":
                    user.RecordEvent();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    
}
