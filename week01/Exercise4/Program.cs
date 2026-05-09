using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> userNumber = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        float sum = 0;
        double average = 0;
        int large = 0;
        int smallestPositive = int.MaxValue;
        string entered = Console.ReadLine();
        int number = int.Parse(entered);
        while (number != 0)
        {
            userNumber.Add(number);
            sum = sum + number;
            Console.Write("Enter number: ");
            entered = Console.ReadLine();
            number = int.Parse(entered);
           
            

        }
         
        average = sum / userNumber.Count;
        large = userNumber.Max();
        foreach (int num in userNumber)
        {
            if(num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {large}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

    }
}