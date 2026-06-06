using System;
using System.Collections.Generic;
using System.IO;


public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly" +"Clear your mind and focus on your breathing";

       
       
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.Clear();
        Console.WriteLine(" You may begin in:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in ...");
            ShowCountDown(5);

            if (DateTime.Now >= endTime)
            {
                break;
            }
            


            Console.WriteLine("Breath out...");
            ShowCountDown(5);
        }
       DisplayEndMessage(); 

    }
}