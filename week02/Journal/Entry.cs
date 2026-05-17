using System;
using System.Collections.Generic;

public class Entry
{
    
    public string _promptText = "";
    public string _enterText = "";
    public string _date = "";

    public void Display ()
    {
        Console.WriteLine($"Your response to the question {_promptText} prompted on {_date} is {_enterText}");
    }
    
 

}