public class Video
{
	private string _title;
	private string _author;
  private int _length;

	List<Comment> _comments;

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

	public void GetVideo () {
		
	}

}