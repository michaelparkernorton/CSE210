public class Assignment {

	protected string _studentName;
	protected string _topic;

	public Assignment (string _studentName, string _topic) {
		this._studentName = _studentName;
		this._topic = _topic;
	}
	
	public string GetSummary()
	{
		return $"{_studentName} - {_topic}";
	}
	
}