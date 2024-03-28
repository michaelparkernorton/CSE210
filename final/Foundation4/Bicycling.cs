public class Bicycling : Activity {
	
	private int _speed;

	public Bicycling(DateOnly date, int duration, int speed) : base(date, duration)
	{
		_speed = speed;
	}

	public override void GetDistance() {}
	public override void GetSpeed() {}
	public override void GetPace() {}
}