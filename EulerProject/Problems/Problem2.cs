using System;
using UtilityLibrary;

namespace EulerProject.Projects
{
	class Problem2 : BaseProblem
	{
		public Problem2()
		{
			_id = 2;
			_tit = "Even Fibonacci Numbers";
			_que = "Find the sum of all even Fibonacci numbers that are less than 4 million.";
			_pro = "Please enter an integer that you'd like to calculate up to:";
			_eff = BigO.On;
		}

		public override void Solve()
		{
			int limit = InputUtils.RequestInt(Prompt);

			int sum = 0;
			int count = 0;
			int last = 0;
			int current = 1;
			
			while (current < limit) {
				if (current % 2 == 0) {
					sum += current;
					count++;
				}

				int temp = current;
				current += last;
				last = temp;
			}

			Console.WriteLine($"\nThere are {count} even Fibonacci numbers below {limit}.");
			Console.WriteLine($"The sum of these numbers is {sum}.\n");
		}
	}
}
