public class Reflecting : Activity
{
	private string _randomPrompt;
	private string _randomReflectQuestion;
	private int _remainingSeconds;
	private int _repetitions;

	public Reflecting() : base() {
		_name = "Reflecting";
		_description = "This activity will help you reflect on times in your life when you have shown strength and resilience. It will help you recognize the power you have and how you can use it in other aspects of your life.";
	}
	public override void RunActivity() {
		SetRandomPrompt();
		Display("Consider the following prompt:");
		Break();
		Display(_randomPrompt);
		Break();
		Display("When you have something in mind, press enter to continue.");
		NewLine();
		Console.ReadLine();
		Display("Now ponder on each of the following questions as they relate to this experience.");
		NewLine();
		Display("You may begin in: ");
		CountDown(5);
		ClearDisplay();
		ReflectQuestions();
	}
	public void SetRandomPrompt() {
		var rand = new Random();
		string[] prompts = {
			"Think of a time when you stood up for someone else.", 
			"Think of a time when you did something really difficult.", 
			"Think of a time when you helped someone in need.", 
			"Think of a time when you did something truly selfless."
		};
		_randomPrompt = $" --- {prompts[rand.Next(prompts.Length)]} ---";
	}

	public int SetRandomReflectQuestion(List<string> reflectQuestions) {
		var rand = new Random();
		int randomNumber = rand.Next(reflectQuestions.Count);
		
		_randomReflectQuestion = reflectQuestions[randomNumber];
		return randomNumber - 1;
	}

	public void ReflectQuestions() {
		_remainingSeconds = _duration % 6;
		_repetitions = (_duration - _remainingSeconds) / 6;
		// Make the user take at least 6 seconds on this activity
		if (_remainingSeconds != 0) {
			_repetitions++;
			_duration += 6 - _remainingSeconds;
		}
		int reflectQuestionIndex;
		List<string> reflectQuestions = new()
		{
			"Why was this experience meaningful to you?", 
			"Have you ever done anything like this before?", 
			"How did you get started?", 
			"How did you feel when it was complete?",
			"What made this time different than other times when you were not as successful?",
			"What is your favorite thing about this experience?",
			"What could you learn from this experience that applies to other situations?",
			"What did you learn about yourself through this experience?",
			"How can you keep this experience in mind in the future?"
		};
		for (var i = 0; i < _repetitions; i++)
		{
			reflectQuestionIndex = SetRandomReflectQuestion(reflectQuestions);
			Display($"> {_randomReflectQuestion} ");
			reflectQuestions.RemoveAt(reflectQuestionIndex);
			// Six seconds
			Spinner();
			NewLine();
		}
	}

}