using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace crelos2
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("CarlOS [Version 10.036953] (c) Carl. All rights reserved.");
        }

        protected override void Run()
        {
            Console.Write(">");
            var input = Console.ReadLine();

            switch (input)
            {
                default:
                    Console.WriteLine("no");
                    break;

                case "carl.":
                    Console.WriteLine("CRAL MOMEMENT");
                    break;

                case "cls":
                    Console.Clear();
                    break;

                case "calc":
                    Console.Write("1st number: ");
                    string num1String = Console.ReadLine();
                    double num1 = double.Parse(num1String);
                    Console.WriteLine();
                    Console.Write("2nd number: ");
                    string num2String = Console.ReadLine();
                    double num2 = double.Parse(num2String);
                    Console.WriteLine();
                    Console.Write("Operator? (+, -, *, /)");
                    string oper = Console.ReadLine();
                    Calc(num1, num2, oper);
                    break;

            }

        }

        private static void Calc(double num1, double num2, string oper)
        {
            if (oper == "+")
            {
                double result = num1 + num2;
                Console.WriteLine("Result: " + result);
            }

            if (oper == "-")
            {
                double result = num1 - num2;
                Console.WriteLine("Result: " + result);
            }

            if (oper == "/")
            {
                double result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }

            if (oper == "*")
            {
                double result = num1 * num2;
                Console.WriteLine("Result: " + result);
            }
        }

    }
}
