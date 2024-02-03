using System;
using System.IO.Enumeration;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string userChoice = "1";

        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine(" 1. Write");
            Console.WriteLine(" 2. Display");
            Console.WriteLine(" 3. Load");
            Console.WriteLine(" 4. Save");
            Console.WriteLine(" 5. Quit");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Would you like a prompt? ");
                    string promptChoice = Console.ReadLine();
                    if (promptChoice == "yes")
                    {
                        PromptGenerator promptGenerator = new PromptGenerator();
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine(prompt);
                        string response = Console.ReadLine();

                        // ENTRY
                        Entry entry = new Entry();
                        entry._prompt = prompt;
                        entry._response = response;
                        entry._date = DateTime.Now;

                        //JOURNAL
                        journal._entries.Add(entry);
                    }
                    else
                    {
                        Console.WriteLine("Write: ");
                        string response = Console.ReadLine();

                        // ENTRY
                        Entry entry = new Entry();
                        entry._response = response;
                        entry._date = DateTime.Now;

                        //JOURNAL
                        journal._entries.Add(entry);
                    }
                    break;
                case "2":
                    foreach (Entry singleEntry in journal._entries)
                    {
                        Console.WriteLine("Date: " + singleEntry._date + " - " + singleEntry._prompt);
                        Console.WriteLine(singleEntry._response);
                        Console.WriteLine("");
                    }
                    break;
                case "3":
                    Console.WriteLine("What is the file name? ");
                    string userInput = Console.ReadLine();
                    string userFile = userInput + ".txt";
                    journal.LoadJournalFile(userFile);
                    break;
                case "4":
                    Console.WriteLine("What is the file name? ");
                    string filename = Console.ReadLine();
                    string filepath = filename + ".txt";
                    Journal myJournal = new Journal();
                    journal.SaveJournalToFile(journal._entries, filepath);
                    break;
                case "5":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}