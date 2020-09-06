using System;

namespace Assignment_245
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = "Joe";
            employee.lastName = "Stevens";
            employee.ID = 33321;

            Employee employee1 = new Employee();
            employee1.firstName = "Lulu";
            employee1.lastName = "Lemons";
            employee1.ID = 22219;

            Console.WriteLine(employee.Equals(employee1));
            Console.ReadLine();
        }
    }
}
