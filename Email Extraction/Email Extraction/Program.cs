using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace Email_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Corndel\Email Extraction\sample.txt");
            string pattern = @"\w+@\w+\.[^@\s]+";
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>(); // looks for the repeated words by making dictionary

            foreach (var email in Regex.Matches(input, pattern))
            {
                
                var splitEmail = email.ToString().Split('@');
                var domain = splitEmail[1];
                
                if (RepeatedWordCount.ContainsKey(domain))
                {
                    int value = RepeatedWordCount[domain];
                    RepeatedWordCount[domain] = value + 1;
                }
                else
                {
                    RepeatedWordCount.Add(domain, 1);
                }
            }

            int counter = Regex.Matches(input, pattern).Count;
            Console.WriteLine(counter);


            var items = from pair in RepeatedWordCount
                        orderby pair.Value descending
                        select pair;

            //Understanding Dictionary

            var splitWord = input.Split(' '); // splits the string from after the domain

            foreach (KeyValuePair<string, int> kvp in items)
            {
                Console.WriteLine("{0} has {1} other of the same name", kvp.Key, kvp.Value);
            }

            Console.Read();

            



            //END

            //stuck



            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}