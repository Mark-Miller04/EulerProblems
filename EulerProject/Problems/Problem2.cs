using System;

namespace EulerProject.Projects
{
	class Problem2 : BaseProblem
	{
		public Problem2()
		{
			_id = 2;
			_tit = "Even Fibonacci Numbers";
			_que = "Find the sum of all even Fibonacci numbers that are less than 4 million.";
			_eff = BigO.On;
		}

		public override void Solve()
		{
			int sum = 0;
			int last = 0;
			int current = 1;
			while (current < 4000000)
			{
				if (current % 2 == 0)
				{
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
