public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }

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

    public string Hide()
    {
        string hidden = "";
        foreach (char letter in _word)
        {
            hidden += "_";
        }
        return hidden;
    }

    public void IsHidden(bool value)
    {
        _isHidden = value;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }
}