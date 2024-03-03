public class BreathingActivity : Activity
{
    private string _breatheInMessage = "Breathe in...";
    private string _breatheOutMessage = "Breathe out...";
    public BreathingActivity(string activityName, int duration, string activityDescription) : base(activityName, duration, activityDescription)
    {

    }
    public void Breathing(int seconds)
    {
        Console.WriteLine();
        int Timer = 0;
        while (Timer < seconds)
        {
            Console.WriteLine();
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_breatheInMessage}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_breatheInMessage.Length + 2));
                Console.Write(blank);
                Timer += 1;
            }
            Console.WriteLine($"{_breatheInMessage}  ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write($"{_breatheOutMessage}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_breatheOutMessage.Length + 2));
                Console.Write(blank);
                Timer += 1;
            }
            Console.WriteLine($"{_breatheOutMessage}  ");
        }
    }
}