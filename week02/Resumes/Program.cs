using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Salesperson";
        job2._jobCompany = "Amazone";
        job2._startYear = 2013;
        job2._endYear = 2023;

        Resume myResume = new Resume ();
        myResume._personName = "Jaures Guedou";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayDetails();

        
    }
}