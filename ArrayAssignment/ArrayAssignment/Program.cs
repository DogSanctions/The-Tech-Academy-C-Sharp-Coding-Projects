using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please select a whole number within the values 0-5");
            int indexNumber = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[] { "First string", "Second string", "Third String", "Fourth String", "Fifth String", "Six String" };
            if (indexNumber < 0 || indexNumber > 5)
            {
                Console.WriteLine("Please enter a number, 0-5");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(stringArray[indexNumber]);
                Console.ReadLine();
            }

            Console.WriteLine("Please select a whole number with the values 0-10");
            int numIndex = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[] { 5, 10, 20, 40, 80, 160, 320, 640, 1280, 2560, 5120 };
            if (numIndex < 0 || numIndex > 10)
            {
                Console.WriteLine("Please enter a number, 0-10");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(numArray[numIndex]);
                Console.ReadLine();
            }

            Console.WriteLine("Pick a number 0-5, please.");
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            List<string> stringList = new List<string>();
            stringList.Add("This is a funny joke");
            stringList.Add("This is a not so funny joke");
            stringList.Add("This is a mediocre joke");
            stringList.Add("Crickets");
            stringList.Add("The fans threw tomatoes");
            if (stringIndex < 0 || stringIndex > 5)
            {
                Console.WriteLine("Enter a number, 0-5");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(stringList[stringIndex]);
                Console.ReadLine();
            }


        }
    }
}
