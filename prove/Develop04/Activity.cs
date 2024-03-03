public class Activity
{
    private int _duration;
    private string _activityName;
    private string _activityDescription;
    public Activity(string activityName, int duration, string activityDescription)
    {
        _duration = duration;
        _activityName = activityName;
        _activityDescription = activityDescription;
    }
    public int GetDuration()
    {
        Console.Write($"How long, in seconds, would you like for your session? ");
        int userDuration = int.Parse(Console.ReadLine());
        _duration = userDuration;
        return userDuration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity!\n");
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void GetActivityDescription()
    {
        Console.WriteLine($"{_activityDescription}\n");
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
    public void Spinner()
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\","|", "/", "-", "\\" };
        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(400);
            Console.Write("\b \b");
        }
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Spinner();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName} Activity.");
        Spinner();
    }

}