/*Grading ID: W9204
 This lab has 10 rows of stars and
 space. The outer loop controls the rows and 
 quits after the max number of rows is met.
 The inner loops control the stars and spacing
 in each row depending on the iteration
 of the outer loop.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;
            //Pattern A
            WriteLine("Pattern A");
            WriteLine();
            for (int row = 1; row <= MAX_ROWS; row++)// outer loop
            {
                for (int star = 1; star <= row; star++)// inner loop
                    Write("*");
                WriteLine();

            }

            //Pattern B
            WriteLine("Pattern B");
            WriteLine();
            for (int row = MAX_ROWS; row >= 1; row--)// outer loop
            {
                for (int star = 1; star <= row; star++) // inner loop
                    Write("*");
                WriteLine();
            }

            //Pattern C
            WriteLine("Pattern C");
            WriteLine();
            for (int row = MAX_ROWS; row >= 1; row--)
            {
                for (int spaces = 1; spaces <= MAX_ROWS-row; spaces++)//first inner loop, controls space output
                    Write(" ");
                for (int star = 1; star <= row; star++)// second inner loop, controls star output
                    Write("*");
                WriteLine();
            }





            //Pattern D
            WriteLine("Pattern D");
            WriteLine();
            for (int row = 1; row <= MAX_ROWS; row++) //outer loop
            {
                for (int spaces = 1; spaces <= MAX_ROWS - row; spaces++)// first inner loop, controls space output
                    Write(" ");
                for (int star = 1; star <= row; star++)//second inner loop, controls start output
                    Write("*");
                WriteLine();

            }


        }
    }
}
