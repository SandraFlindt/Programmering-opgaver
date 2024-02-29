using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{

    internal class Calculator
    {
        static void Main(string[] args)
        {

            {
                double Number1 = 0;
                double Number2 = 0;
                Console.WriteLine("Type a number:");
                Console.WriteLine("Type a new number");

                Console.WriteLine("Type 1 for '+' type 2 for '-' type 3 for '/' type 4 for '*'");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine($"Your result = {Number1} + {Number2} = " + (Number1 + Number2));
                        break;
                    case "2":
                        Console.WriteLine($"Your result = {Number1} - {Number2} = " + (Number1 - Number2));
                        break;
                    case "3":
                        Console.WriteLine($"Your result = {Number1} / {Number2} = " + (Number1 / Number2));
                        break;
                    case "4":
                        Console.WriteLine($"Your result = {Number1} * {Number2} = " + (Number1 * Number2));
                        break;
                }
            }
        }
    }
}