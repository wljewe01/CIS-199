﻿// Lab 1
// CIS 199-XX
// Due: 1/28/2018
// By: Andrew L. Wright

// This program reads two floating point numbers and prints the sum,
// difference, product, quotient, and mean of the values. For
// the difference, the first number minus the second number is
// calculated. For the quotient, the first number is divided by the
// second number.

// Version 4 - Typical solution that keeps track of each calculation
// in a separate variable and performs formatting using string interpolation.
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

            double sum;         // Holds sum of numbers
            double difference;  // Holds num1 - num2
            double product;     // Holds product of numbers
            double quotient;    // Hold num1 divided by num2
            double mean;        // Holds mean of numbers

            //Gather input from user
            Write("Enter 1st floating point number: ");
            num1 = double.Parse(ReadLine());
            Write("Enter 2nd floating point number: ");
            num2 = double.Parse(ReadLine());

            // Perform calculations
            sum = num1 + num2;
            difference = num1 - num2;
            product = num1 * num2;
            quotient = num1 / num2;
            mean = sum / 2.0; // Dr. Wright said OK to use magic number here!

            // Output results, using composite formatting with ToStrings
            WriteLine(); // For spacing
            WriteLine($"{num1:F3} + {num2:F3} = {sum:F3}");
            WriteLine($"{num1:F3} + {num2:F3} = {difference:F3}");
            WriteLine($"{num1:F3} + {num2:F3} = {product:F3}");
            WriteLine($"{num1:F3} / {num2:F3} = {quotient:F3}");
            WriteLine("---Mean of");
            WriteLine($"{num1:F3} , {num2:F3} = {mean:F3}");
        }
    }
}