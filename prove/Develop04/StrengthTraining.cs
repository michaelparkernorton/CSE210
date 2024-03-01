using System.Collections;

public class StrengthTraining : Activity
{
	private int _repetitions;
	private int _remainingSeconds;
	private string[] _exercises = {"push-ups", "sit-ups", "squats", "other"};
	public StrengthTraining() {
		_name = "Strength Training";
		_description = "This activity will help you build strength by helping you coordinate your movements contrating and relaxing your muscles with your breathing. When contrating your muscles breathe in, when relaxing breathe out. Remember to start small and listen to your body as you workout!";
	}

	public static void StrengthMovements () {
		string[] strengthModes = {"Relax muscles...Breath in...", "Contract muscles...Breath out..."};
		Movement(strengthModes[0], 3);
		NewLine();
		Movement(strengthModes[1], 2);
	}

	public static void Movement(string message, int count) {
		Display(message);
		CountDown(count);
	}

	public static void RepCount(int count) {
		Display($"Rep {count}");
		NewLine();
	}

	public override void RunActivity() {
		_remainingSeconds = _duration % 5;
		_repetitions = (_duration - _remainingSeconds) / 5;
		if (_remainingSeconds != 0) {
			_repetitions++;
			_duration += 5 - _remainingSeconds;
		}
		
		Display("Exercise Options:");
		NewLine();
			for (var i = 0; i < _exercises.Length; i++)
			{
				Display($"{i+1}. {_exercises[i]}");
				NewLine();
			}
			NewLine();
			Display("What exercise would you like to complete? ");
			string input = Console.ReadLine();
			string exerciseName = "";
		if (int.TryParse(input, out int exerciseNumber))
        {
						if (exerciseNumber <= 3)
						exerciseName = _exercises[exerciseNumber-1];
        }
				if (exerciseName == String.Empty) {
					NewLine();
					Display("I'm sorry... that's not one of the options!");
					Break();
					Display("What's the name of the exercise? ");
					exerciseName = Console.ReadLine();
				}
			NewLine();
			Display($"You will complete {_repetitions} reps of {exerciseName} for {_duration} seconds.");
			Break();
			Display("Press enter to start:");
			Console.ReadLine();
			GetReady();

		for (var i = 0; i < _repetitions; i++)

		{	
			RepCount(i+1);
			StrengthMovements();
			Break();
		}

		Display($"You completed {_repetitions} reps of {exerciseName}!");
		NewLine();
		Spinner();
	}

}