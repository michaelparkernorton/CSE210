public class Running : Activity {
	
	private int _distance;

	public Running(DateOnly date, int duration, int distance) : base(date, duration)
	{
		_distance = distance;
	}

	public override void GetDistance() {}
	public override void GetSpeed() {}
	public override void GetPace() {}
}