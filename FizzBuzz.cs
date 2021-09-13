using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FizzBuzz
{
	public class Program
	{
		public static void Main(string[] args)
		{
			for(int i = 1; i < 200; i++)
			{
				String myStringGame = "";
				if (i % 3 == 0)
				{
					myStringGame += "Fizz";
					
				}
				
				if (i % 5 == 0)
				{
					myStringGame += "Buzz";
				}
				if (i % 7 == 0)
				{
					myStringGame += "Bang";
				}
				
				if (i % 13 == 0)
				{
					myStringGame += "Fezz";
					
					if (i % 11 == 0)
					{
						myStringGame = "FezzBong";
					}
					
				}

				if (i % 11 == 0 && i % 13 != 0)
				{
					myStringGame = "Bong";
				}
				
				
				if (i % 17 == 0)
				{
					List<string> fizzyBuzz = new List<string>(Regex.Split(myStringGame, @"\s+"));
					fizzyBuzz.Reverse();
					myStringGame = string.Join("" + fizzyBuzz);
				}
				
				if (myStringGame.Length == 0)
				{
					myStringGame = i.ToString();	
				}
				
				
				Console.WriteLine(myStringGame);
			}
		}
	}
}
