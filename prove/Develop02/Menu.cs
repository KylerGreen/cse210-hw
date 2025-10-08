using System;
using System.IO;

class Menu
{
    Journal currentJournal = new Journal();
    public void MenuDisplay()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("w. Write");
        Console.WriteLine("d. Display");
        Console.WriteLine("l. Load");
        Console.WriteLine("s. Save");
        Console.WriteLine("q. Quit");
        String chosenOption = Console.ReadLine();

        if (chosenOption == "w")
        {
            Write(currentJournal);
        }
        else if (chosenOption == "d")
        {
            Display();
        }
        else if (chosenOption == "l")
        {
            Load();
        }
        else if (chosenOption == "s")
        {
            Save();
        }
        else if (chosenOption == "q")
        {
            Console.WriteLine("Thank you for using this Journal Program!");
        }
        else
        {
            Console.WriteLine("Please select a valid option.");
            MenuDisplay();
        }

    }

    public void Write(Journal currentJournal)
    {
        Prompt generatedPrompt = new Prompt();
        Entry newEntry = new Entry();
        newEntry._entryDate = DateTime.Now.ToShortDateString();
        newEntry._givenPrompt = generatedPrompt.GeneratePrompt();
        Console.WriteLine(newEntry._givenPrompt);
        newEntry._entryText = Console.ReadLine();
        currentJournal.AppendEntry(newEntry);
        MenuDisplay();


    }

    public void Display()
    {
        currentJournal.Display();
        MenuDisplay();
    }

    public void Save()
    {
        Console.WriteLine("What would you like to name your file?");
        string filename = Console.ReadLine();
        filename = filename + ".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in currentJournal._entryList)
            {
                outputFile.WriteLine($"{entry._entryDate}|{entry._givenPrompt}|{entry._entryText}");
            }
        }
        MenuDisplay();

    }

    public void Load()
    {
        Console.WriteLine("What file would you like to load?");
        string filename = Console.ReadLine();
        filename = filename + ".txt";

        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry loadedEntry = new Entry();
                    loadedEntry._entryDate = parts[0];
                    loadedEntry._givenPrompt = parts[1];
                    loadedEntry._entryText = parts[2];
                    currentJournal.AppendEntry(loadedEntry);
                }
            }
            MenuDisplay();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("No saved journal found.");
            MenuDisplay();
        }
    }

}