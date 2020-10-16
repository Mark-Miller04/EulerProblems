using System;
using System.Collections.Generic;

using MMNet.CSh.StringMM;
using MMNet.CSh.ConsoleApp;

// TODO: Add safe ways to accept any user input for all programs.

namespace EulerProject
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteProgramList();
			RunProgram(SelectProgram());
		}

		private static void WriteProgramList()
		{
			Console.WriteLine("===== Program List =====\n");
			foreach(KeyValuePair<int,BaseProblem> pair in ProgramList.List) {
				Console.WriteLine($"{pair.Value.ID}: {pair.Value.Title}");
			}
			Console.WriteLine("=======================\n");
		}

		private static int SelectProgram()
		{
			int ret = -1;
			bool isValidProgram = false;
			while (!isValidProgram)
			{
				Console.WriteLine("Please enter a valid number from the list of programs.");
				try {
					ret = StringCompare.StringToInt(Console.ReadLine());
					if (ProgramList.List.ContainsKey(ret)) {
						isValidProgram = true;
					}
					else {
						throw new IndexOutOfRangeException();
					}
				}
				catch (Exception e) {
					Console.Clear();
					WriteProgramList();
					Console.WriteLine(e.Message);
				}
			}

			return ret;
		}

		private static void RunProgram(int id)
		{
			BaseProblem problem = ProgramList.List[id];
			do {
				Console.Clear();
				Console.WriteLine($"===== Problem {problem.ID} =====");
				Console.WriteLine($"{problem.Question}\n");
				problem.Solve();
			}
			while (Input.RequestYN("Would you like to run this program again?"));
		}
	}
}
