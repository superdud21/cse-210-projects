using System;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(string date, string prompt, string newEntry)
    {
        _entries.Add(new Entry {_date = date, _promptText = prompt, _entryText = newEntry});
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }
    

}