/*
 Grading ID:D8649
 Program 0
 Due Date: 9/10/2018
 Section: 01

 Letter class: This class is a class derived from the Parcel class. 
 This class creates the fixed cost property for the letters which are parcel objects
 derived from the parcel class. It also overrides the CalcCost method from
 the parcel class and returns the cost in decimal form. It overrides the ToString method
 and outputs the data for the cost.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    class Letter:Parcel
    {
        
        private decimal _fixedCost; //private backing field for Cost property


        //Precondition:  fixedCost > 0
        //Postcondition: the letter object has been initialized with 
        //               the specified origin address, destination address,
        //               and cost
        public Letter(Address originAddress, Address destinationAddress, decimal fixedCost)
            :base(originAddress, destinationAddress)
        {
            
            FixedCost = fixedCost;
        }//Letter Constructor


        public decimal FixedCost
        {

            //Precondition:  None
            //Postcondition: The cost has been returned
            get
            {
                return _fixedCost;
            }

            //Precondition: value >=0
            //Postcondition: The cost has been set to specified value
            set
            {
                if (value >= 0)
                {

                    _fixedCost = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(FixedCost)} must be non-negative");
                }
            }
        }//Cost property


        //Precondition:  None
        //Postcondition: The cost is returned
        public override decimal CalcCost()
        {
            return FixedCost;
        }//CalcCost Method


        //Precondition: None
        //Postcondition: A string is returned presenting the letter's origin 
        //               address, destination address, and cost
        public override string ToString()
        {
            return
               ($"{"Letter"}{Environment.NewLine}"+
               $"{Environment.NewLine}Origin Address:{Environment.NewLine}{OriginAddress}{Environment.NewLine}" +
               $"Destination Address:{Environment.NewLine}" +
               $"" +
               $"{DestinationAddress}{Environment.NewLine}"+
               $"Cost:{FixedCost:C}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}");           
        }//ToString Method
    }
}
