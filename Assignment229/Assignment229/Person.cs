﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment229
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: " +  FirstName + " " + LastName);
        }
    }
}
