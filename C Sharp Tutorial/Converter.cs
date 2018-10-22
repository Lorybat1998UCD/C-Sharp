using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class BinaryDecimalConverter
    {
        static void Main(string[] argc)
        {
            Stack<int> v = new Stack<int>();
            Console.WriteLine("Hello! Welcome to the Binary-Decimal converter.\n" +
                "Please select between\n" +
                "\n  1. Decimal to binary" +
                "\n  2. Binary to Decimal");

            string choice = Console.ReadLine();

            if (choice.Equals("1"))
            {
                Console.Write("Enter a Decimal number: ");
                string n = Console.ReadLine();
                int nInt = Convert.ToInt32(n);

                v = DecimalToBinary(nInt, v);

                Console.Write("Binary equivalent of " + n + " is ");
                popStack(v);

                Console.ReadKey();
            }
            else if (choice.Equals("2"))
            {
                Console.Write("Enter a Binary number: ");
                string n = Console.ReadLine();
                int nInt = Convert.ToInt32(n);

                int dec = binaryToDecimal(nInt);

                Console.WriteLine("Decimal equivalent of " + n + " is " + dec);

                Console.ReadKey();
            }

        }

        private static void popStack(Stack<int> v)
        {
            while (v.Count > 0)
            {
                Console.Write(v.Pop());
            }
        }

        private static Stack<int> DecimalToBinary(int n, Stack<int> v)
        {
            while (n > 0)
            {
                int remainder = n % 2;
                n = n / 2;
                v.Push(remainder);
            }
            return v;
        }
        private static int binaryToDecimal(int binary)
        {
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

