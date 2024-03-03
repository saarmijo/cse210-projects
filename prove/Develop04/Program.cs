using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "1";
        int seconds = 0;

        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Start 5 senses activity");
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menu: ");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    seconds = breathing.GetDuration();
                    breathing.DisplayStartingMessage();
                    breathing.Breathing(seconds);
                    breathing.DisplayEndingMessage();
                    break;
                case "2":
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.GetActivityName();
                    reflecting.GetActivityDescription();
                    seconds = reflecting.GetDuration();
                    reflecting.DisplayStartingMessage();
                    reflecting.Reflecting(seconds);
                    reflecting.DisplayEndingMessage();
                    break;
                case "3":
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing", 0, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.GetActivityName();
                    listing.GetActivityDescription();
                    seconds = listing.GetDuration();
                    listing.DisplayStartingMessage();
                    listing.Listing(seconds);
                    listing.DisplayEndingMessage();
                    break;
                case "4":
                    Console.Clear();
                    FiveSensesActivity fivesenses = new FiveSensesActivity("Five Senses", 0, "This activity will help you ground yourself by identifying 5 things you can see, 4 things you can touch, 3 things you can hear, 2 things you can smell, and 1 thing you can taste.");
                    fivesenses.GetActivityName();
                    fivesenses.GetActivityDescription();
                    seconds = fivesenses.GetDuration();
                    fivesenses.DisplayStartingMessage();
                    fivesenses.FiveSenses(seconds);
                    fivesenses.DisplayEndingMessage();
                    break;
                case "5":
                    Console.WriteLine("\nGoodbye!");
                    break;
                default:
                    Console.WriteLine("Please select a valid choice from the menu.");
                    break;
            }
        }
    }
}