using System.ComponentModel.Design;

public class Activity
{
	protected string _name;
	protected string _welcomeMessage;
	protected string _description;
	private string _startMessage;
	protected int _duration;
	private string _results;
	public Activity() {}

	// STARTING AN ACTIVITY
	public void StartActivity() {
		SetStartMessage();
		Display(_startMessage);
		SetDuration();
		ClearDisplay();
		Display("Get ready...");
		NewLine();
		Spinner();
		Break();
	}
	public void SetStartMessage() {
		SetWelcomeMessage();
	 	string _askHowLong = "How long, in seconds, would you like for your session? ";

		_startMessage = $"{_welcomeMessage}\n\n{_description}\n\n{_askHowLong}";
	}
	public void SetDuration() {
		var value = Console.ReadLine();

		bool success = int.TryParse(value, out int number);
		if (success)
		{
			_duration = number;
			Console.WriteLine($"You would like {_duration} seconds");
		}
		else
		{
			Console.WriteLine($"{value ?? "<null>"} is not a number.");
		}
	}
	public void SetWelcomeMessage() {
		_welcomeMessage = $"Welcome to the {_name} Activity."; 
	}

	// RUNNING AN ACTIVITY
	public virtual void RunActivity() {}
	
	// ENDING AN ACTIVITY

	public void EndActivity() {
		string CONGRATULATIONS = "Well done!!";
		SetResults();
		Break();
		Display(CONGRATULATIONS);
		NewLine();
		Spinner();
		Break();
		Display(_results);
		NewLine();
		Spinner();
	}
	public void SetResults() {
		_results = $"You have completed another {_duration} seconds of {_name} Activity";
	}

	// Display Methods

	public static void Display(string message) {
		Console.Write(message);
	}

	public static void NewLine() {
		Console.WriteLine();
	}

	public static void Break() {
		Console.WriteLine();
		Console.WriteLine();
	}

	public static void ClearDisplay() {
		Console.Clear();
	}


// Timer Methods
	public static void CountDown(int count) {
		for (var i = count; i > 0; i--)
		{
			Display(i.ToString());
			Pause(10);
			RemoveCharacter();
		}
	}

	public static void Spinner() {
		int spinCount = 3;
		for (var i = 0; i < spinCount; i++)
		{
			Spin();
		}

	}

	public static void Spin() {
		string[] _spinnerCharacters = {"-", @"\", "|", "/"};

		foreach (var spinnerChar in _spinnerCharacters)
		{
			Display(spinnerChar);
			Pause(1);
			RemoveCharacter();
		}
	}

	public static void Pause(int tenthseconds) {
		int milliseconds = (tenthseconds * 100);
		Thread.Sleep(milliseconds);
	}

	public static void RemoveCharacter() {
		Console.Write("\b \b");
	}

}