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
            MathOps Ops = new MathOps();
            Console.WriteLine();
            Console.WriteLine(Ops.AddTen(userInput));
            Console.ReadLine();
            Console.WriteLine("Please enter another number to do some operations on, but this time please make it a decimal");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            MathOps Ops2 = new MathOps();
            Console.WriteLine();
            Console.WriteLine(Ops2.AddTen(userInput2));
            Console.ReadLine();
            Console.WriteLine("Please enter a number");
            string userInput3 = Console.ReadLine();
            MathOps Ops3 = new MathOps();
            Console.WriteLine(Ops3.AddTen(userInput3));
            Console.ReadLine();
        }
    }
}
