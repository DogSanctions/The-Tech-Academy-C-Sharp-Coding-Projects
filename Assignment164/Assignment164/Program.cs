using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations;

namespace Assignment164
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a integer you would like to see some math operations done on.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            var Ops = new MathOps();
            Console.WriteLine();
            Console.WriteLine(Ops.AddTen(userInput));
            Console.WriteLine();
            Console.WriteLine(Ops.SubTwo(userInput));
            Console.WriteLine();
            Console.WriteLine(Ops.MultiEight(userInput));
            Console.WriteLine();
            Console.WriteLine(Ops.DivideTwelve(userInput));
            Console.WriteLine();
            Console.WriteLine("Please enter another number to do some operations on, but this time please make it a decimal");
            double userInput2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(Ops.dAddFive(userInput2));
            Console.WriteLine();
            Console.WriteLine(Ops.dSubFour(userInput2));
            Console.WriteLine();
            Console.WriteLine(Ops.dModularSixteen(userInput2));
            Console.ReadLine();
            Console.WriteLine("Please enter a number");
            string userInput3 = Convert.ToString(Console.ReadLine());
            try
            {
                int strVal = Int32.Parse(userInput3);
                Console.WriteLine(Ops.sMultiNine(strVal));
            } 
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
