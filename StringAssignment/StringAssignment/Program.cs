using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "this is the first sentence/string.\" \"this is the second sentence/string.\"\"this is the third sentence/string.";
            sentence = sentence.ToUpper();
            Console.WriteLine(sentence);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("Welchs fruit snaks are my favorite fruit snacks.");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append("They have a lot of different flavors, but best of all.");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append("They don't have any grape flavored gummies!");
            Console.WriteLine(sb);
            Console.ReadLine();
            sb.Append("Grape is the worst flavoring out of all the flavors.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
