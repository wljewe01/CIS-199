//W8627
//Lab 5
//Due: March 4
//CIS199-01
//This program uses loops to output a set pattern of stars
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;//sets the max number of rows as a constant, in this instance it is 10

            WriteLine("Pattern A");
            WriteLine("");
            for (int row = 1; row <= MAX_ROWS; row++)//sets row at 1 then increases until 10
            {
                for (int star = 1; star <= row; star++)//starts at one star then moves up as the row moves up
                    Write("*");
                WriteLine();
            }

            WriteLine("");
            WriteLine("Pattern B");
            WriteLine("");
            for (int row = MAX_ROWS; row >= 1; row--) //starts with row as 10 then goes down until row is set at 1
            {
                for (int star = 1; star <= row;star++)//stars increase until it hits the row number. so 10 stars in first output because row was set to 10
                    Write("*");
                WriteLine();
            }

            WriteLine("");
            WriteLine("Pattern C");
            WriteLine("");
            for (int row = MAX_ROWS; row >= 1; row--)//starts with row as 10 then goes down until row is set at 1
            {
                for (int numspaces = 1; numspaces <= MAX_ROWS - row; numspaces++)//starts with 1 space then goes up until it reaches the difference between max and row #
                    Write(" ");
                {
                    for (int star = 1; star <= row; star++)//starts with one star then increases until it reaches the number assigned to row
                        Write("*");
                    WriteLine("");
                }
            }

            WriteLine("");
            WriteLine("Pattern D");
            WriteLine("");
            for (int row = 1; row <= MAX_ROWS; row++)//sets row at 1 then increases until 10
            {
                for (int numspaces = 1; numspaces <= MAX_ROWS - row; numspaces++)//starts with 1 space then goes up until it reaches the difference between max and row #
                    Write(" ");
                {
                    for (int star = 1; star <= row; star++)//starts with one star then increases until it reaches the number assigned to row
                        Write("*");
                    WriteLine("");
                }
            }








        }
    }
}
