public class FiveSensesActivity : Activity
{
    private List<string> _sight = new List<string> { };
    private List<string> _touch = new List<string> { };
    private List<string> _sound = new List<string> { };
    private List<string> _smell = new List<string> { };
    private List<string> _taste = new List<string> { };
    public FiveSensesActivity(string activityName, int duration, string activityDescription) : base(activityName, duration, activityDescription)
    {

    }
    public void FiveSenses(int seconds)
    {
        int Timer = 0;
        Console.WriteLine();
        Console.WriteLine("Focus on each of your five senses: sight, touch, sound, smell, and taste.");
        Thread.Sleep(3000);
        Console.WriteLine("\nTake note of what each sense is sensing at this moment.");
        Thread.Sleep(3000);
        Console.WriteLine($"\nYou will have {seconds} seconds to ponder on each of these, and then you will be asked to write them down.");
        Thread.Sleep(5000);
        Console.WriteLine("\nYour time starts now!");
        DateTime startTime = DateTime.Now;

        while (Timer < seconds)
        {
            Spinner();
            TimeSpan elapsedTime = DateTime.Now - startTime;
            Timer = (int)elapsedTime.TotalSeconds;
        }
        Console.WriteLine("\nGood job! It is now time to write them down.");

        Console.Write("\nWhat 5 things can you see?- ");
        _sight.Add(Console.ReadLine());

        Console.Write("\nWhat 4 things can you touch?- ");
        _touch.Add(Console.ReadLine());

        Console.Write("\nWhat 3 things can you hear?- ");
        _sound.Add(Console.ReadLine());

        Console.Write("\nWhat 2 things can you smell?- ");
        _smell.Add(Console.ReadLine());

        Console.Write("\nWhat 1 thing can you taste?- ");
        _taste.Add(Console.ReadLine());
    }
}