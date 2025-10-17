using System;

class Word
{
    private bool _isHidden = false;
    private string _text = "";

    public Word(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }

    public void Hide()
    {
        _isHidden = true;
        _text = new string('_', _text.Length);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    
}