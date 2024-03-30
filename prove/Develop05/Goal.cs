public class Goal
{
    private string _name;
    private int _points;
    protected bool _isComplete;
    private string _description;

    public string Name 
    { 
        get { return _name; } 
        set { _name = value; } 
    }

    public int Points 
    { 
        get { return _points; } 
        set { _points = value; } 
    }

    public bool IsComplete 
    { 
        get { return _isComplete; } 
        set { _isComplete = value; } 
    }

    public string Description 
    { 
        get { return _description; } 
        set { _description = value; } 
    }

    public Goal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description = description;
    }

    public virtual void MarkComplete()
    {
        _isComplete = true;
    }
}