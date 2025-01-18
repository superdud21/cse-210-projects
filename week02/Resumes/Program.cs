using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Program Manager";
        job1._startYear = 2004;
        job1._endYear = 2020;

        Console.WriteLine(job1._company);
    }
}