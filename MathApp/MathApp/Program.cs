using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int pNum = 50;
            int product = favNum * pNum;
            Console.WriteLine("Your favorite number times 50 equals " + product);
            Console.ReadLine();
            Console.WriteLine("How old are you?");
            string yearsOld = Console.ReadLine();
            int yrsOld = Convert.ToInt32(yearsOld);
            int aNum = 25;
            int total = yrsOld + aNum;
            Console.WriteLine("Your current age plus 25 equals " + total);
            Console.ReadLine();
            Console.WriteLine("Give a number that ends with 0");
            string dividedNumber = Console.ReadLine();
            int divNum = Convert.ToInt32(dividedNumber);
            double dNum = 12.5;
            double quotient = divNum / dNum;
            Console.WriteLine("The number you gave divided by 12.5 equals " + quotient);
            Console.ReadLine();
            Console.WriteLine("Write your pets age");
            string petAge = Console.ReadLine();
            int pAge = Convert.ToInt32(petAge);
            int gNum = 50;
            bool trueOrFalse = pAge > gNum;
            Console.WriteLine("Your pet is older than 50 " + trueOrFalse.ToString());
            Console.ReadLine();
            Console.WriteLine("Type a number");
            string modulusNumber = Console.ReadLine();
            int modNum = Convert.ToInt32(modulusNumber);
            int diNum = 7;
            int remainder = modNum % diNum;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
