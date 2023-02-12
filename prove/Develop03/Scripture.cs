using System;

class Scripture
{
    private string scripWords;
    private Reference scriptureReference;
    public Scripture(Reference _scriptureReference, string _scripWords)
    {
        scriptureReference = _scriptureReference;
        scripWords = _scripWords;
    }

    public string returnString()
    {
        return string.Format(scripWords);
    }
}