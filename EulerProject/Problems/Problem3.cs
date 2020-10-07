using System;
using System.Collections.Generic;
using UtilityLibrary;

namespace EulerProject.Projects
{
	class Problem3 : BaseProblem
	{
		public Problem3()
		{
			_id = 3;
			_tit = "Largest Prime Factor";
			_que = "What is the largest prime factor of the number 600,851,475,143?";
			_pro = "Please enter an integer that you'd like to calculate up to:";
			_eff = BigO.On;
		}

		public override void Solve()
		{
			int input = InputUtils.RequestInt(Prompt);

			int[] primes = MathUtils.PrimeGeneratorLight(input);

			List<int> factors = new List<int>();
			int high = 0;
			foreach(int i in primes) {
				if (input % i == 0) {
					factors.Add(i);
					high = i;
				}
			}

			if(factors.Count > 1) {
				string str = StringUtils.StringListFromInts(factors.ToArray());
				Console.WriteLine("\n" + str + "\n");
				Console.WriteLine($"There are {factors.Count} prime factors for the number {input}, listed above.");
				Console.WriteLine($"Therefore, the largest prime factor of {input} is {high}.");
			}
			else if (factors.Count == 1) {
				Console.WriteLine($"There is only one prime factor for the number {input}, it is {factors[0]}");
				Console.WriteLine($"Therefore, the largest prime factor of {input} is {high}.");
			}
			else {
				Console.WriteLine($"The number {input} is prime itself!");
				Console.WriteLine("Therefore, its highest prime factor is itself!");
			}
		}
	}
}
