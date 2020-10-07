using System;
using System.Collections.Generic;
using System.Numerics;
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
			_eff = BigO.On;
		}

		public override void Solve()
		{
			int limit = (int)(Math.Sqrt(600851475143)) + 1;
			int[] primes = MathUtils.PrimeGeneratorLight(limit);

			List<int> factors = new List<int>();
			int high = 0;
			foreach(int i in primes) {
				if (600851475143 % i == 0) {
					factors.Add(i);
					high = i;
				}
			}

			string str = "";
			foreach(int i in factors) {
				str += $"{i}, ";
			}
			
			Console.WriteLine(str);
			Console.WriteLine("Above is the list of all prime factors for the given input.");
			Console.WriteLine($"Therefore, the largest prime factor is {high}.");
		}
	}
}
