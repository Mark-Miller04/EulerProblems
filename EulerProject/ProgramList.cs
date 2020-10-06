using EulerProject.Projects;
using System.Collections.Generic;

namespace EulerProject
{
	public static class ProgramList
	{
		public static Dictionary<int, BaseProblem> List { get; } = new Dictionary<int, BaseProblem>()
		{
			{ 1, new Problem1() },
			{ 2, new Problem2() },
			{ 3, new Problem3() },
		};
	}
}
