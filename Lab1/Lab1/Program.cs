/*Grading ID:W9204
 Lab 1
 Due: 1/28/18
 CIS 199-01-4182
 Reads in user input of 2 floating point numbers, 
 then outputs the sum, difference, quotient, product,
 and mean of those two numbers*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber; //  first floating point number the user will input
            float secondNumber; // second floating point number the user will input
            float sum; //  sum of the two point numbers will be stored
            float difference; //  difference of the two point numbers will be stored
            float product; //  product of the two point numbers will be stored
            float quotient; // quotient of the two point numbers will be stored
            float mean; //  mean of the two point numbers will be stored
                 Write("Enter 1st floating point number: ");
                 firstNumber = float.Parse(ReadLine());
                 Write("Enter 2nd floating point number: "); 
                 secondNumber = float.Parse(ReadLine());
                 sum = firstNumber + secondNumber;
                 difference = firstNumber - secondNumber;
                 product = firstNumber * secondNumber;
                 quotient = firstNumber / secondNumber;
                 mean = (firstNumber + secondNumber) / 2;
            WriteLine();
            WriteLine($"{ firstNumber:F3} + { secondNumber:F3} = { sum:F3}");
            WriteLine($"{ firstNumber:F3} - { secondNumber:F3} = { difference:F3}");
            WriteLine($"{ firstNumber:F3} * { secondNumber:F3} = { product:F3}"); // this answer doesn't come out exactly like the answer problem
            WriteLine($"{ firstNumber:F3} / { secondNumber:F3} = { quotient:F3}");
            WriteLine("--Mean of");
            WriteLine($"{ firstNumber:F3} , { secondNumber:F3} = { mean:F3}");
            




        }
    }
}
