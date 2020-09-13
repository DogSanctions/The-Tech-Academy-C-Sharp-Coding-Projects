using System;

namespace Assignment_254
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week, please.");
            try
            {
                Days userInput = (Days)Enum.Parse(typeof(Days), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
