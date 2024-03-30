public class Comment
{
	private string _name;

	private string _text;

	public Comment (string name, string text) {
		_name = name;
		_text = text;
	}

	public void DisplayComment (int number) {
		Console.WriteLine($"\ncomment: {number}\nname: {_name}\ntext: {_text}");
	}

}