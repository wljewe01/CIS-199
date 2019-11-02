
/*
 Grading ID:D8649
 Program 0
 Due Date: 9/10/2018
 Section: 01

 Parcel class: This class is the base class from which the 
 Address and Letter classes get the origin address and destination address objects. 
 This class also provides the CalcCost abstract method for the derived classes
 to override. It has a ToString Method in which it returns the origin and destination
 addresses as well as the cost after it is calulated. 
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public abstract class Parcel
    {
        private Address _originAddress; //backing field for OriginAddress Property
        private Address _destinationAddress; //backing field for DestinationAddress Property


        //Precondition: zip>=0 && zip <99999
        //Postcondition: the address object has been initialized with the specified
        //               first name, last name, address1, address2, city, state, and zip
        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }


        public Address OriginAddress
        {
            // Precondition:  None
            // Postcondition: The origin address has been returned
            get
            {
                return _originAddress;
            }

            // Precondition:  none
            // Postcondition: The origin address has been set to the specified value
            set
            {
                _originAddress = value;
            }
        }


        public Address DestinationAddress
        {
            // Precondition:  None
            // Postcondition: The destination address has been returned
            get
            {
                return _destinationAddress;
            }
            // Precondition:  none
            // Postcondition: The destination address has been set to the specified value
            set
            {
                _destinationAddress = value;
            }
        }

        //abstract method provides structure for derived classes to use CalcCost
        //precondition: none
        //postcondition: cost is returned
        public abstract decimal CalcCost();


        //pre-condition: None
        //post-condition: A string is returned presenting parcel data
        public override string ToString()
        {
            return ($"Origin Address: {Environment.NewLine} {OriginAddress}{Environment.NewLine}" +
                 $"Destination Address: {Environment.NewLine} {DestinationAddress}{Environment.NewLine}" +
                 $"Fixed Cost: +{CalcCost():C}");
        }// ToString


    }

        
        
    }

    




