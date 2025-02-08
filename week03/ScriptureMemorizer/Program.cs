using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> _scriptures = new List<Scripture>();

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