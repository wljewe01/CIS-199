/*Grading ID: W9204
  Program 4
  Due 4/24/18
 */

 //GroundPackage.cs
 //GroundPackage class declaration with one constructor 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class GroundPackage
    {
        public const int MIN_ZIP = 0; //minimum zip that user can enter
        public const int MAX_ZIP = 99999; //maximum zip that user can enter
        public const int ZIP_DEFAULT = 90210; //default zip if user enters illegal value
        public const double OTHER_DEFAULT = 1.0; //default value if user enters negative number for weight, height, length, and width 
        public const double SIZE_FACTOR = .2; // size factor for cost formula 
        public const double WEIGHT_DISTANCE_FACTOR = .5; // weight and distance factor for cost formula
       


        private int _originZip; //backing field for OriginZip property
        private int _destZip; //backing field for DestinationZip property
        private double _length; //backing field for Length property
        private double _width; //backing field for Width property
        private double _height; //backing field for height property
        private double _weight; //backing field for weight property
        private int _zoneDistance; //backing field for ZoneDistance 
 
        public int OriginZip
        {
            // Precondition:  None
            // Postcondition: The origin zip has been returned
            get
            {
                return _originZip;
            }

            // Precondition:  0 < value
            // Postcondition: The origin zip has been set to the specified value
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)
                    _originZip = value;
                else
                    _originZip = ZIP_DEFAULT;
            }
        }//origin zip



        public int DestinationZip
        {
            // Precondition:  None
            // Postcondition: The destination zip has been returned
            get
            {
                return _destZip;
            }
            // Precondition:  0 < value
            // Postcondition: The destination zip has been set to the specified value
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)
                    _destZip = value;
                else
                    _destZip = ZIP_DEFAULT;
            }
        }//destination zip

     
        
        public double Length
        {
            // Precondition:  None
            // Postcondition: The length  has been returned
            get
            {
                return _length;
            }
            // Precondition:  0 < value
            // Postcondition: The length has been set to the specified value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = OTHER_DEFAULT;
            }
        }//length



        
        public double Width
        {
            // Precondition:  None
            // Postcondition: The width has been returned
            get
            {
                return _width;
            }
            // Precondition:  0 < value
            // Postcondition: The width has been set to the specified value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = OTHER_DEFAULT;
            }
        }//width


        
        public double Height
        {
            // Precondition:  None
            // Postcondition: The height has been returned
            get
            {
                return _height;
            }
            // Precondition:  0 < value
            // Postcondition: The height has been set to the specified value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = OTHER_DEFAULT;
            }
        }//height


      
        public double Weight
        {
            // Precondition:  None
            // Postcondition: The weight has been returned
            get
            {
                return _weight;
            }
            // Precondition:  0 < value
            // Postcondition: The weight has been set to the specified value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = OTHER_DEFAULT;
            }
        }//weight

     
        public int ZoneDistance
        {
            // Precondition:  None
            // Postcondition: The zone distance has been returned
            get
            {
                OriginZip = OriginZip / 10000;
                DestinationZip = DestinationZip / 10000;
                _zoneDistance = Math.Abs(OriginZip - DestinationZip);

                return _zoneDistance;
            }
            
        }


        //pre-condition: oZip > 0
        //               dZip > 0
        //             length > 0
        //              width > 0
        //             height > 0
        //            weight  > 0
        //post-condition: The ground package object has been initialized with the specified
        //                origin zipcode, destination zip code, length, width, height, 
        //                and weight
        public GroundPackage(int oZip, int dZip, double length, double width, double height, double weight)
        {
            OriginZip = oZip;
            DestinationZip = dZip;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }


        //pre-condition: None
        //post-condition: The shipping cost is calculated and returned
        public double CalcCost()
        {
            
            double shippingCost = SIZE_FACTOR*(Length+Width+Height) + WEIGHT_DISTANCE_FACTOR*(ZoneDistance+1)*Weight;
            return shippingCost;
        }


        //pre-condition: None
        //post-condition: A string is returned presenting ground package data
        public override string ToString()
        {
            return $"Origin Zip Code: {OriginZip}{Environment.NewLine}" +
                $"Destination Zip Code: {DestinationZip}{Environment.NewLine}" +
                $"Length: {Length}{Environment.NewLine}" +
                $"Width: {Width}{Environment.NewLine}" +
                $"Height: {Height}{Environment.NewLine}" +
                $"Weight: {Weight}";
        }
    }

    
}
