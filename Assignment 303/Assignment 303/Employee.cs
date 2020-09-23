using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_303
{
    public class Employee
    {
        public string Name;
        public string Address;
        public int Salary;

        public Employee(string name) : this(name, string.Empty)
        {
        }
        public Employee(string name, string address) : this(name, address, 40000)
        {
        }

        public Employee(string name, string address, int salary)
        {
            this.Name = name;
            this.Address = address;
            this.Salary = salary;
        }
    }
}
