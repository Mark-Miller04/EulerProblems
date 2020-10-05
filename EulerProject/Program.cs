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
			//WriteProgramList();
			int prog = 0;//SelectProgram();

			
			Console.WriteLine(StringUtils.TestString());

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
			int ret = -1;
			while (ret <= 0 || ret > programList.Length)
			{
				Console.WriteLine("Please enter a valid number from the list of programs.\n");
				string str = Console.ReadLine();
				try {
					ret = Convert.ToInt32(str);
				}
				catch (Exception e) {
					Console.Clear();
					WriteProgramList();
					Console.WriteLine("The value you entered is invalid.");
					continue;
				}

				if (ret <= 0 || ret > programList.Length) {
					Console.Clear();
					WriteProgramList();
					Console.WriteLine("The value you entered is invalid.");
				}
				else {
					return ret;
				}
			}

			return 0;
		}

		private static void Problem1()
		{
			Console.WriteLine("Running program 1.");
		}
	}
}
