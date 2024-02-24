using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Sofia Armijo", "Grammar");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Sofia Armijo", "Fractions", "7.3", "8-19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Sofia Armijo", "European History", "The Causes of World War II");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}