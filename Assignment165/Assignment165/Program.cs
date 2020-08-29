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
            Console.WriteLine(Ops.DualOptParameter(userInput, userInput2));
        }
    }
}