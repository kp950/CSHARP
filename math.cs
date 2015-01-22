using System;

namespace myMath
{
	class myProgram
	{
		static void Main(string[] arg)
		{
		int result = String.Compare(arg[0],"Add");
			Console.WriteLine(result);
			
			if (result == 0)
			{
				Console.WriteLine("//add function");
			}	/*
			else if (arg[0] = "Subtract")
			{
				Console.WriteLine("//subtract function");
			}
			
			else if (arg[0] = "Multiply")
			{
				Console.WriteLine("//multiply function");
			}
			
			else if (arg[0] = "Divide")
			{
				Console.WriteLine("//divide function");
			}*/
		}
	}
}
