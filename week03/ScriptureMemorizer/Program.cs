using System;

class Program
{
    static void Main(string[] args)
    {
        if (File.Exists("scriptures.txt"))
        {
            string[] scriptures = File.ReadAllLines("scriptures.txt");

            foreach (string entry in scriptures)
            {
                Console.WriteLine(entry);
            }
        } else {
            Console.WriteLine("No Scripture File Exists");
        }
    }
}