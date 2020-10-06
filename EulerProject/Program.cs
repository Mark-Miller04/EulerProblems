using System;
using UtilityLibrary;


// TODO: Add safe ways to accept any user input for all programs.

namespace EulerProject
{
	class Program
	{
		public static string[] programList = {
			"1: Multiples of 3 and 5.",
			"2: Even Fibonacci Numbers."
		};

		static void Main(string[] args)
		{
			WriteProgramList();
			int prog = SelectProgram();

			switch(prog)
			{
				case 1:
					Problem1();
					break;
				case 2:
					Problem2();
					break;
				case 0:
				default:
					Console.WriteLine("Uncaught error in program selection.");
					break;
			}
		}

		private static void WriteProgramList()
		{
			Console.WriteLine("===== Program List =====\n");
			for(int i = 0; i < programList.Length; i++) {
				Console.WriteLine(programList[i]);
			}
			Console.WriteLine("=======================\n");
		}

		private static int SelectProgram()
		{
			int ret = 0;
			while (ret <= 0 || ret > programList.Length)
			{
				Console.WriteLine("Please enter a valid number from the list of programs.");
				try {
					ret = StringUtils.StringToInt(Console.ReadLine());
					if (ret <= 0 || ret > programList.Length) {
						throw new ArgumentOutOfRangeException();
					}
				}
				catch (Exception e) {
					Console.Clear();
					WriteProgramList();
					Console.WriteLine(e.Message);
				}
			}

			return ret;
		}

		private static void Problem1()
		{
			Console.Clear();
			Console.WriteLine("===== Problem 1 =====");
			Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.\n");

			int sum = 0;
			int x = 3;
			while(x < 1000) {
				sum += x;
				x += 3;
			}

			x = 5;
			while(x < 1000) {
				if (x % 3 != 0) {
					sum += x;
				}

				x += 5;
			}

			Console.WriteLine($"The sum of all multiples of 3 or 5 below 1000 is {sum}.");
		}

		private static void Problem2()
		{
			Console.Clear();
			Console.WriteLine("===== Problem 2 =====");
			Console.WriteLine("Find the sum of all even Fibonacci numbers that are less than 4 million.\n");

			int sum = 0;
			int last = 0;
			int current = 1;
			while (current < 4000000)
			{
				if (current % 2 == 0) {
					sum += current;
				}

				int temp = current;
				current += last;
				last = temp;
			}

			Console.WriteLine($"The sum of these numbers is {sum}.");
		}
	}
}
