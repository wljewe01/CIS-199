/*Grading ID:W9204
 Program 1
 Due: 2/13/18
 CIS 199-01-4182
 Reads in user input of wall length, height, number of doors,
 and number of windows. It then calculates the square footage
 minus the doors and windows. It asks the user how many coats
 of paint they would like to use, and then determines how many
 gallons of paint based on square footage and paint coverage. 
 The output tells the user how many gallons to buy and the
 total cost. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // variables
            double height; // height of walls
            double length; // permiter of walls
            int numDoors; // total number of doors
            int numWindows; // total number of windows;
            const int subWindows = 15; // number that will be subracted from totalSquareFeet that represents 1 window
            const int subDoors = 20; // number that will be subtracted from totalSquareFeet  that represents 1 door
            const int paintCoverage = 375; // number that represents the coverage from 1 gallon of paint 
            int coatsOfPaint; // how many coats of paint wanted by user
            double costPerGallon; // cost of gallon of paint
            double totalSquareFeet; // squareFeet - doors and windows
            double squareFeet; //perimeter * height 
            double totalPaint; // square feet - number of doors - number of windows 
            double minGallons; // the minimum number of gallons needed ??
            double gallonsToBuy; // minimum of gallons rounded to next gallon
            double totalPrice;

            // user input
            Write("Welcome to the Handy-Dandy Paint Estimator");
            WriteLine();
            Write("Enter the total length of all walls (in feet): ");
            length = double.Parse(ReadLine());
            Write("Enter the height of the walls (in feet): ");
            height = double.Parse(ReadLine());
            Write("Enter the number of doors (non-neg int): ");
            numDoors = Int32.Parse(ReadLine());
            Write("Enter the number of windows (non-neg int): ");
            numWindows = Int32.Parse(ReadLine());
            Write("Enter the number of coats of paint (non-neg int): ");
            coatsOfPaint = Int32.Parse(ReadLine());
            Write("Enter the cost per gallon of paint (in $): ");
            costPerGallon = double.Parse(ReadLine());



            //calculates square footage based on user input - doors and windows
            //calculates gallons of paint to buy based on coverage

            squareFeet = length * height;
            totalSquareFeet = squareFeet - (numWindows * subWindows) - (numDoors * subDoors);
            totalPaint = totalSquareFeet * coatsOfPaint;
            minGallons = totalPaint / paintCoverage;
            gallonsToBuy = (int)Math.Ceiling(minGallons);
            totalPrice = gallonsToBuy * costPerGallon;


            //outputs to the user

            WriteLine();
            WriteLine($"You need a minimum of {minGallons:F1} gallons of paint.");
            WriteLine($"You'll need to buy {gallonsToBuy:F0} gallons, though,");
            WriteLine($"at a cost of {totalPrice:C}");
        }
    }
}
