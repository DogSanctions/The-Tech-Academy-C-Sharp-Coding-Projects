using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a food");
            string userInput = Convert.ToString(Console.ReadLine());
            string[] stringArray = new string[] { "Pizza", "Sushi", "Tacos", "Ice Cream", "Doughnuts", "Steak", "Chicken Shwarma" };
            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                var userstring = userInput + stringArray[i];
                stringArray[i] = userstring;
            }
            Console.ReadLine();
            foreach (string food in stringArray)
            {
                Console.WriteLine(food);
            }
            Console.ReadLine();

            Console.WriteLine("Please enter a fruit.");
            string userSearch = Convert.ToString(Console.ReadLine());
            List<string> funkyFruit = new List<string>() { "Kiwi", "Pineapple", "Watermelon", "Strawberry", "Peach", "Pear", "Apple", "Banana", "Blueberry", "Grapefruit", "Raspberry" };
            var found = false;
            for (int i = 0; i < funkyFruit.Count; i++)
            {
                if (userSearch == funkyFruit[i])
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }         
            if (!found)
            {
                Console.WriteLine("Please enter a different fruit or try capitalizing it");
            }
            Console.ReadLine();

            List<string> sportsList1 = new List<string>() { "Basketball", "Volleyball", "Baseball", "Football", "Soccer", "Tennis", "Hockey" };
            List<string> sportsList2 = new List<string>() { "Baseball", "Volleyball", "Basketball", "Football", "Baseball", "Tennis", "Hockey", "Soccer", "Temmis" };
            foreach (var item in sportsList1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine("Please enter your favorite sport from the given list.");
            string searchKey = Convert.ToString(Console.ReadLine());
            var s = 0;
            bool stateFound = false;
            while (s < sportsList2.Count)
            {
                if (searchKey == sportsList2[s])
                {
                    stateFound = true;
                    Console.WriteLine(s);
                }
                s++;
            }
            if (stateFound == false)
            {
                Console.WriteLine("Sorry, You entered the text incorrectly. Please try again");
            }
            Console.ReadLine();

            List<string> snackList = new List<string>() { "Goldfish", "Apple Slices", "Pretzels", "Goldfish", "Graham Crackers", "Fruit Snacks", "Celery" };
            List<string> snackList2 = new List<string>() { };
            foreach (var item in snackList)
            {
                Console.WriteLine(item);
                if (!snackList2.Contains(item))
                {
                    snackList2.Add(item);
                }
                else
                {
                    Console.WriteLine("This item is a duplicate");
                }
            }
            Console.ReadLine();
        } 
    }
}
