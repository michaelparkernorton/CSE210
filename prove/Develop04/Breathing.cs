public class Breathing : Activity
{
	private int _repetitions;
	private int _remainingSeconds;
	public Breathing() {
		_name = "Breathing";
		_description = "This activity will help you relax by walking you through breathing in and out slowly. It will help you clear your mind and focus on your breathing.";
	}

	public static void BreathingExercise (int mode) {
		string[] _breathingModes = {"Breath in...", "Hold...", "Breath out..."};
		Display(_breathingModes[mode]);
		CountDown(5);
		NewLine();
	}

	public static void NormalBreathing (int count) {
		Display("Now breath normally...");
		CountDown(count);
		NewLine();
	}

	public override void RunActivity() {
		_remainingSeconds = _duration % 5;
		_repetitions = (_duration - _remainingSeconds) / 5;

		for (var i = 0; i < _repetitions; i++)
		{
			BreathingExercise(i % 3);
			// Add another line break if set finishes only if it is not the last set.
			if (i % 3 == 2 && i+1 != _repetitions) {
				NewLine();
			}
		}
		if (_remainingSeconds > 0) {
			if (_repetitions > 0) {
				NewLine();
			}
			NormalBreathing(_remainingSeconds);
		}
	}

}