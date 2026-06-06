using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


public class Activity
{
    protected string _name ;
    protected string  _description;

    protected   int _duration;

    public Activity ()
    {
        _name = "" ;
        _description = "";
        _duration = 0;
    }

  

    public void DisplayStartMessage()
    {
        
        Console.Clear();  
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would like for your session?:");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(5);  
        
    }


    public void ShowSpinner (int seconds)
    {
   
       

        char []  spinner = {'/','|','-','\\'};

        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while(startTime < endTime)
        {
            Console.WriteLine(spinner[i % spinner.Length]);
            Console.WriteLine("\b");
            i++;
        }

        Console.WriteLine();
    }



    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i> 0; i--)
        {
            Console.WriteLine($"You may begin in :{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Start");


    }


    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done you did a great job");
        Console.WriteLine($"You have completed {_duration} of {_name} Activity\n");
        ShowSpinner(5);

        
        
        
    }
    
}