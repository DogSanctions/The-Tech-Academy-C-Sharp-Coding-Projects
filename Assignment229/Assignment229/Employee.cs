using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Assignment229
{
    public class Employee : Person
    {
        public void EmployeeID()
        {
            System.Random random = new System.Random();
            System.Console.WriteLine(random.Next(1, 5000));
        }
    }
}
