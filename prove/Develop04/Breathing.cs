public class Breathing : Activity
{
	private int _repetitions;
	private int _remainingSeconds;
	private string[] _breathingModes = {"Breath in...", "Hold...", "Now breath out..."};
	public Breathing() : base() {
		_name = "Breathing";
		_description = "This activity will help you relax by walking you through breathing in and out slowly. It will help you clear your mind and focus on your breathing.";
	}

	public void BreathingExercise (int mode) {
		Display(_breathingModes[mode]);
		CountDown(5);
	}

	public void NormalBreathing (int count) {
		Display("Now breath normally...");
		CountDown(count);
	}

	public override void RunActivity() {
		_remainingSeconds = _duration % 5;
		_repetitions = (_duration - _remainingSeconds) / 5;

		Display("Get ready...");
		NewLine();
		Spinner();
		Break();
		for (var i = 0; i < _repetitions; i++)
		{
			BreathingExercise(i % 3);
			NewLine();
			if (i % 3 == 2) {
				NewLine();
			}
		}
		if (_remainingSeconds > 0) {
			NormalBreathing(_remainingSeconds);
		}
	}

}