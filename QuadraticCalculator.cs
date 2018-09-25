using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial{
	class Program{
		static void Main(string[] args)
		{

			List<String> clean = getQuadratic(out List<string> names);
			Boolean quadratic = IsQuadratic(clean, names);
			string xTerm = "0";
			if (!quadratic)
				Console.WriteLine("The equation you have entered is not of the form aX^2 + bX + C. Verify that you have typed it well and try again.");
			int a, b, c;
			xTerm = convertInput(names, xTerm, out a, out b, out c);
			double determinant = Math.Pow(b, 2) - (4 * a * c);

			if (determinant < 0)
				Console.WriteLine("The equation has irrational roots. Please try another equation");
			else
			{
				Compute(a, b, determinant);
			}
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		private static void Compute(int a, int b, double determinant)
		{
			double posRoot = (b + Math.Sqrt(determinant)) / (2 * a);
			double negRoot = (b + Math.Sqrt(determinant)) / (2 * a);

			Console.WriteLine("First Root is   X = " + posRoot);
			Console.WriteLine("Second Root is  X = " + negRoot);
		}

		private static string convertInput(List<string> names, string xTerm, out int a, out int b, out int c)
		{
			if (names.Count > 5)
				xTerm = names.ElementAt(3);

			a = Convert.ToInt32(names.ElementAt(0));
			b = Convert.ToInt32(xTerm);
			c = Convert.ToInt32(names.Last());
			return xTerm;
		}

		private static bool IsQuadratic (List<string> clean, List<string> names)
		{
			for (int i = 0; i < names.Count; i++)
				if (clean.ElementAt(i).Equals("^2"))
					return true;
			return false;
		}

		private static List<String> getQuadratic(out List<string> names)
		{
			Console.Write("Enter your equation here: ");
			string equation = Console.ReadLine();

			string noLettersEquation = Regex.Replace(equation, "[A-Za-z]", " ");
			names = noLettersEquation.Split(' ').ToList<string>();
			return names;
		}
	}
}
