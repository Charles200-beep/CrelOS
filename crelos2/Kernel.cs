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
            Console.Clear();
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
                    Console.WriteLine("CarlOS [Version 10.036953] (c) Carl. All rights reserved.");
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

                case "help":
                    Console.WriteLine("carl., cls, calc, shutdown, reboot");
                    break;

                case "shutdown":
                    Console.Write("Are you sure you want to shutdown? (Y/N): ");
                    string yesNoShutdown = Console.ReadLine();
                    if (yesNoShutdown == "y" || yesNoShutdown == "Y")
                    {
                        Cosmos.System.Power.Shutdown();
                    }
                    else if (yesNoShutdown == "n" || yesNoShutdown == "N")
                    {
                        break;
                    }
                    break;

                case "reboot":
                    Console.Write("Are you sure you want to reboot? (Y/N): ");
                    string yesNoReboot = Console.ReadLine();
                    if (yesNoReboot == "y" || yesNoReboot == "Y")
                    {
                        Cosmos.System.Power.Reboot();
                    }
                    else if (yesNoReboot == "n" || yesNoReboot == "N")
                    {
                        break;
                    }
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
