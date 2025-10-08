using System;

class Journal
{
    // Atttributes
    public List<Entry> _entryList = new List<Entry>();

    // Behaviors
    public void AppendEntry(Entry e)
    {
        _entryList.Add(e);
    }
    
    public void Display()
    {
        Console.WriteLine("==========================");
        foreach (Entry i in _entryList)
        {
            Console.WriteLine("--------------------------");
            i.Display();
        }
    }
}