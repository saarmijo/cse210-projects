public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _questionList = new List<string>();
    public ReflectingActivity(string activityName, int duration, string activityDescription) : base(activityName, duration, activityDescription)
    {

    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void Reflecting(int seconds)
    {
        int Timer = 0;
        Random random = new Random();

        while (Timer < seconds)
        {
            Console.WriteLine();
            string prompt = GetRandomPrompt();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"\n--- {prompt} ---");
            Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience:");
            Thread.Sleep(3000);

            Console.Clear();

            while (Timer < seconds)
            {
                int questionIndex = random.Next(_questions.Count);
                string question = _questions[questionIndex];

                Console.WriteLine($"\n> {question}  ");
                Thread.Sleep(10000);

                Timer += 10;

                if (Timer >= seconds)
                    break;
            }
        }
    }



}