using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int enteredNumber = -1;

        while (enteredNumber != 0)
        {
            Console.WriteLine("Enter a number: ");
            
            enteredNumber = int.Parse(Console.ReadLine());

            if (enteredNumber != 0)
            {
                numbers.Add(enteredNumber);
            }
        }

        int sumOfNumbers = 0;
        int maxOfNumbers = numbers[0];

        foreach (int number in numbers)
        {
            sumOfNumbers += number;
        }

        float averageOfNumbers = (float) sumOfNumbers / numbers.Count;


        foreach (int number in numbers)
        {
            if (number > maxOfNumbers)
            {
                maxOfNumbers = number;
            }
        }
        
        Console.WriteLine($"The sum of the numbers is {sumOfNumbers}");
        Console.WriteLine($"The average of numbers is {averageOfNumbers}");
        Console.WriteLine($"The max number is {maxOfNumbers}");

    }
}