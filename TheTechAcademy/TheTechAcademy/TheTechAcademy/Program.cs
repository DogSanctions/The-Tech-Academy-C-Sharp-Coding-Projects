using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report:");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You're on the course for " + courseName);
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int paNum = Convert.ToInt32(pageNumber);
            int page = paNum;
            Console.WriteLine("You're on page number: " + page);
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string helpStatus = Console.ReadLine();
            Console.WriteLine("Help Status: " + helpStatus);
            Console.WriteLine("Were thera any positive feedback you'd like to provide? Please give specifics.");
            string positiveFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for the positive feedback" + positiveFeedback);
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string neutralFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for the feedback we will take it into consideration for future students." + neutralFeedback);
            Console.WriteLine("How many hours did you study today? Round to nearest hour.");
            string hoursStudy = Console.ReadLine();
            int hoStu = Convert.ToInt32(hoursStudy);
            int hours = hoStu;
            Console.WriteLine("Congrats on studying for that many hours! Keep it up! " + hours);
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.Read();
        }
    }
}
