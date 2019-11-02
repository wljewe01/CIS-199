// Lab 1
// CIS 199-XX
// Due: 1/28/2018
// By: Andrew L. Wright

// This program reads two floating point numbers and prints the sum,
// difference, product, quotient, and mean of the values. For
// the difference, the first number minus the second number is
// calculated. For the quotient, the first number is divided by the
// second number.

// Version 3 - Typical solution that keeps track of each calculation
// in a single variable and performs formatting inside composite placeholders.
// Uses Parse methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;        // User's first number
            double num2;        // User's second number
            double result;      // Holds result of calculations

            //Gather input from user
            Write("Enter 1st floating point number: ");
            num1 = double.Parse(ReadLine());
            Write("Enter 2nd floating point number: ");
            num2 = double.Parse(ReadLine());
            WriteLine(); // For spacing

            // Perform calculations and outputs
            result = num1 + num2;
            WriteLine("{0:F3} + {1:F3} = {2:F3}", num1, num2, result);

            result = num1 - num2;
            WriteLine("{0:F3} - {1:F3} = {2:F3}", num1, num2, result);

            result = num1 * num2;
            WriteLine("{0:F3} * {1:F3} = {2:F3}", num1, num2, result);

            result = num1 / num2;
            WriteLine("{0:F3} / {1:F3} = {2:F3}", num1, num2, result);

            result = (num1 + num2) / 2.0; // Dr. Wright said OK to use magic number here!
                                          // Parentheses ARE needed

            WriteLine("---Mean of");
            WriteLine("{0:F3} , {1:F3} = {2:F3}", num1, num2, result);
        }
    }
}