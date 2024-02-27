public class Menu
{
	private string[] _options = {"Start breathing activity", "Start reflecting activity", "Start listing activity", "Quit"};
	private int _option;

	public int Option
     {
         get { return _option; }
         set { _option = value; }
     }
	public Menu () {
		
	}

	public void ClearDisplay() {
		Console.Clear();
	}

	public void DisplayMenu () {
		Console.WriteLine("Menu Options:");
		for (var i = 0; i < _options.Length; i++)
		{
			Console.WriteLine($"  {i+1}. {_options[i]}");
		}
		Console.Write("Select a choice from the menu: ");

		var value = Console.ReadLine();
		int number;

		bool success = int.TryParse(value, out number);
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
		if (option == 1) {
			Breathing activity = new();
			return activity;
		} else if (option == 2) {
			Reflecting activity = new();
			return activity;
		} else if (option == 3) {
			Listing activity = new();
			return activity;
		}	else {
			return null;
		}
	}
}