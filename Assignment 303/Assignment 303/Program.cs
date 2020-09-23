using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_303
{
    class Program
    {
        static void Main(string[] args)
        {
            const string welcomeSaying = "Welcome to the employee sign up system";
            Console.WriteLine("Hi, {0}", welcomeSaying);
            Console.WriteLine("Please enter your name, address, and your salary. If you haven't been given a different salary, you will be starting at the base salary of 40,000$");
            var userInput = Convert.ToString(Console.ReadLine());

            var employee = new Employee(userInput);
          
        }
    }
}
