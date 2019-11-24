/*Grading ID: W9204
  Program 4
  Due 4/24/18
  This program has a ground package class that sets data including 
  origin zipcode, destination zipcode, length, width, height, weight,
  and shipping cost, for packages. The data is then tested with the test
  class and is displayed. 
 */

 //Program.cs 
 //Several ground package objects created and dipslayed
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program4
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Several ground package objects created, an array created, 
        // the objects are stored in the array, and the display packages methid
        // is called
        static void Main(string[] args)
        {
            GroundPackage package1 = new GroundPackage(-12345, 95543, 2.0, 3.0, 4.0, 5.0); // first ground package object 
            GroundPackage package2 = new GroundPackage(22135, -82245, 3.0, 6.4, 5.0, 6.0); // first ground package object
            GroundPackage package3 = new GroundPackage(31548, 76654, -4.2, 7.5, 8.4, 2.1); // first ground package object
            GroundPackage package4 = new GroundPackage(48796, 31502, 5.6, 8.4, 2.8, 9.4); // first ground package object
            GroundPackage package5 = new GroundPackage(56623, 21486, 7.8, 9.2, 3.4, 6.7); // first ground package object

           
            GroundPackage[] groundPackages = new GroundPackage[5];// array created for ground packages

          
            groundPackages[0] = package1; 
            groundPackages[1] = package2;
            groundPackages[2] = package3;
            groundPackages[3] = package4;
            groundPackages[4] = package5;

           
            DisplayPackages(groundPackages);
        }//main

        // Precondition:  None
        // Postcondition: Ground packages in the groundPackage array are 
        //                displayed 
        public static void DisplayPackages(GroundPackage[] groundPackage)
        {
           
            foreach (GroundPackage currentPackage in groundPackage)
            {

                WriteLine($"{currentPackage.ToString()}");
                WriteLine($"Total Cost: {currentPackage.CalcCost():C}");
                WriteLine();
            }//foreach
           
        }//displayPackages
    }//class
}//namespace
