using System;
using System.Net.Http.Headers;

namespace Operations
{
    public class MathOps
    {
        public int AddTen(int num)
        {
            return num + 10;
        }

        public int AddTen(decimal num)
        {
            return Convert.ToInt32(num + 10);
        }

        public int AddTen(string num)
        {
            try
            {
                int strVal = Int32.Parse(num);
                return strVal + 10;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }
    }
}
