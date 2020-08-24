using HandlingAssignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to do a math operation on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            var Ops = new MathOps();
            Console.WriteLine();
            Console.WriteLine(Ops.AddFour(userInput));
            Console.WriteLine();
            Console.WriteLine(Ops.SubTen(userInput));
            Console.WriteLine();
            Console.WriteLine(Ops.MultiNine(userInput));
            Console.ReadLine();
        }
    }
}
