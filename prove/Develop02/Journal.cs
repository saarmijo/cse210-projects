using System.IO.Compression;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void SaveJournalToFile(List<Entry> _entries, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Entry singleEntry in _entries)
            {
                writer.WriteLine("Date: " + singleEntry._date + " - " + singleEntry._prompt);
                writer.WriteLine(singleEntry._response);
                writer.WriteLine("");
            }
        }
    }
    public void LoadJournalFile(string userFile)
    {
       using StreamReader reader = new StreamReader(userFile);
       string line;
       while((line = reader.ReadLine()) != null)
       {
        Entry entry = new Entry();
        entry._prompt = line;
        entry._response = reader.ReadLine();
        _entries.Add(entry);
       }
    }
}