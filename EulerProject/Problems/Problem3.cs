﻿using System;
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
			_que = "What is the largest prime factor of the number 600851475143?";
			_eff = BigO.On;
		}

		public override void Solve()
		{
			int[] primes = MathUtils.PrimeGeneratorLight(100);
			//BigInteger[] primes = MathUtils.PrimeGeneratorHeavy(100);
			Console.WriteLine(primes.ToString());
			Console.WriteLine($"The largest prime factor is {primes[primes.Length - 1]}.");
		}
	}
}
