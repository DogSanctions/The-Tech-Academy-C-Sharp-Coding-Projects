using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparisonAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess how much the avg american spends on gas?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 368;

            do
            {
                switch (number)
                {
                    case 200:
                        Console.WriteLine("You guessed $200");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 120:
                        Console.WriteLine("You $120, you're on the right track!");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 40:
                        Console.WriteLine("You guessed 40$. Very cold.");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 368:
                        Console.WriteLine("Congrats you guessed the correct amount spent on avg every year!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You guessed wrong. Try googling it. Hint: its not past 400$ or below $100");
                        Console.WriteLine("Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.Read();
        }
    }
}
