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
        return GetPace() / 60;
    }

    public virtual double GetPace() {
        return 60 / GetSpeed();
    }

    public void GetSummary() {
        Console.WriteLine($"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_duration} min) - Distance: {Math.Round(GetDistance(), 2)} miles, Speed: {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile");
    }
}