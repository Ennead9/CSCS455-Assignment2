using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Program
    {
        private static char menuOption;
        private static bool continueProgram = true;
        static void Main(string[] args)
        {
            while (continueProgram)
            {
                Console.WriteLine("Welcome to the calculator. \n" +
                    "First, please enter two numbers (Press enter after each): \n");
                
                //TODO: Try catch for invalid double input
                var calc = new Calculator(
                    Convert.ToDouble(Console.ReadLine()),
                    Convert.ToDouble(Console.ReadLine()));
                
                Console.WriteLine("Which operation would you like to perform on the numbers? Enter a number:\n");
                Console.WriteLine(
                    "1: Add\n" +
                    "2: Subtract\n" +
                    "3: Multiply\n" +
                    "4: Divide\n" +
                    "X: Exit\n"
                    );

                //TODO:Check for empty string
                menuOption = Console.ReadLine().Substring(0, 1).ToLower().ElementAt(0);
                continueProgram = menuOption != 'x';
                if (!continueProgram) { break; } //exit

                switch (menuOption)
                {
                    case '1':
                        calc.Add();
                        break;
                    case '2':
                        calc.Subtract();
                        break;
                    case '3':
                        calc.Multiply();
                        break;
                    case '4':
                        calc.Divide();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation Option!");
                        break;
                }
                PrintResult(calc.Result);
            }
            Console.WriteLine("Thank you! Goodbye.");
        }
        public static void PrintResult(double result)
        {
            Console.WriteLine("The result of the operation is: " + result + "\n");
        }
    }
}
