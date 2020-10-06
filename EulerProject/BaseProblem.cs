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
		protected int _id;
		public int ID => _id;

		protected string _tit;
		public string Title => _tit;

		protected string _que;
		public string Question => _que;

		protected BigO _eff;
		public BigO Efficiency => _eff;

		/// <summary>
		/// Solves the problem, implemented in each independent problem instance.
		/// </summary>
		public abstract void Solve();
	}
}
