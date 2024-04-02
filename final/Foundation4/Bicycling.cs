public class Bicycling : Activity {
    private int _speed;

    public Bicycling(DateOnly date, int duration, int speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed() {
        return _speed;
    }
}