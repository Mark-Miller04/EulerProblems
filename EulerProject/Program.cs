using System;
using System.Collections.Generic;

using MMNet.CSh.ConsoleApp;

namespace EulerProject
{
	class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				WriteProgramList();
				int prog = SelectProgram();
				if (prog == 0) {
					return;
				}
				else {
					RunProgram(prog);
				}
			}
		}

		private static void WriteProgramList()
		{
			Console.Clear();
			Console.WriteLine("===== Program List =====\n");
			Console.WriteLine("Enter 0 to exit.");
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
				try {
					ret = Input.RequestInt("Please enter a valid number from the list of programs.");
					if (ProgramList.List.ContainsKey(ret) || ret == 0) {
						isValidProgram = true;
					}
					else {
						throw new IndexOutOfRangeException();
					}
				}
				catch (Exception e) {
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
				problem.Run();
			}
			while (Input.RequestYN("Would you like to run this program again?"));
		}
	}
}
