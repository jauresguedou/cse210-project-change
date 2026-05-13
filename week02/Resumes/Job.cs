using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Job
{
    public string _jobTitle = "";
    public string _jobCompany = "";
    public int _startYear;
    public int _endYear;
    public Job ()
    {
        
    }
    public void DisplayJob()
    {
      Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_startYear}-{_endYear}");
    }
}