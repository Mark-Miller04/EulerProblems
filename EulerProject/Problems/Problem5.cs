using System;

using MMNet.CSh.ConsoleApp;

namespace EulerProject.Problems
{
	class Problem5 : BaseProblem
	{
		public Problem5()
		{
			_id = 5;
			_tit = "Smallest Multiple";
			_que = "What is the smallest number that is evenly divisible by all numbers from 1-20?";
			_pro = "Please enter an integer value between 1 and 20.";
			_eff = BigO.Undetermined;
		}

		protected override void Solve()
		{
			uint input = Input.RequestUInt(Prompt, 1, 20);
			ulong low = 0;
			for(ulong i = input; i < ulong.MaxValue; i++)
			{
				bool accept = true;
				for (uint j = input / 2; j <= input; j++)
				{
					if (i % j != 0) {
						accept = false;
						break;
					}
				}

				if (accept) {
					low = i;
					break;
				}
			}

			if (low == 0) {
				Console.WriteLine($"No number less than max unsigned integer value could be found that is evenly divisible by all numbers from 1 to {input}.");
			}
			else {
				Console.WriteLine($"The lowest number commonly divisible by all numbers from 1 to {input} is {low}.");
			}
		}
	}
}
