﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_240
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual string SayName()
        {
            return "Name: " + firstName + " " + lastName;
        }
    }
}
