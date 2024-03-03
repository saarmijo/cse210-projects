public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _responses = new List<string>
    {

    };
    public ListingActivity(string activityName, int duration, string activityDescription) : base(activityName, duration, activityDescription)
    {

    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public void Listing(int seconds)
    {
        int Timer = 0;

        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        for (int i = 5; i >= 0; i--)
        {
            Console.Write($"You may begin in: {i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (19));
            Console.Write(blank);
        }
        Console.WriteLine();
        DateTime startTime = DateTime.Now;

        while (Timer < seconds)
        {
            Console.Write("> ");
            _responses.Add(Console.ReadLine());

            TimeSpan elapsedTime = DateTime.Now - startTime;
            Timer = (int)elapsedTime.TotalSeconds;
        }

        int listLength = _responses.Count;
        Console.WriteLine($"\nYou listed {listLength} items!");
    }
}