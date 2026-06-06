using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
// To show creativity,I declared some variable to count the number of time an activity has been performed 
        int numberOfBreathing = 0;
           
        int numberOfListing = 0;

        int numberOfReflecting = 0;
// To show creativity, I used a date variable to keep a log of the date the activity has been performed
        DateTime activityDate = DateTime.Now ;
        
        while(true)
        {
           Console.Clear();
           

           Console.WriteLine("Menu Options:");
           Console.WriteLine("    1-Breathing Activity");
           Console.WriteLine("    2-Listing Activity");
           Console.WriteLine("    3-Reflection Activity");
           Console.WriteLine("    4-Quit");
           Console.WriteLine("Select a choice from the menu:");
           string choice = Console.ReadLine();
           
            if (choice == "4")
            {
                
                Console.WriteLine("Bye");
                break;
            }

            else if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity ();
                breathing.Run();
                numberOfBreathing ++;
                Thread.Sleep(1000);
                

                
                
            }

            else if (choice == "2")
            {
                ListingActivity  listing = new ListingActivity();
                listing.Run();
                numberOfListing ++;
                Thread.Sleep(1000);
            }

            else if (choice == "3")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                numberOfReflecting ++;
                Thread.Sleep(1000);
            }
            
        }
// To show creativity, I display the log when the quit.
        Console.WriteLine($"Date:{activityDate}, You performed {numberOfBreathing} times the Breathing Activity");
        Console.WriteLine($"Date:{activityDate}, You performed {numberOfListing} times the Listing Activity");
        Console.WriteLine($"Date:{activityDate}, You performed {numberOfReflecting} times the Reflecting Activity");

        

        

    

    }
}