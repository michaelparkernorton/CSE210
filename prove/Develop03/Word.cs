public class Word
{
    private string _word { get; set;}
    private bool _isHidden { get; set;}

    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }

    // Displays the word as itself or as underscores
    public void DisplayWord()
    {
        if (_isHidden)
        {
            Console.Write(Hide());
        }
        else
        {
            Console.Write(_word);
        }
    }

    // takes the string length of the word and returns a string with that many underscores
    public string Hide()
    {
        string hidden = "";
        foreach (char letter in _word)
        {
            hidden += "_";
        }
        return hidden;
    }

    // changes the current state of a word to being hidden or not.
    public void IsHidden(bool value)
    {
        _isHidden = value;
    }

    // returns whether has already been hidden or not
    public bool GetIsHidden()
    {
        return _isHidden;
    }
}