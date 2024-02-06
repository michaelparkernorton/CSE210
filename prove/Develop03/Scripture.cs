using System.Text.Json;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        string[] arrayWords = scriptureText.Split(" ");
        foreach (string arrayWord in arrayWords)
        {
            Word word = new Word(arrayWord, false);
            _words.Add(word);
        }
    }

    public void DisplayScripture()
    {
        _reference.DisplayReference();
        Console.Write(" ");
        foreach (Word word in _words)
        {
            word.DisplayWord();
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        Random rnd = new Random();
        for (int i = 0; i < 3; i++)
        {
            int wordIndex = rnd.Next(_words.Count);
            while (_words[wordIndex].GetIsHidden()) {
                wordIndex = rnd.Next(_words.Count);
            }
            _words[wordIndex].IsHidden(true);
        }
    }

    public bool IsHidden()
    {
        foreach (Word word in _words)
        {
            // Console.WriteLine($"Is Not Hidden? {!word.GetIsHidden()}");
            if(!word.GetIsHidden()){
                return false;
            }
        }
        return true;
    }
}