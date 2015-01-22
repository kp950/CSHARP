using System;

namespace Calc
{
    public class Calc
    {
        // Calc app        
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                //Console.WriteLine(args[0] + " " + args[1]);
                if(args[0] == "add")
                {
						Add(args[1] , args[2]);
                }
                else if (args[0] == "sub")
                {
					    Sub(args[1] , args[2]);
                }
                // exit the app
                return;
            }

            // no argument was provided
            Console.WriteLine("Please enter an equation");

            // keep the console window open until some key is pressed (this is a nice workaround) 
            Console.ReadKey();
            
        }
		
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

