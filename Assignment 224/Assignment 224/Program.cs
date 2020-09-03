using System;

namespace Assignment_224
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            VoidMethod math = new VoidMethod();
            math.DivideMethod(userInput);
            Console.WriteLine("Please enter a number");
            float userInput2 = Convert.ToInt32(Console.ReadLine());
            math.DivideMethod(userInput2);
            Console.WriteLine("Please enter a number");
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            StaticClass.OutputPara(userInput3); 
        }
    }
}
