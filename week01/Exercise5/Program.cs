using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string firstName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int square = SquareNumber(favoriteNumber);
        DisplayResults(firstName, square); 
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number: ");  
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber; 
    }
    static int SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;

        return square;
    }
    static void DisplayResults(string firstName, int square)
    {
        Console.WriteLine($"{firstName}, the square of your number is {square}");
    }
}