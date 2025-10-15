using System;

class Scripture
{
    private string _text;
    private string _reference;

    public Scripture(string text, string reference)
    {
        _text = text;
        _reference = reference;
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}: {_text}");
    }
}