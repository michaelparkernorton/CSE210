public class EternalGoal : Goal
{
    public EternalGoal(string name, int points, string description) : base(name, points, description)
    {
    }

    public override void MarkComplete()
    {
        // Eternal goal remains incomplete after progress recording
    }
}