public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;

    public int TargetCount 
    { 
        get { return _targetCount; } 
        set { _targetCount = value; } 
    }

    public int CompletedCount 
    { 
        get { return _completedCount; } 
        set { _completedCount = value; } 
    }

    public ChecklistGoal(string name, int points, string description, int targetCount) : base(name, points, description)
    {
        _targetCount = targetCount;
    }

    public override void MarkComplete()
    {
        _completedCount++;
        if (_completedCount >= _targetCount)
        {
            _isComplete = true;
        }
    }
}