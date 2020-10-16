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
			_pro = "Please enter an integer that you'd like to calculate the largest prime factor of:";
			_eff = BigO.Undetermined;
		}

		public override void Solve()
		{
			double input = double.MaxValue;
			int primeInput = 0;
			while (input == double.MaxValue)
			{
				input = Input.RequestPosDouble(Prompt);
				double root = Math.Sqrt(input);
				if (root > int.MaxValue - 1) {
					Console.WriteLine("The input is too large to effectively calculate primes up to. Please enter a smaller value.");
					input = double.MaxValue;
				}
				else {
					primeInput = ((int)root) + 1;
				}
			}

			int inputInt = (int)input; 
			int[] primes = Primes.Generate(primeInput);

			List<int> factors = new List<int>();
			int high = 0;
			foreach(int i in primes) {
				if (inputInt % i == 0) {
					factors.Add(i);
					high = i;
				}
			}

			if(factors.Count > 1) {
				string str = StringCompare.StringListFromInts(factors.ToArray());
				Console.WriteLine("\n" + str + "\n");
				Console.WriteLine($"There are {factors.Count} prime factors for the number {inputInt}, listed above.");
				Console.WriteLine($"Therefore, the largest prime factor of {inputInt} is {high}.\n");
			}
			else if (factors.Count == 1) {
				Console.WriteLine($"\nThere is only one prime factor for the number {inputInt}, it is {factors[0]}");
				Console.WriteLine($"Therefore, the largest prime factor of {inputInt} is {high}.\n");
			}
			else {
				Console.WriteLine($"\nThe number {inputInt} is prime itself!");
				Console.WriteLine("Therefore, its highest prime factor is itself!\n");
			}
		}
	}
}
