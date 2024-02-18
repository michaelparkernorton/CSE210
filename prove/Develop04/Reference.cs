public class Reference
{
    public string _book { get; set;}
		public int _chapter { get; set;}
		public int _verse { get; set;}
		public int _lastVerse { get; set;}
		private string _referenceText;

		// Constructor for reference with multiple verses
		public Reference(string _book, int _chapter, int _verse, int _lastVerse)
		{
			this._book = _book;
			this._chapter = _chapter;
			this._verse = _verse;
			this._lastVerse = _lastVerse;
			this._referenceText = $"{_book} {_chapter}:{_verse}-{_lastVerse}";
		}

		// Displaying the reference
		public void DisplayReference()
		{
			Console.Write(_referenceText);
		}
    
}