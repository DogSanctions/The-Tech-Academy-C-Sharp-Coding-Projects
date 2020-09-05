using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment_240
{
    public class Employee : Person
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine("one of your employees has quit.");
        }
    }
}
