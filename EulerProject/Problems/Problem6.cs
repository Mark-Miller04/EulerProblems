using System;

using MMNet.CSh.ConsoleApp;

namespace EulerProject.Problems
{
	class Problem6 : BaseProblem
	{
		public Problem6()
		{
			_id = 6;
			_tit = "Sum Square Difference";
			_que = "What is the difference between the sum of the squares, and the square of the sum for the first 100 natural numbers?";
			_pro = "Please enter an integer between 2 and 100.";
			_eff = BigO.Undetermined;
		}

		protected override void Solve()
		{
			int input = Input.RequestInt(Prompt, 2, 100);

			int sumOfSquares = 0, squareOfSums = 0;
			for(int i = 1; i <= input; i++)
			{
				sumOfSquares += i * i;
				squareOfSums += i;
			}
			squareOfSums *= squareOfSums;
			int diff = squareOfSums - sumOfSquares;

			Console.WriteLine($"The sum of squares for the first {input} natural numbers is {sumOfSquares}.");
			Console.WriteLine($"The square of sums for the first {input} natural numbers is {squareOfSums}.");
			Console.WriteLine($"Therefore the difference between the two is {diff}.");
		}
	}
}
