using System;
using System.Collections.Generic;

namespace Assignment229
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
            };
            Employee em = new Employee();
            obj.SayName();
            em.EmployeeID();
        }
    }
}
