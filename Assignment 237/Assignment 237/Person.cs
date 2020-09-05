using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_237
{
    public abstract class Person
    {
      public string firstName { get; set; }
      public string lastName { get; set; }
      
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
