using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment_240
{
    public class Employee : Person, IQuittable
    {
        public override string SayName()
        {
            return base.SayName();
        }
        public void Quit(Employee employee)
        {
            
            Console.WriteLine(employee.SayName() + " " + "has quit");
        }
    }
}
