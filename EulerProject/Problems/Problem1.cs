using System;

namespace EulerProject.Projects
{
	class Problem1 : BaseProblem
	{
		public Problem1()
		{
			_id = 1;
			_tit = "Multiples of 3 and 5";
			_que = "Find the sum of all the multiples of 3 or 5 below 1000.";
			_eff = BigO.On;
		}

		public override void Solve()
		{
			int sum = 0;
			int x = 3;
			while (x < 1000)
			{
				sum += x;
				x += 3;
			}

			x = 5;
			while (x < 1000) 
			{
				if (x % 3 != 0) {
					sum += x;
				}

				x += 5;
			}

			Console.WriteLine($"The sum of all multiples of 3 or 5 below 1000 is {sum}.");
		}
	}
}
