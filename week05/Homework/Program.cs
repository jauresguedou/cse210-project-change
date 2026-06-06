using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Samuel Bennett","Multiplication");

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez","Fractions","Section 7.3","Problems 8-19");

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters","European History","The Causes of World War 2");

        string  summary = assignment.GetSummary();

        string   summary1 = mathAssignment.GetSummary();
        string   Homework = mathAssignment.GetHomeworkList();

        string   summary2 = writingAssignment.GetSummary();
        
        string   Homework2 = writingAssignment.GetWritingInformation();
        Console.WriteLine(summary);
        Console.WriteLine();
        Console.WriteLine(summary1);
        Console.WriteLine(Homework);
        Console.WriteLine();
        Console.WriteLine(summary2);
        Console.WriteLine(Homework2);


    }
}