public class Video
{
	private string _title;
	private string _author;
  private int _length;

	List<Comment> _comments = new List<Comment>();

	public Video (string title, string author, int length) {
		_title = title;
		_author = author;
		_length = length;
	}

	public void SaveComment (Comment comment) {
		_comments.Add(comment);
	}

	public int CountComments () {
		return _comments.Count;
	}

	public void DisplayVideo (int number) {
		Console.WriteLine("====================================");
		Console.WriteLine($"video: {number}\ntitle: {_title}\nauthor: {_author}\nlength: {_length} seconds\nnumber of comments: {this.CountComments()}");
		int count = 1;
		foreach (var comment in _comments)
		{
			comment.DisplayComment(count++);
		}
		Console.WriteLine("====================================");
	}

}