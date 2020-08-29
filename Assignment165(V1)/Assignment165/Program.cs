using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Assignment165
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a integer");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second integer, this is optional.");
            string userInput2 = Console.ReadLine();
            MathOps Ops = new MathOps();
            if (userInput2 != " ")
            {
                int userInput3 = Int32.Parse(userInput2);
                Console.WriteLine(Ops.DualOptParameter(userInput, userInput3));
            }
            else
            {
                Console.WriteLine(Ops.DualOptParameter(userInput));
                Console.ReadLine();
            }
        }
    }
}