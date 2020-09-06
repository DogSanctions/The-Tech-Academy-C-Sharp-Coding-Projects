using System;
using System.Collections.Generic;

namespace Assignment_240
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
            };
            obj.SayName();
            IQuittable quittable = new Employee();
            quittable.Quit(obj);
            Console.ReadLine();
        }
    }
}
