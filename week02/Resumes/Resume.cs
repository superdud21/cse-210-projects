using System;

public class Resume
{
    public string _employeeName;   
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_employeeName}");
        Console.WriteLine($"Jobs:");

        foreach (var job in _jobs)
        {
            job.Display();
        }

    }
}