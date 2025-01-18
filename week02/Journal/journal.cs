using System;
using System.Formats.Asn1;

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
        Console.WriteLine("Enter a filepath: ");
        string filename = Console.ReadLine();

        using (StreamWriter journalFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                journalFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
            }
        }

    }

    public void LoadFromFile()
    {

    }
    

}