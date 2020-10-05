using System;
using UtilityLibrary;

namespace EulerProject
{
	class Program
	{
		public static string[] programList = {
			"1: Multiples of 3 and 5.\n"
		};

		static void Main(string[] args)
		{
			WriteProgramList();
			int prog = SelectProgram();

			switch(prog)
			{
				case 1:
					Problem1();
					break;
				case 0:
				default:
					Console.WriteLine("Uncaught error in program selection.");
					break;
			}
		}

		private static void WriteProgramList()
		{
			Console.WriteLine("===== Program List =====\n");
			for(int i = 0; i < programList.Length; i++) {
				Console.WriteLine(programList[i]);
			}
			Console.WriteLine("=======================\n");
		}

		private static int SelectProgram()
		{
			int ret = 0;
			while (ret <= 0 || ret > programList.Length)
			{
				Console.WriteLine("Please enter a valid number from the list of programs.");
				try {
					ret = StringUtils.StringToInt(Console.ReadLine());
					if (ret <= 0 || ret > programList.Length) {
						throw new ArgumentOutOfRangeException();
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

		private static void Problem1()
		{
			Console.WriteLine("Running program 1.");
		}
	}
}
