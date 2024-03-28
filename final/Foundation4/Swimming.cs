public class Swimming : Activity {
	
	private int _laps;

	public Swimming(DateOnly date, int duration, int laps) : base(date, duration)
	{
		_laps = laps;
	}

	public override void GetDistance() {}
	public override void GetSpeed() {}
	public override void GetPace() {}
}