public class Swimming : Activity {
    private int _laps;

    public Swimming(DateOnly date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() {
        return _laps * 50 / 1000 * 0.62; // miles
    }

    public override double GetSpeed() {
        return (GetDistance()) / (_duration) * 60; // mph
    }

    public override double GetPace() {
        return (60.0) / GetSpeed(); // minutes per mile
    }
}