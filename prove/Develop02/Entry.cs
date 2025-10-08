using System;
using System.ComponentModel.DataAnnotations;

class Entry
{
    // Atttributes
    public string _entryDate;
    public string _givenPrompt;
    public string _entryText;

    // Behaviors
    public void Display()
    { 
        Console.WriteLine($"{_entryDate} - {_givenPrompt}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }

}