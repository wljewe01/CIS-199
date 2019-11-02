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
     


            Write("Enter the total length of all walls (in feet): ");
            length = double.Parse(ReadLine());
            Write("Enter the height of the walls (in feet: ");
            height = double.Parse(ReadLine());
            Write("Enter the number of doors (non-neg int: ");
            numDoors = Int32.Parse(ReadLine());
            Write("Enter the number of windows (non-neg int: ");
            numWindows = Int32.Parse(ReadLine());
            Write("Enter the number of coats of paint (non-neg int: ");
            coatsOfPaint = Int32.Parse(ReadLine());
            Write(" Enter the cost per gallon of paint (in $): ");
            costPerGallon = double.Parse(ReadLine());







            
 
            squareFeet = length * height;
            totalSquareFeet = squareFeet - (numWindows * subWindows) - (numDoors * subDoors);
            totalPaint = totalSquareFeet * coatsOfPaint;
            minGallons = totalPaint / paintCoverage;
            gallonsToBuy = (int)Math.Ceiling(minGallons);

        }
    }
}
