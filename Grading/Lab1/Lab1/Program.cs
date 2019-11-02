//W4594
//1/23/18
//CIS-199-01
//Lab1
//This program will provide equation ouput from two numeric variables. Basic Math equations of 2 numbers.

using System;
using static System.Console;


namespace Lab1
{
    class Program
    {
        static void Main()
        {
            double FirstNumber; //First Number to be entered, variable 1
            double SecondNumber; //Second Number to be entered, variable 2
            double Sum; //this is the value of variable 1 and 2
            double difference; //Variable 1 less variable 2
            double product; //variable 1 multiplied by variable 2
            double quotient; //This is variable 1 divided by variable 2
            double mean; //this is variable 1 plus variable 2 divided by the number of variables(2)

            Write("Enter 1st floating point number: ");
            FirstNumber = double.Parse(ReadLine());

            Write("Enter 2nd floating point number: ");
            SecondNumber = double.Parse(ReadLine());

            Sum = FirstNumber + SecondNumber;
            difference = FirstNumber - SecondNumber;
            product = FirstNumber * SecondNumber;
            quotient = FirstNumber / SecondNumber;
            mean = (FirstNumber + SecondNumber) / 2;
            Console.WriteLine();
            Console.WriteLine($"{FirstNumber:F3} + {SecondNumber:F3} = {Sum:F3}");
            Console.WriteLine($"{FirstNumber:F3} - {SecondNumber:F3} = {difference:F3}");
            Console.WriteLine($"{FirstNumber:F3} * {SecondNumber:F3} = {product:F3}");
            Console.WriteLine($"{FirstNumber:F3} / {SecondNumber:F3} = {quotient:F3}");
            WriteLine("---Mean of");
            Console.WriteLine($"{FirstNumber:F3} , {SecondNumber:F3} = {mean:F3}");
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadLine();


        }
    }


}
