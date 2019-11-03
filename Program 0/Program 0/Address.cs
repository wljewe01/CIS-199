/*
 Grading ID:D8649
 Program 0
 Due Date: 9/10/2018
 Section: 01

 Address class: This class is a class derived from the Parcel class. 
 This class creates properties for the address objects which are created
 for the origin and destination addresses derived from the parcel class. 
 It also has an ToString method in which it
 outputs the data for the address in two lines.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class Address
    {


        private string _firstName; //backing field for FirstName property
        private string _lastName; //backing field for LastName property
        private string _address1; //backing field for Address1 property
        private string _address2; //backing field for Address2 property
        private string _city; //backing field for City property
        private string _state; //backing field for State property
        private int _zip; //backing field for Zip property


        //Preconditions: zip>=0 && zip <99999, and
        //              firstName,lastName, address1,
        //              city, and state are non-empty strings
        //Postcondition: the address object has been initialized with the specified
        //               first name, last name, address1, address2, city, state, and zip
        public Address(string firstName, string lastName, string address1, string address2, string city, string state, int zip)

        {
            FirstName = firstName;
            LastName = lastName;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }//Address Constructor W/ Address1 & Address2


        //Preconditions: zip>=0 && zip <99999, and
        //              firstName,lastName, address1, address2
        //              city, and state are not empty strings
        //Postcondition: the address object has been initialized with the specified
        //               first name, last name, address1, address2, city, state, and zip           
        
        public Address(string firstName, string lastName, string address1, string city, string state, int zip)

        {
            FirstName = firstName;
            LastName = lastName;
            Address1 = address1;
            City = city;
            State = state;
            Zip = zip;
        }//Address Constructor W/ Address1 only


        public string FirstName
        {
            //Precondition:  None
            //Postcondition: The first name has been returned
            get
            {
                return _firstName;
            }

            //Precondition:  None
            //Postcondition: The first name has been set to the specified
            //               value
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(FirstName)} must be non-empty string");
                }
                else
                {
                    _firstName = value;
                }
            }

        }//FirstName Property


        public string LastName
        {
            //Precondition:  None
            //Postcondition: The last name has been returned
            get
            {
                return _lastName;
            }

            //Precondition:  None
            //Postcondition: The last name has been set to the specified
            //               value
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(LastName)} must be non-empty string");
                }
                else
                {
                    _lastName = value;
                }
            }

        }//LastName Property


        public string Address1
        {
            //Precondition:  None
            //Postcondition: The address1 has been returned
            get
            {
                return _address1;
            }

            //Precondition:  None
            //Postcondition: The address1 has been set to the specified
            //               value
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Address1)} must be non-empty string");
                }
                else
                {
                    _address1 = value;
                }

            }
        }//Address1 Property


        public string Address2
        {
            //Precondition:  None
            //Postcondition: The address2 has been returned
            get
            {
                return _address2;
            }

            //Precondition:  None
            //Postcondition: The address2 has been set to the specified
            //               value
     
            set
                {
                    _address2 = value;
                }    
        }//Address2 Property



        public string City
        {
            //Precondition:  None
            //Postcondition: The city has been returned
            get
            {
                return _city;
            }

            //Precondition:  None
            //Postcondition: The city has been set to the specified
            //               value
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(City)} must be non-empty string");
                }
                else
                {
                    _city = value;
                }

            }
        }//City Property 


        public string State
        {
            //Precondition:  None
            //Postcondition: The state has been returned
            get
            {
                return _state;
            }

            //Precondition:  None
            //Postcondition: The state has been set to the specified
            //               value
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(State)} must be non-empty string");
                }
                else
                {
                    _state = value;
                }

            }
        }//State Property 



        public int Zip
        {
            //Precondition:  None
            //Postcondition: The Zip has been returned
            get
            {
                return _zip;
            }
            set
            {
                if (value >= 0 && value < 99999)
                {
                    _zip = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Zip)} must be between 0-99999");
                }
            }
        }//Zip



        //Precondition: None
        //Postcondition: A string is returned presenting the data for the address objects.
        public override string ToString()
        {

            if(Address2!=null)

            {
                return
                    ($"{FirstName} {LastName}{Environment.NewLine}"
                    + $"{Address1}{Environment.NewLine}"
                    + $"{Address2}{Environment.NewLine}"
                    + $"{City} "
                    + $"{State} "
                    + $"{Zip:D5}{Environment.NewLine} ");
            }
            else
            {
                return
                    ($"{FirstName} {LastName}{Environment.NewLine}"
                    + $"{Address1}{Environment.NewLine}"
                    + $"{City } "
                    + $"{State } "
                    + $"{Zip:D5}{Environment.NewLine} ");
            }
           
        } //end toString  
    }

}


