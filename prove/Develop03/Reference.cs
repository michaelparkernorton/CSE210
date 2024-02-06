public class Reference
{
    private string _book;
		private int _chapter;
		private int _verse;
		private int _lastVerse;
		private string _referenceText;

		public Reference(string book, int chapter, int verse)
		{
			_book = book;
			_chapter = chapter;
			_verse = verse;
			_referenceText = $"{_book} {_chapter}:{_verse}";
		}
		public Reference(string book, int chapter, int verse, int lastVerse)
		{
			_book = book;
			_chapter = chapter;
			_verse = verse;
			_lastVerse = lastVerse;
			_referenceText = $"{_book} {_chapter}:{_verse}-{_lastVerse}";
		}

		public void DisplayReference()
		{
			Console.Write(_referenceText);
		}
    
}