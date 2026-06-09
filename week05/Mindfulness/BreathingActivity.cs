using System;
using System.Collections.Generic;
using System.IO;


public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly \nclear your mind and focus on your breathing";

       
       
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in ...");
            ShowCountDown(5);
            Console.WriteLine("Now breathe out...");
            Console.WriteLine();

            if (DateTime.Now >= endTime)
            {
                break;
            }
            
        }
        
        DisplayEndMessage(); 
        ShowCountDown(5);

    }
}