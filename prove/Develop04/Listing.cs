public class Listing : Activity
{
	private string _randomPrompt;
	public Listing() : base() {
		_name = "Listing";
		_description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
	}

	public override void RunActivity() {
		SetRandomPrompt();
		Display("List as many responses you can to the following prompt:");
		NewLine();
		Display(_randomPrompt);
		NewLine();
		Display("You may begin in: ");
		CountDown(5);
		NewLine();
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(_duration);
		int count = 0;
		
		while(DateTime.Now < endTime){
			Display("> ");
			Console.ReadLine();
			count++;
		}
		Display($"You listed {count} items!");
	}

	public void SetRandomPrompt() {
		var rand = new Random();
		string[] prompts = {
			"Who are people that you appreciate?", 
			"What are personal strengths of yours?", 
			"Who are people that you have helped this week?", 
			"When have you felt the Holy Ghost this month?",
			"Who are some of your personal heroes?"
		};
		_randomPrompt = $" --- {prompts[rand.Next(prompts.Length)]} ---";
	}
}