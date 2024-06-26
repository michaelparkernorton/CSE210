using System.Text.Json.Serialization;

public class Reference
{
    private string _book { get; set;}
		private int _chapter { get; set;}
		private int _verse { get; set;}
		private int _lastVerse { get; set;}
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

		// Constructor for reference with single verse
		public Reference(string _book, int _chapter, int _verse)
		{
			this._book = _book;
			this._chapter = _chapter;
			this._verse = _verse;
			_referenceText = $"{_book} {_chapter}:{_verse}";
		}

		// Displaying the reference
		public void DisplayReference()
		{
			Console.Write(_referenceText);
		}
    
}