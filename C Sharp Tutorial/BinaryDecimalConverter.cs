using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
	class BinaryDecimalConverter
	{
		private const int X = 16;

		static void Main(string[] argc)
		{
			Stack<int> v = new Stack<int>();
			Stack<string> s = new Stack<string>();
			Console.WriteLine("Hello! Welcome to the Binary-Decimal converter.\n" +
				"Please select between\n" +
				"\n  1. Decimal to binary" +
				"\n  2. Binary to Decimal" +
				"\n  3. Decimal to Hexadecimal" +
				"\n  4. Hexadecimal to Decimal" +
				"\n  5. Binary to Hexadecimal" +
				"\n  6. Hexadecimal to Binary");

			string choice = Console.ReadLine();
			int choiceInt = Convert.ToInt32(choice);
			switch (choiceInt)
			{
				case 1: //decimal to binary
					Console.Write("Enter a Decimal number: ");
					string n = Console.ReadLine();
					

					v = DecimalToBinary(n);

					Console.Write("Binary equivalent of " + n + " is ");
					PopStack(v);

					Console.ReadKey();
					break;

				case 2: //binary to decimal
					Console.Write("Enter a Binary number: ");
					n = Console.ReadLine();

					int dec = BinaryToDecimal(n);

					Console.WriteLine("Decimal equivalent of " + n + " is " + dec);

					Console.ReadKey();
					break;

				case 3: //decimal to hexadecimal
					n = Console.ReadLine();
					
					s = DecimalToHex(n);
					Console.Write("Hexadecimal equivalent of " + n + " is ");

					while (s.Count > 0)
						Console.Write(s.Pop());
					break;

				case 4: //hexadecimal to decimal

					n = Console.ReadLine();
					int decNumber = HexToDecimal(n);
					Console.WriteLine("Decimal equivalent of " + n + " is " + decNumber);
					break;

				case 5: //binary to hex
					n = Console.ReadLine();
					int tempDecimal = BinaryToDecimal(n);
					s = DecimalToHex(tempDecimal.ToString());
					Console.Write("Hex equivalent of " + n + " is " );
					while (s.Count >0)
						Console.Write(s.Pop());
					break;

				case 6: //hex to binary
					n = Console.ReadLine();
					decNumber = HexToDecimal(n);
					v = DecimalToBinary(decNumber.ToString());
					Console.Write("Binary equivalent of " + n + " is ");
					while (v.Count > 0)
						Console.Write(s.Pop());
					break;
			}
		}

		private static int HexToDecimal(string n)
		{
			int intN = (int) Convert.ToInt64(n, 16);
			int remainder=0, decimal_number = 0;
			for (int count = 0; intN > 0; count++)
			{
				remainder = intN % 10;
				decimal_number = decimal_number + (remainder * (int) Math.Pow(X, count));
				intN = intN / 10;
			}
			return intN;

		}


		/*public string octal_to_decimal(string m_value)
		{
			int i, j, x = 0;
			Int64 main_value;
			int k = 0;
			bool pw = true, ch;
			int position_pt = m_value.IndexOf(".");
			if (position_pt == -1)
			{
				main_value = Convert.ToInt64(m_value);
				ch = false;
			}
			else
			{
				main_value = Convert.ToInt64(m_value.Remove(position_pt, m_value.Length - position_pt));
				ch = true;
			}

			while (k <= 1)
			{
				do
				{
					i = (int) main_value % 10;                                        // Return Remainder
					i = i * Convert.ToInt32(Math.Pow(8, x));                   // calculate power
					if (pw)
						x++;
					else
						x--;
					main_value = main_value + i;                                       // Saving Required calculated value in main variable
					main_value = main_value / 10;                               // Dividing the main value 
				}
				while (main_value >= 1);
				if (ch)
				{
					k++;
					main_value = Convert.ToInt64(Reversestring(m_value.Remove(0, position_pt + 1)));
				}
				else
					k = 2;
				pw = false;
				x = -1;
			}
			return (Convert.ToString(o_to_d));
		}*/

		private static Stack<string> DecimalToHex(string n)
		{
			int nInt = Convert.ToInt32(n);

			Stack<string> s = new Stack<string>();
			while (nInt > 0)
			{

				int remainder = nInt % 16;
				
				nInt /= 16;
				switch (remainder) {
					case 10:
						s.Push("A");
						break;
					case 11:
						s.Push("B");
						break;
					case 12:
						s.Push("C");
						break;
					case 13:
						s.Push("D");
						break;
					case 14:
						s.Push("E");
						break;
					case 15:
						s.Push("F");
						break;
					default:
						string r = Convert.ToString(remainder);
						s.Push(r);
						break;
				}
			}
			return s;
		}

		private static void PopStack(Stack<int> v)
		{
			while (v.Count > 0)
				Console.Write(v.Pop());
		}

		private static Stack<int> DecimalToBinary(string n)
		{
			int nInt = Convert.ToInt32(n);
			Stack<int> v = new Stack<int>();

			while (nInt > 0)
			{
				int remainder = nInt % 2;
				nInt /= 2;
				v.Push(remainder);
			}
			return v;
		}
		private static int BinaryToDecimal(string n)
		{
			int binary = Convert.ToInt32(n);
			int dec = 0, i = 0, remainder;
			while (binary != 0)
			{
				remainder = binary % 10;
				binary /= 10;
				dec += remainder * (int)Math.Pow(2, i);
				i++;
			}
			return dec;
		}
	}
}
	
