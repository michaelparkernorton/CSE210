public class Activity {
	private DateOnly _date;
	private int _duration;

	public Activity(DateOnly date, int duration)
	{
		_date = date;
		_duration = duration;
	}

	public virtual void GetDistance() {}
	public virtual void GetSpeed() {}
	public virtual void GetPace() {}
	public void GetSummary(){}
}