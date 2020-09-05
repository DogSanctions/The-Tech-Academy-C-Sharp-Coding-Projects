using System;

namespace Assignment_237
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
        }
    }
}
