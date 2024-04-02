public class Activity {
    protected DateOnly _date;
    protected int _duration;

    public Activity(DateOnly date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance() {
        return 0;
    }

    public virtual double GetSpeed() {
        return 0;
    }

    public virtual double GetPace() {
        return 0;
    }

    public void GetSummary() {
        Console.WriteLine($"{_date} {GetType().Name} ({_duration} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}