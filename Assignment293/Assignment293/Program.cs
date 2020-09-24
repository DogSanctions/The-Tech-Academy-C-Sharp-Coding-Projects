using System;

namespace Assignment293
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime todaysTime = DateTime.Now;
            DateTime usersChange = todaysTime.AddHours(userInput);
            Console.WriteLine(usersChange);
            Console.ReadLine();
            
        }
    }
}
