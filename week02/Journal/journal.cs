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
        Console.WriteLine("Enter a filepath: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] entries = File.ReadAllLines(filename);
            foreach (string entry in entries)
            {
                string[] parts = entry.Split(',');
                _entries.Add(new Entry {_date = parts[0], _promptText = parts[1], _entryText = parts[2]});
            }

        } else {
            Console.WriteLine($"No Journal File exists at: {filename}");
        }
    }
}