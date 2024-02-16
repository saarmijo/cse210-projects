using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.WriteLine("");
        Reference reference = GetUserReference();
        string text = GetUserScriptureText();

        Scripture scripture = new Scripture(reference, text);

        DisplayScripture(scripture);

        while (true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input == "quit")
                break;

            ClearConsole();
            scripture.HideRandomWords();
            DisplayScripture(scripture);
        }
    }
     static Reference GetUserReference()
    {
        Console.Write("Enter the book: ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter: ");
        string chapter = Console.ReadLine();

        Console.Write("Enter the verse(s): ");
        string verse = Console.ReadLine();

        return new Reference(book, chapter, verse);
    }

    static string GetUserScriptureText()
    {
        Console.Write("Enter the scripture text: ");
        return Console.ReadLine();
    }
    static void ClearConsole()
    {
        Console.Clear();
    }
    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine("");
        Console.WriteLine(scripture.GetReference());

        foreach (Word word in scripture.GetWords())
        {
            Console.Write(word.GetRenderedText() + " ");
        }
        Console.WriteLine();
    }
}
// Exceed Requirements:
// Allowing the user to input their own scripture reference and text. 