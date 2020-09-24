using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment307
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter how old you are.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int todaysTime = DateTime.Today.Year;
                if (userInput <= 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    var ageFinder = todaysTime - userInput;
                    Console.WriteLine(ageFinder);
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter numbers when entering your entering your correct age.");
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter the correct numbers for your age.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter in your correct age.");
                Console.ReadLine();
            }
        }
    }
}
