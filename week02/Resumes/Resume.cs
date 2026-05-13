using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _personName = "";

    public List<Job>  _jobs = new List <Job>();

    public void  DisplayDetails ()
    {
        Console.WriteLine($"Name:{_personName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            
            job.DisplayJob();
        }
    }

}