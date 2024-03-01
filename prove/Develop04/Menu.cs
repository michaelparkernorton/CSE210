public class Menu
{
	private int _option;
	public int Option
     {
         get { return _option; }
         set { _option = value; }
     }
	public Menu () {}

	static void ClearDisplay() {
		Console.Clear();
	}

	public void DisplayMenu () {
		string[] _options = {"Start breathing activity", "Start reflecting activity", "Start listing activity", "Start strength training activity", "Quit"};

		ClearDisplay();
		Console.WriteLine("Menu Options:");
		for (var i = 0; i < _options.Length; i++)
		{
			Console.WriteLine($"  {i+1}. {_options[i]}");
		}
		Console.Write("Select a choice from the menu: ");

		var value = Console.ReadLine();

		bool success = int.TryParse(value, out int number);
		if (success)
		{
			_option = number;
			Console.WriteLine($"You selected {_option}");
		}
		else
		{
			Console.WriteLine($"{value ?? "<null>"} is not a number.");
		}
	}

	public Activity SelectActivity(int option) {
		ClearDisplay();
		if (option == 1) {
			return new Breathing();
		} else if (option == 2) {
			return new Reflecting();
		} else if (option == 3) {
			return new Listing();
		} else if (option == 4) {
			return new StrengthTraining();
		}	else {
			return null;
		}
	}
}