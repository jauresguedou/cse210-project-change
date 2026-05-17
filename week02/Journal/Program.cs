using System;
using System.Collections.Generic;
using System.IO;
using System.CodeDom.Compiler;
using System.Dynamic;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Save To Database");
        Console.WriteLine("5. Load");
        Console.WriteLine("6. Load From File");
        Console.WriteLine("7. Quit");
        Console.Write("What would you like to do?:");
        
        int  choice = int.Parse(Console.ReadLine());
        Journal myJournal = new Journal();
        myJournal.CreateDatabase();

        while (choice != 7)
        {
            if(choice == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine($"{randomPrompt}");
                Console.Write("> ");

                string userAnswer = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();

                 newEntry._promptText = randomPrompt;

                 newEntry._enterText = userAnswer;
                 newEntry._date = date;

                 myJournal.AddEntry(newEntry);
            
            }

           else if (choice == 2)
            {
                myJournal.DisplayAll();
            }

            
           else  if (choice == 3)
            {
                Console.WriteLine("What is the name of your file?:");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }


            else if (choice == 4)
             {
                    myJournal.SaveToDatabase();
             }
           else if (choice == 5)
              {
                Console.WriteLine("What is the name of your file?:");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);

              }


            else if (choice == 6)
                {
                    myJournal.LoadFromDatabase();
                }

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Save To Database");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Load From File");
            Console.WriteLine("7. Quit");
            Console.Write("What would you like to do?:");
            choice = int.Parse(Console.ReadLine());
            

        }

       
        Console.WriteLine("See You Later!");
        
        
    }
}    
