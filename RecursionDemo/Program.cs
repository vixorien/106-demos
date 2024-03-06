// Chris Cascioli
// 3/6/24
// Example of recursion

namespace RecursionDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Test out factorials
			Console.WriteLine("Recursive factorials:");
			Console.WriteLine("2! is " + Factorial(2));
			Console.WriteLine("5! is " + Factorial(5));
			Console.WriteLine("10! is " + Factorial(10));
			Console.WriteLine("15! is " + Factorial(15));

			Console.WriteLine();
			Console.WriteLine("Iterative factorials:");
			Console.WriteLine("2! is " + FactorialIterative(2));
			Console.WriteLine("5! is " + FactorialIterative(5));
			Console.WriteLine("10! is " + FactorialIterative(10));
			Console.WriteLine("15! is " + FactorialIterative(15));
		}

		/// <summary>
		/// Calculates a factorial iteratively (with a loop)
		/// </summary>
		/// <param name="n">A non-negative starting value</param>
		/// <returns>The factorial of the starting value</returns>
		static int FactorialIterative(int n)
		{
			int total = 1;

			for (int i = n; i > 1; i--)
			{
				total *= i;
			}

			return total;
		}

		/// <summary>
		/// Calculates a factorial recursively
		/// </summary>
		/// <param name="n">A non-negative starting value</param>
		/// <returns>The factorial of the starting value</returns>
		static int Factorial(int n)
		{
			if (n == 0) { return 1; }
			else if (n > 0)
			{
				return n * Factorial(n - 1);
			}
			else
			{
				// N is less than zero, undefined!
				throw new ArgumentException("Cannot perform factorial on negative numbers!");
			}
		}
	}
}