using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Abraham", 2, 2);

        Scripture scripture = new Scripture(
            reference,
            "And it came to pass that I, Abraham, took Sarai to wife, and Nahor, my brother, took Milcah to wife, who was the daughter of Haran."
        );

        while(!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to continue or type quit");

            string input = Console.ReadLine();

            if (input == "quit" || input == "Quit")
            {
                break;
            }

            scripture.HideRandomWords(4);

        }

        
       Console.Clear();
       Console.WriteLine(scripture.GetDisplayText());


    }
}