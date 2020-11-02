using System;

using MMNet.CSh.ConsoleApp;

namespace EulerProject.Problems
{
	class Problem1 : BaseProblem
	{
		public Problem1()
		{
			_id = 1;
			_tit = "Multiples of 3 and 5";
			_que = "Find the sum of all the multiples of 3 or 5 below 1000.";
			_pro = "Please enter an integer that you'd like to calculate up to:";
			_eff = BigO.Undetermined;
		}

		protected override void Solve()
		{
			uint limit = Input.RequestUInt(Prompt);
			
			ulong sum = 0;
			uint count = 0;
			uint x = 3;
			while (x < limit) {
				sum += x;
				count++;
				x += 3;
			}

			x = 5;
			while (x < limit)  {
				if (x % 3 != 0) {
					sum += x;
					count++;
				}

				x += 5;
			}

			Console.WriteLine($"\nThere are {count} unique multiples of 3 or 5 below {limit}.");
			Console.WriteLine($"The sum of all multiples of 3 or 5 below {limit} is {sum}.\n");
		}
	}
}
