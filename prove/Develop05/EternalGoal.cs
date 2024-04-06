public class EternalGoal : Goal
{
    private int repetitions;
    public EternalGoal(string name, int points, string description) : base(name, points, description)
    {
        repetitions = 0;
    }

    public override void MarkComplete()
    {
        // Eternal goal remains incomplete after progress recording
        repetitions++;
    }
}