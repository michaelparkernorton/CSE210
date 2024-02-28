using System.ComponentModel.Design;

public class Activity
{
	protected string _name;
	protected string _welcomeMessage;
	protected string _description;
	private string _askHowLong = "How long, in seconds, would you like for your session? ";
	protected int _duration;
	private string _startMessage;
	private string _endMessage;
	private string _congratulations = "Well done!!";
	private string _results;
	private string[] _spinnerCharacters = {"-", @"\", "|", "/"};

	public Activity() {
		_name = "";
		_welcomeMessage = "";
		_description = "";
		_duration = 0;
		_startMessage  = "";
		_endMessage = "";
	}
	public void SetWelcomeMessage() {
		_welcomeMessage = $"Welcome to the {_name} Activity."; 
	}

	public void SetStartMessage() {
		_startMessage = $"{_welcomeMessage}\n\n{_description}\n\n{_askHowLong}";
	}

	public void SetResults() {
		_results = $"You have completed another {_duration} seconds of {_name} Activity";
	}

	public void SetEndMessage() {
		_endMessage = $"\n\n{_congratulations}\n\n{_results}\n";
	}

	public void SetDuration() {
		var value = Console.ReadLine();
		int number;

		bool success = int.TryParse(value, out number);
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

	public void Display(string message) {
		Console.Write(message);
	}

	public void NewLine() {
		Console.WriteLine();
	}

	public void Break() {
		Console.WriteLine();
		Console.WriteLine();
	}

	public void StartActivity() {
		SetWelcomeMessage();
		SetStartMessage();
		Display(_startMessage);
		SetDuration();
	}

	public virtual void RunActivity() {

	}

	public void EndActivity() {
		SetResults();
		SetEndMessage();
		Display(_endMessage);
		Spinner();
	}

	public void CountDown(int count) {
		for (var i = count; i > 0; i--)
		{
			Display(i.ToString());
			Pause(10);
			RemoveCharacter();
		}
	}

	public void Spin() {
		foreach (var spinnerChar in _spinnerCharacters)
		{
			Display(spinnerChar);
			Pause(2);
			RemoveCharacter();
		}
	}

	public void Spinner() {
		int spinCount = 4;
		for (var i = 0; i < spinCount; i++)
		{
			Spin();
		}

	}

	public void Pause(int tenthseconds) {
		int milliseconds = (tenthseconds * 100);
		Thread.Sleep(milliseconds);
	}

	public void RemoveCharacter() {
		Console.Write("\b \b");
	}



}