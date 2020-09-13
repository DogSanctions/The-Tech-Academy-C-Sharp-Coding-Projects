using System;
using System.Collections.Generic;

namespace Assignment_248
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            Employee<int> employee2 = new Employee<int>();
            employee.things = new List<string>() { "Abby", "Blake", "Georgie"};
            employee2.things = new List<int>() { 3, 33, 333 };

            foreach (var thing in employee.things)
            {
                Console.WriteLine(thing);
            }
            foreach(var thing1 in employee2.things)
            {
                Console.WriteLine(thing1);
            }

        }
    }
}
