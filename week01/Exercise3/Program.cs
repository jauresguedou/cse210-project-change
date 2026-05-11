using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("There is a random magic number ");
        Random  randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);
        Console.Write("What is your guess? ");
        string  guess = Console.ReadLine();
        int magic_guess = int.Parse(guess);
        int trialNumber = 1;

        
        while (magic_guess != randomNumber)
        {
            
        
            
            if (magic_guess < randomNumber)
                
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                magic_guess = int.Parse(guess);
                trialNumber++;
                
                
            }
            else if (magic_guess> randomNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                magic_guess = int.Parse(guess);
                trialNumber++;
            }
       
            
                
        }
        Console.WriteLine("You guessed it");
        Console.WriteLine($"You made {trialNumber} attempts");
        
    
        
       
        
    }
}