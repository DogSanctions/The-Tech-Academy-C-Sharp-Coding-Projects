using System;
using System.Collections.Generic;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numberList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
                Console.WriteLine("Enter a number to divide the list by.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberList.Count; i++)
                {
                    Console.WriteLine(numberList[i] / userInput);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
