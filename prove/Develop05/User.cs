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
}