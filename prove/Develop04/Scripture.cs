public class Scripture
{
	  // public string _striptureText { get; set;}
    public Reference _reference { get; set;}


    public Scripture(Reference _reference)
    {
        this._reference = _reference;
        // this._striptureText = _striptureText;
    }
}