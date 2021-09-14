using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Email_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Corndel\Email Extraction\sample.txt").Replace(Environment.NewLine, " ");
            string pattern = @"@softwire.com ";

            if (Regex.Match(pattern, input).Success)
            {
                Console.WriteLine("works");
            }

            int counter = Regex.Matches(input, pattern).Count;



            /*
            for (int i = 0; input.Length < i; i++)
            {
                if (input.Substring(i, 13) == "@softwire.com")
                {
                    counter++;
                }
            }
            */



           
         
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}