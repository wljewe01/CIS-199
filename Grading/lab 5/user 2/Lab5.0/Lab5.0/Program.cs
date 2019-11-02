//W5071
//Due Date: 03/04/2018j
//Lab 5
//CIS-199-01
//This program is designed to create a for loop that loops different star patterns.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Lab5._0
{
    class Program
    {
        static void Main(string[] args)
        {   //This is the loop that gives us Pattern A
            const int MAX_ROWS = 10;
            WriteLine("Pattern A");
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                
                for (int star = 1; star <= row; star++)
                   
                    Write("*");
                WriteLine();
            }
            //This code gives us pattern B; have to create a new loop for it
            WriteLine("Pattern B");
            for (int row = 10; row >= 1; --row)
            {
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();
            }
            //Code that gives us pattern C have to create a for statement then a nested statement inside
            WriteLine("Pattern C");
            for (int row = 1; row <= MAX_ROWS;  row++)
            {

                for (int spaces = MAX_ROWS - row; spaces > 0; spaces--)
                {
                    Write("*");
                }
                for (int star = 1; star <= row; star++)
                {
                    Write("");
                }
                WriteLine();
            }
            
        }
    }
}

