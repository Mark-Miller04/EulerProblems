using System;

using MMNet.CSh.ConsoleApp;
using MMNet.CSh.StringMM;

namespace EulerProject.Problems
{
	class Problem4 : BaseProblem
	{
		public Problem4()
		{
			_id = 4;
			_tit = "Largest Palindrome Product";
			_que = "What is the largest palindromic number made from the product of two 3-digit numbers?";
			_pro = "Please enter a three digit integer.";
			_eff = BigO.Undetermined;
		}

		protected override void Solve()
		{
			int one = Input.RequestInt(Prompt, 100, 999);
			int two = Input.RequestInt(Prompt, 100, 999);
			int prod = one * two;
			string str = prod.ToString();
			string rev = StringManip.Reverse(str);

			Console.WriteLine($"The product of {one} and {two} is {prod}.");
			if (str == rev) {
				Console.WriteLine($"{prod} is a palindromic number, read the same both forwards and backwards.");
			}
			else {
				Console.WriteLine($"{prod} read backwards is {rev}, and is therefore not a palindromic number.");
			}

			if (Input.RequestYN("Would you like to calculate the largest palindromic number that is the product of two 3-digit numbers?"))
			{
				int count = 0;
				ulong high = 0;
				for(uint i = 100; i < 1000; i++) {
					for(uint j = i; j < 1000; j++) {
						uint p = i * j;
						string s = p.ToString();
						string r = StringManip.Reverse(s);
						if (s == r) {
							count++;
							if (p > high) {
								high = p;
							}
						}
					}
				}

				Clear();
				Console.WriteLine($"There are {count} palindromic products that exist when multiplying two 3-digit numbers together.");
				Console.WriteLine($"The largest one is {high}");
			}

		}
	}
}
