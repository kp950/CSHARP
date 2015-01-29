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
                string ops, val1, val2;
                ops = val1 = val2 = string.Empty;

                do
                {
                    PromptForInput(ref ops, ref val1, ref val2);

                    switch(ops)
                    {
                        case "add":
                            {
                                Console.WriteLine("in Add");
                            }
                            break;
                        case "sub": // todo:                          
                        case "q":
                            break; // exit the switch statement
                        default:
                            Console.WriteLine("Operation not supported: [" + ops + "]");
                            Console.WriteLine("Valid operations are: add, sub, q and ?");
                            Console.WriteLine("Example: add 2 3");
                            break;
                    }
                    
                }
                while (ops != "q");

             // keep the console window open until some key is pressed (this is a nice workaround) 
                Console.WriteLine("Press a key to exit.");
            Console.ReadKey();
            
        }

        private static void PromptForInput(ref string ops, ref string val1, ref string val2)
        {
            Console.WriteLine("Enter operation:");
            string[] inputs = Console.ReadLine().Split(' ');

            if(inputs.Length <= 1)
            {
                ops = inputs[0];
                return;
            }

            ops = inputs[0];
            val1 = inputs[1];
            val2 = inputs[2];
        }
    }
}
