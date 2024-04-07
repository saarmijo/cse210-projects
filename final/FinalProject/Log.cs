public class Log
{
    private List<string> _logEntries;

    public Log()
    {
        _logEntries = new List<string>();
    }

    public void LogEntry(string entry)
    {
        _logEntries.Add(entry);
        Console.WriteLine($"Logged: {entry}");
    }

    public void DisplayLog()
    {
        Console.WriteLine("Log Entries:");
        foreach (var entry in _logEntries)
        {
            Console.WriteLine(entry);
        }
    }

}