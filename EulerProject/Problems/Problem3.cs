using System;
using System.Collections.Generic;

using MMNet.CSh.ConsoleApp;
using MMNet.CSh.MathMM;
using MMNet.CSh.StringMM;

namespace EulerProject.Projects
{
	class Problem3 : BaseProblem
	{
		public Problem3()
		{
			_id = 3;
			_tit = "Largest Prime Factor";
			_que = "What is the largest prime factor of the number 600,851,475,143?";
			_pro = "Please enter an integer that you'd like to calculate the largest prime factor of.";
			_eff = BigO.Undetermined;
		}

		protected override void Solve()
		{
			// Limit of 15 digits at max value.
			ulong inputLimit = 999999999999999;

			ulong input = Input.RequestULong(Prompt + " The limit is 15 digits.", inputLimit);
			int root = (int)Math.Sqrt(input);
			int[] primes = Primes.Generate(root);

			List<int> factors = new List<int>();
			int high = 0;
			foreach(int i in primes) {
				if (input % (ulong)i == 0) {
					factors.Add(i);
					high = i;
				}
			}

			if(factors.Count > 1) {
				string str = StringManip.StringListFromInts(factors.ToArray());
				Console.WriteLine("\n" + str + "\n");
				Console.WriteLine($"There are {factors.Count} prime factors for the number {input}, listed above.");
				Console.WriteLine($"Therefore, the largest prime factor of {input} is {high}.\n");
			}
			else if (factors.Count == 1) {
				Console.WriteLine($"\nThere is only one prime factor for the number {input}, it is {factors[0]}");
				Console.WriteLine($"Therefore, the largest prime factor of {input} is {high}.\n");
			}
			else {
				Console.WriteLine($"\nThe number {input} is prime itself!");
				Console.WriteLine("Therefore, its highest prime factor is itself!\n");
			}
		}
	}
}
