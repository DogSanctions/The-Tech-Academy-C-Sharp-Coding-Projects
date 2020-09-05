using System;
using System.Collections.Generic;

namespace Assignment_240
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
            };
            obj.SayName();
            Employee employee = new Employee()
            {                
            };
            employee.Quit(employee);
        }
    }
}
