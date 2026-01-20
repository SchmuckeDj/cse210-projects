using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._prompt);
                writer.WriteLine(entry._text);
                writer.WriteLine("-----");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 4)
        {
            Entry entry = new Entry();
            entry._date = lines[i];
            entry._prompt = lines[i + 1];
            entry._text = lines[i + 2];

            _entries.Add(entry);
        }
    }
}
