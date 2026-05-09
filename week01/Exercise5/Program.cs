using System;
using System.ComponentModel;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        DisplayResult();


    
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
        
        
    }
    static string PromptUserName (string userName)
    {
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber (string number)
    {
        Console.Write("Please enter your favorite number: ");
        number =   Console.ReadLine();
        int favoriteNumber = int.Parse(number);
        return favoriteNumber;

    }
    static int SquareNumber (int unsquared)
    {
        return unsquared*unsquared;


    }

    static void DisplayResult ()
    {
       string nameDisplay = PromptUserName ("");
       int userNumber = PromptUserNumber("");
       int squared = SquareNumber(userNumber);
       Console.WriteLine($"{nameDisplay}, the squared of your number is {squared}");
    }

    
    
}