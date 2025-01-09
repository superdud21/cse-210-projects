using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percentageInText = Console.ReadLine();
        int percentage = int.Parse(percentageInText);

        string gradeLetter = "";

        if (percentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (percentage >= 80)
        {
            gradeLetter = "B";  
        }
        else if (percentage >= 70)
        {
            gradeLetter = "C";    
        }
        else if (percentage >= 60)
        {
            gradeLetter = "D";        
        }
        else
        {
            gradeLetter = "F"; 
        }

        Console.WriteLine($"Your letter grade is an {gradeLetter}.");

        if (percentage >= 70)
        {
            Console.WriteLine("You have PASSED the class.");
        }
        else
        {
            Console.WriteLine("You have FAILED the class.");
        }

    }
}