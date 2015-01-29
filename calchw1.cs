using System;

namespace Calc
{
    public class Calc
    {
        // Calc app
        /// <summary>
        /// Calc app: 
        /// Actions: add, sub, multi, div
        /// Param: calc action value 1, value 2
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string ops = args[0];
				string input1 = args[1];
				string input2 = args[2];
				
                while (ops != "q")
                {
                    Console.WriteLine("I am ready!");
                    if (ops == "add")
                    {
                        Add(input1, input2);
                    }
                    else if (ops == "sub")
                    {
                        Sub(input1, input2);
                    }
                    else
                    {
                        Console.WriteLine("Operation not supported: [" + ops + "]");
                        Console.WriteLine("Try again.");
                    }
					
					///WHAT DOES THIS DO?
                    string[] inputs = Console.ReadLine().Split(' ');
                    ops = inputs[0];
					input1 = inputs[1];
					input2 = inputs[2];
					///WHAT DOES THIS DO?
                }

                // exit the app
                return;
            }

            // no argument was provided
            Console.WriteLine("Show help!");

            // keep the console window open until some key is pressed (this is a nice workaround) 
            Console.ReadKey();
            
        } //main end
		
		public static void Add(string val1, string val2)
		{
			int num1 = Convert.ToInt32(val1);
			int num2 = Convert.ToInt32(val2);
			Console.WriteLine("Result: {0} ", num1 + num2);
		}
		
		public static void Sub(string val1, string val2)
		{
			int num1 = Convert.ToInt32(val1);
			int num2 = Convert.ToInt32(val2);
			Console.WriteLine("Result: {0} ", num1 - num2);
		}
    } 
}
