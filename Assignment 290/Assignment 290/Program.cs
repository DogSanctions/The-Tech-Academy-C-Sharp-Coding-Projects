using System;
using System.IO;

namespace Assignment_290
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userInput = Convert.ToString(Console.ReadLine());
            File.WriteAllText("C:\\Users\\Jared\\source\\repos\\Assignment 290\\logs.txt", userInput);
            using (StreamReader file = new StreamReader("C:\\Users\\Jared\\source\\repos\\Assignment 290\\logs.txt", true))
            {
                Console.WriteLine(file.ReadToEnd());
            }
        }
    }
}
