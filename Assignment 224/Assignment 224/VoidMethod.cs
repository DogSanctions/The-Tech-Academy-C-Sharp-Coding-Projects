using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Assignment_224
{
    public class VoidMethod
    {
        public void DivideMethod(int num) 
        {
            int result = num / 2;
            Console.WriteLine(result);
        }
        public void DivideMethod(float num1)
        {
            float result1 = num1 * 3;
            Console.WriteLine(result1);
        }
    }
    public static class StaticClass
    {
        public static void OutputPara(int num2)
        {
            int intialParameter = num2;
            OutIntialParameter(out intialParameter);
            Console.WriteLine(intialParameter);
        }
        static void OutIntialParameter(out int num2)
        {
            num2 = 44;
        }
    }
}
