using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2010";
        job1._endYear = "2020";

        Job job2 = new Job();
        job2._jobTitle = "IT Intern";
        job2._company = "Apple";
        job2._startYear = "2008";
        job2._endYear = "2010";
        
        Resume myResume = new Resume();
        myResume._name = "Sofia Armijo";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}