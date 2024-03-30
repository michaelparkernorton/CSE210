using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        // Create a new user
        User user = new User("John");

        // Load goals from file
        LoadGoals(user);

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
                    CreateGoal(user);
                    break;
                case "2":
                    ListGoals(user);
                    break;
                case "3":
                    SaveGoals(user);
                    break;
                case "4":
                    LoadGoals(user);
                    break;
                case "5":
                    RecordEvent(user);
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

    static void CreateGoal(User user)
    {
        Console.Write("Enter goal type (1. Simple, 2. Eternal, 3. Checklist): ");
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter number of points for the goal: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points value. Please enter a valid integer.");
            return;
        }

        Goal goal;
            switch (type)
            {
                case "1":
                    goal = new SimpleGoal(name, points, description);
                    break;
                case "2":
                    goal = new EternalGoal(name, points, description);
                    break;
                case "3":
                    Console.Write("Enter target count for the checklist goal: ");
                    if (!int.TryParse(Console.ReadLine(), out int targetCount))
                    {
                        Console.WriteLine("Invalid target count. Please enter a valid integer.");
                        return;
                    }
                    goal = new ChecklistGoal(name, points, description, targetCount);
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }


        user.AddGoal(goal);
        Console.WriteLine("Goal created successfully.");
    }

    static void ListGoals(User user)
    {
        Console.WriteLine("\nUser's Goals:");
        for (int i = 0; i < user.Goals.Count; i++)
        {
            Goal goal = user.Goals[i];
            Console.WriteLine($"{i+1}: {goal.Name} ({goal.Description}) Complete: {goal.IsComplete}");
        }
    }

    static void SaveGoals(User user)
    {
        try
        {
            string json = JsonSerializer.Serialize(user.Goals);
            File.WriteAllText("goals.json", json);
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    static void LoadGoals(User user)
    {
        try
        {
            if (File.Exists("goals.dat"))
            {
                string json = File.ReadAllText("goals.dat");
                user.Goals = JsonSerializer.Deserialize<List<Goal>>(json);
                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    static void RecordEvent(User user)
    {
        Console.WriteLine("Select a goal to record an event for:");
        for (int i = 0; i < user.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {user.Goals[i].Name}");
        }

        Console.Write("Enter goal number: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= user.Goals.Count)
        {
            user.RecordProgress(user.Goals[index - 1]);
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}
