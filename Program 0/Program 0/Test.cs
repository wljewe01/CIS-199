/*
 Grading ID:D8649
 Program 0
 Due Date: 9/10/2018
 Section: 01

 Test class: This class is a class that tests if my constructors, methods, and properties
 work correcty using different kinds of data.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    class Program
    {
        static void Main(string[] args)
        {

            Address address1 = new Address("Sandy", "Jones", "1111 Autumn Ridge Way", "Apt 15", "Jeffersonville", "Indiana", 47130);
            Address address2 = new Address("Evan", "Lucas", "1010 Meadow Street", "New Albany", "Indiana", 52424);
            Address address3 = new Address("Jordan", "Smith", "1000 Morgan Way", "Clarksville", "Indiana", 10253);
            Address address4 = new Address("Avery", "Jane", "502 Crum Street", "Floyds Knobs", "Indiana", 47119);
            Letter letter1 = new Letter(address1, address2, 5.00m);
            Letter letter2 = new Letter(address3, address4, 6.65m);
            Letter letter3 = new Letter(address2, address1, 10.5m);

            //List of all the parcel objects
            List<Parcel> parcelList = new List<Parcel>() {letter1,letter2,letter3};

            //for each loop that goes through each object of the list and outputs the obejct
           foreach (Parcel currentParcel in parcelList)
            {
                Console.WriteLine(currentParcel);
            }


        }
    }
}
