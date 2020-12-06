/*
 * Project: DivideByZeroException
 * Filename: Program.cs
 * Author: R. Snell
 * Purpose: To demonstrate handilng ingical exception (division by zero)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr2020_DivideByZeroException
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the numerator
            Console.Write("Please enter an integer for the numerator: ");
            var numerator = int.Parse(Console.ReadLine());
            // Get the denominator
            Console.Write("Please enter an integer for the denominator: ");
            var denominator = int.Parse(Console.ReadLine());

            // Divide the inegers, then display the result
            var result = numerator / denominator;
            Console.WriteLine($"Result: {numerator}/{denominator} = " +
                $"{result}"); 
        }   // end Main()
    }   // end class
}   // end namespace
