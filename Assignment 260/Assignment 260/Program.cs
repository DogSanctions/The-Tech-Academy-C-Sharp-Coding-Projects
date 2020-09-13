using System;

namespace Assignment_260
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 200;
            Console.WriteLine(number.Amount);
        }
        struct Number
        {
            public double Amount;
        }
    }
}
