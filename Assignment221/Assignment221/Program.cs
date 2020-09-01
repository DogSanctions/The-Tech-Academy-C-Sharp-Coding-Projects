using System;

namespace Assignment221
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            VoidMethod math = new VoidMethod();
            math.SecretMethod(userInput, userInput2);
        } 
    }
}
