using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = words.Split(' ').Select(w => new Word(w)).ToList();
    }

    // public Scripture(Reference reference, List<Word> verse1, List<Word> verse2)
    // {
    //     _reference = reference;
    //     _words = verse1.Concat(verse2).ToList();
    // }

    public void Display()
    {
        Console.Clear();
        Console.Write(_reference.ToString() + " ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        {
            int index = rand.Next(_words.Count);
            int isHiddenCount = 0;

            while (isHiddenCount < count)
            {
                if (!_words[index].IsHidden())
                {
                    _words[index].Hide();
                    isHiddenCount++;
                }
                index = rand.Next(_words.Count);
            }
        }
        Display();
        Menu();
    }

    public void Menu()
    {
        Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
        string input = Console.ReadLine();

        int isListHiddenCount = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                isListHiddenCount++;
            }
        }
        if (isListHiddenCount >= _words.Count)
            {
                Console.Clear();
            }
        else if (input.ToLower() == "quit")
        {
            Console.Clear();
        }
        else
        {
            if (_words.Count - isListHiddenCount == 1)
            {
                HideRandomWords(1);
            }
            else if (_words.Count - isListHiddenCount == 2)
            {
                HideRandomWords(2);
            }
            else
            {
                HideRandomWords(3);
            }
        }
    }

}