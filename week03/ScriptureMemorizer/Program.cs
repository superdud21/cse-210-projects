using System;

class Program
{
    static void Main(string[] args)
    {
        if (File.Exists("scriptures.txt"))
        {
            string[] scriptures = File.ReadAllLines("scriptures.txt");

            while (true)
            {

            }
        } else {
            Console.WriteLine("No Scripture File Exists");
        }
    }
}