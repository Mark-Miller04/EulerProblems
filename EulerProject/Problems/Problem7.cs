using System;

using MMNet.CSh.ConsoleApp;
using MMNet.CSh.MathMM;

namespace EulerProject.Problems
{
	class Problem7 : BaseProblem
	{
		public Problem7()
		{
			_id = 7;
			_tit = "10001st Prime";
			_que = "What is the 10001st prime number?";
			_pro = "Please enter an integer value between 1 and 1,000,000.";
			_eff = BigO.Undetermined;
		}

		protected override void Solve()
		{
			int input = Input.RequestInt(Prompt);
			
			
		}
	}
}
