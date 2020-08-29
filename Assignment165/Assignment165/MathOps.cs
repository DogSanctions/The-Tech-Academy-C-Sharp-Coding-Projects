using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Assignment165
{
    public class MathOps
    {
        public int DualOptParameter(int num1, string optionalint)
        {
            if (optionalint == " ")
            {
                int num2 = 10;
                return num1 + num2;
            }
            else
            {
                return num1 + Convert.ToInt32(optionalint);
            }
        }
    }
}

