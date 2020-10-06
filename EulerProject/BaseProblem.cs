using System;
using System.Collections.Generic;
using System.Text;

namespace EulerProject
{
	/// <summary>
	/// The determined efficiency of the problem's solve method.
	/// </summary>
	public enum BigO { O1, Ologn, Onlogn, On, On2 }
	
	/// <summary>
	/// Base object for all Euler Problems. Contains a Solve() method to solve the problem.
	/// </summary>
	public abstract class BaseProblem
	{
		public readonly int id;
		public readonly string question;
		public readonly BigO efficiency;

		/// <param name="i">The problem number from ProjectEuler.net.</param>
		/// <param name="que">A summary of the question being posed.</param>
		/// <param name="eff">The proposed efficiency of the solve method.</param>
		public BaseProblem(int i, string que, BigO eff)
		{
			id = i;
			question = que;
		}

		/// <summary>
		/// Solves the problem, implemented in each independent problem instance.
		/// </summary>
		public abstract void Solve();
	}
}
