using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight: ");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            int packOverWeight = 50;
            if (packWeight <= packOverWeight)
            {
                Console.WriteLine("Your package weighs " + packWeight + " Pounds");
            }
            else if (packWeight > packOverWeight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                System.Environment.Exit(0);
            }
            Console.ReadLine();
            Console.WriteLine("Please enter the package width: ");
            int packWidth = Convert.ToInt32(Console.ReadLine());
            int packOverWidth = 50;
            if (packWidth <= packOverWidth)
            {
                Console.WriteLine("Your package width is " + packWidth + " inches");
            }
            else if (packWidth > packOverWidth)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day!");
                System.Environment.Exit(0);
            }
            Console.ReadLine();
            Console.WriteLine("Please enter the package height: ");
            int packHeight = Convert.ToInt32(Console.ReadLine());
            int packOverHeight = 50;
            if (packHeight <= packOverHeight)
            {
                Console.WriteLine("Your package height is  " + packHeight + " inches");
            }
            else if (packHeight > packOverHeight)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day!");
                System.Environment.Exit(0);
            }
            Console.ReadLine();
            Console.WriteLine("Please enter the package length: ");
            int packLength = Convert.ToInt32(Console.ReadLine());
            int packOverLength = 50;
            if (packLength <= packOverLength)
            {
                Console.WriteLine("Your package length is " + packLength + " inches");
            }
            else if (packLength > packOverLength)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day!");
                System.Environment.Exit(0);
            }
            Console.ReadLine();
            float product = ((packWidth * packLength * packHeight) * packWeight);
            Console.WriteLine("Your estimated total for shipping this package is: $" + product);
            Console.ReadLine();
        }
    }
}
