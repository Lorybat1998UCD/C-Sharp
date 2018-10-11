using System;
namespace C_Sharp_Tutorial
{
	public class PalindromeChecker
	{
		public static void Palindrome(string p)
		{
			//Gather data
			//string inString = inputString();

			//Computation
			CheckPalindrome(p);

			//Output
			
			Console.ReadKey();
		}

		static string inputString()
		{
			Console.WriteLine("Enter a string or a number below.");
			string inString = Console.ReadLine();
			return inString;
		}


		//palindromic boolean value;

		static void CheckPalindrome(string value)
		{
			int max = value.Length - 1;
			int min = 0;
			while (min <= max)
			{
				char a = value[min];
				char b = value[max];

				if (char.ToLower(a) != char.ToLower(b))
				{
					Output(false);
				}
				
				min++;
				max--;
			}
			Output(true);
		}

		private static void Output(bool palindromic)
		{
			if (palindromic)
				Console.WriteLine("Input is palindromic.");
			else
				Console.WriteLine("Input is not palindromic.");

			Console.ReadKey();
			Environment.Exit(2);
		}
	}
}
