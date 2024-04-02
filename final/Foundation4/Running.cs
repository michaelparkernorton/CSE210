public class Running : Activity {
    private int _distance;

    public Running(DateOnly date, int duration, int distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() {
        return _distance;
    }

    public override double GetSpeed() {
        return _distance / (_duration / 60.0); // mph
    }

    public override double GetPace() {
        return (_duration / 60.0) / _distance; // minutes per mile
    }
}