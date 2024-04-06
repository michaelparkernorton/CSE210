using System.Text.Json;

public class User
{
    private string _name;
    private List<Goal> _goals;
    private int _totalPoints;

    public string Name 
    { 
        get { return _name; } 
        set { _name = value; } 
    }

    public List<Goal> Goals 
    { 
        get { return _goals; } 
        set { _goals = value; } 
    }

    public int TotalPoints 
    { 
        get { return _totalPoints; } 
        set { _totalPoints = value; } 
    }

    public User(string name)
    {
        Name = name;
        Goals = new List<Goal>();
        TotalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordProgress(Goal goal)
    {
        goal.MarkComplete();
        TotalPoints += goal.Points;
    }

    public void CreateGoal()
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


        this.AddGoal(goal);
        Console.WriteLine("Goal created successfully.");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nUser's Goals:");
        for (int i = 0; i < this.Goals.Count; i++)
        {
            Goal goal = this.Goals[i];
            Console.WriteLine($"{i+1}: {goal.Name} ({goal.Description}) Complete: {goal.IsComplete}");
        }
    }

    public void SaveGoals()
    {
        try
        {
            string json = JsonSerializer.Serialize(this.Goals);
            File.WriteAllText("goals.json", json);
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        try
        {
            if (File.Exists("goals.json"))
            {
                string json = File.ReadAllText("goals.json");
                this.Goals = JsonSerializer.Deserialize<List<Goal>>(json);
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

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event for:");
        for (int i = 0; i < this.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {this.Goals[i].Name}");
        }

        Console.Write("Enter goal number: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= this.Goals.Count)
        {
            this.RecordProgress(this.Goals[index - 1]);
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}