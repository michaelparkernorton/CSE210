public class Scripture
{
    private string _reference { get; set;}
    private string _striptureText { get; set;}
    private List<Word> _words = new List<Word>();

    public Scripture(string _reference, string _scriptureText)
    {
        this._reference = _reference;
        this._striptureText = _scriptureText;
        
        // Takes the scripture text and makes it an array of words
        string[] arrayWords = this._striptureText.Split(" ");
        foreach (string arrayWord in arrayWords)
        {
            // words are initiality set to be unhidden
            Word word = new Word(arrayWord, false);
            this._words.Add(word);
        }
    }

    // Renders reference and current view of words that are hidden or not.
    public void DisplayScripture()
    {
        Console.Write($"{this._reference} ");
        foreach (Word word in this._words)
        {
            word.DisplayWord();
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    // Chooses three random words randomly to hide. If random words have already been hidden
    // it continues to search until three new words have been hidden.
    public void HideWords()
    {
        Random rnd = new Random();
        for (int i = 0; i < 3; i++)
        {
            if (this.IsHidden())
            {
                break;
            }
            int wordIndex = rnd.Next(this._words.Count);
            while (this._words[wordIndex].GetIsHidden()) {
                wordIndex = rnd.Next(_words.Count);
            }
            this._words[wordIndex].IsHidden(true);
        }
    }

    // Checks to see if all the words are hidden in the scripture
    public bool IsHidden()
    {
        foreach (Word word in this._words)
        {
            if(!word.GetIsHidden()){
                return false;
            }
        }
        return true;
    }

    // public Reference GetReference()
    // {
    //     return this._reference;
    // }

    public string GetScriptureText()
    {
        return this._striptureText;
    }
}