using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            int uAge = Convert.ToInt32(userAge);
            int minAge = 15;
            bool overAge = uAge >= minAge;
            Console.WriteLine("Have you ever had a DUI or DUII? Please answer true or false");
            string dQuest = Console.ReadLine();
            bool condition = Convert.ToBoolean(dQuest);
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketNumber = Console.ReadLine();
            int ticNum = Convert.ToInt32(ticketNumber);
            int maxTic = 3;
            Console.WriteLine("Qualify?");
            if (overAge && !condition && ticNum < maxTic)
            {
                Console.WriteLine("Congrats you qualify!");
            }
            else
            {
                Console.WriteLine("I'm sorry but you do not qualify to purchase car insurance from this company.");
            }
            Console.Read();
        }
    }
}
