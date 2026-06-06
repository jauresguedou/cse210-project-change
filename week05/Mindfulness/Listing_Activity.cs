using System;
using System.Collections.Generic;
using System.IO;
using System.Net;


public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string> ();
    List <string> responses = new List<string>();
    public ListingActivity ()
    {
        _name = "Listing";
        _description ="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");


    }


    public string GetRandomPrompts()
    {   

        
        Random number = new Random();

        int index = number.Next(_prompts.Count);
       

        return $"{_prompts[index]}";
       
       


    }


    public List<string> GetListFromUser()
    {

       DateTime endTime1 = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime1)
        {
            Console.WriteLine(">");
            string response = Console.ReadLine();
            responses.Add(response);
            
        }

        return responses;

     
        
        
    }


    public void Run()
    {

        
        DisplayStartMessage();
        Console.Clear();
        Console.WriteLine();

        string prompt = GetRandomPrompts();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{prompt}---");

        Console.WriteLine("You may begin in:...");
        ShowCountDown(5);
        

        List <string> answers = GetListFromUser();

        _count = answers.Count();
        Console.WriteLine($"You listed {_count}");

        DisplayEndMessage();

        
    }
}

