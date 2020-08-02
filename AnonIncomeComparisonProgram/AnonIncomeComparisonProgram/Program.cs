using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AnonIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate?");
            string person1Rate = Console.ReadLine();
            int p1Rate = Convert.ToInt32(person1Rate);
            Console.WriteLine("Hours worked per week?");
            string person1Week = Console.ReadLine();
            int p1Week = Convert.ToInt32(person1Week);
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate?");
            string person2Rate = Console.ReadLine();
            int p2Rate = Convert.ToInt32(person2Rate);
            Console.WriteLine("Hours worked per week?");
            string person2Week = Console.ReadLine();
            int p2Week = Convert.ToInt32(person2Week);
            Console.WriteLine("Annual salary of Person 1:");
            double product = p1Rate * p1Week * 52.143;
            Console.WriteLine(product);
            Console.WriteLine("Annual salary of Person 2:");
            double product2 = p2Rate * p2Week * 52.143;
            Console.WriteLine(product2);
            Console.WriteLine("Does Person 1 make more money than Person 2");
            bool trueOrFalse = product > product2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.Read();
        }
    }
}
