using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("Welcome to this activity program");
        Console.Clear();
        Console.WriteLine("Menu:");
        Console.WriteLine("1-Breathing Activity");
        Console.WriteLine("2-Listing Activity");
        Console.WriteLine("3-Reflection Activity");
        Console.WriteLine("4-Quit");
        Console.WriteLine("Choose an activity number to proceed:");
        int choice = int.Parse(Console.ReadLine());

        if (choice ==1)
        {
            BreathingActivity breathing = new BreathingActivity ();
            breathing.Run();
        
        }

        else if (choice == 2)
        {
            ListingActivity  listing = new ListingActivity();
            listing.Run();
        }

        else if (choice == 3)
        {
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.Run();
        }

        else
        {
            Console.WriteLine("Bye");
            
        }

    

    }
}