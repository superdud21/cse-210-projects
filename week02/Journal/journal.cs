using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string date, string prompt, string newEntry)
    {
        _entries.Add(new Entry {_date = date, _promptText = prompt, _entryText = newEntry});
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }
    

}