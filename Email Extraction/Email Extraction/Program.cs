using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace Email_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Corndel\Email Extraction\sample.txt");
            string pattern = @"@softwire.com ";
            string domain = @"@";

            if (Regex.Match(pattern, input).Success)
            {
                Console.WriteLine("works");
            }

            int counter = Regex.Matches(input, pattern).Count;

            //Dictionary<string, Int16> domains = new Dictionary<string, Int16>();

            //Understanding Dictionary
            
            
            var splitWord = input.Split(' '); // Collects the string
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>(); // looks for the repeated words by making dictionary
            for (int i = 0; i < splitWord.Length; i++)// checks the length of a string
            {
                if (Regex.IsMatch(domain, splitWord[i]))
                {
                    if (RepeatedWordCount.ContainsKey(splitWord[i]))
                    {
                        int value = RepeatedWordCount[splitWord[i]];
                        RepeatedWordCount[splitWord[i]] = value + 1;
                    }
                    else
                    {
                        RepeatedWordCount.Add(splitWord[i], 1);
                    }
                }      
            }



            foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
            {
                Console.WriteLine("{0} has {1} other of the same name", kvp.Key, kvp.Value);
            }

            Console.Read();

            //END




            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}