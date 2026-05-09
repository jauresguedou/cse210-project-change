using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        string letter = "";
        if (percentage>=90)
        {
           letter = "A";
            
        }
        
        else if (percentage>=80)
        {
            letter = "B";
        }
        else if (percentage>=70)
        {
            letter = "C";
        }
        else if (percentage>=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your letter grade is {letter}");

        if (percentage>=70)
        {
            Console.WriteLine("Gratulations you have passed the course");
        }

        else if (percentage<70)
        {
            Console.WriteLine("Failure is part of your learning, you have multiple chances. Better luck next time.");
        }


    }
}