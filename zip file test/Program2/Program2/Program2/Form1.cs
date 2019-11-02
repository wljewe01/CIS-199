/*Grading ID: W9204
  CIS 199-01
  Program 2
  This program prompts a user to input GPA and 
  first letter of last name, it then outputs the 
  day that the user would be able to register for classes.
  */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // allows user to hit enter to get results
            InitializeComponent();
            AcceptButton = calcButton;
        }

        //day variables
        const string seniorDay = "Wednesday, March 28";
        const string juniorDay = "Thursday, March 29";
        const string sophOneDay = "Friday, March 30";
        const string sophTwoDay = "Monday, April 2";
        const string freshDayOne = "Tuesday, April 3";
        const string freshDayTwo = "Wednesday, April 4";
        //time variables 
        const string timeOne = "8:30";
        const string timeTwo = "10:00";
        const string timeThree = "11:30";
        const string timeFour = "2:00";
        const string timeFive = "4:00";
        //input variables 
        char lastName;
        double creditHours;
        double senior = 90.0;
        double junior = 60.0;
        double sophomore = 30.0;
        //output strings
        string time;
        string day;

        //event handler allows user to click button and get results 
        private void calcButton_Click(object sender, EventArgs e)
        {


            // input credit hours && last name
            double.TryParse(creditHoursTxtBox.Text, out creditHours);
            char.TryParse(lastNameTxtBox.Text, out lastName);
            lastName = char.ToUpper(lastName);

            //validation, checks to make sure that the user inputs
            //a letter and a double greater than 0
            if (!char.IsLetter(lastName) || creditHours < 0)
            {
                errorLbl.Text = ($"Please enter valid input");
            }
            //if the user inputs correct types, then continue with program
            else
            {
            

                //senior and junior block 

                //calculates time of registration 
                if (creditHours >= junior)
                {

                    if (lastName <= 'D')
                    {
                        time = timeOne;
                    }// if
                    else if (lastName > 'D' && lastName <= 'I')
                    {
                        time = timeTwo;
                    }//else if
                    else if (lastName > 'I' && lastName <= 'O')
                    {
                        time = timeThree;
                    }// else if
                    else if (lastName > 'O' && lastName <= 'S')
                    {
                        time = timeFour;

                    }//else if
                    else
                    {
                        time = timeFive;
                    }// else



                }//calculates day of registration 
                // if senior, then wednesday
                if (creditHours >= senior)
                {
                    day = seniorDay;
                }// if
                else//if junior, then thursday 
                {
                    day = juniorDay;
                }// else





                //calculates sophomore day 1 and time of registration 
                if (creditHours >= sophomore && creditHours < junior && lastName <= 'L')
                {
                    day = sophOneDay;
                    if (lastName <= 'B')
                    {
                        time = timeOne;
                    }// if
                    else if (lastName <= 'D')
                    {
                        time = timeTwo;
                    }// else if
                    else if (lastName <= 'F')
                    {
                        time = timeThree;
                    }// else if
                    else if (lastName <= 'I')
                    {
                        time = timeFour;

                    }// else if
                    else
                    {
                        time = timeFive;
                    }// else
                }// sophmore day 1





                //calculates sophomore day 2 and time of registration 
                if (creditHours >= sophomore && creditHours < junior && lastName >= 'L')
                {
                    day = sophTwoDay;
                    if (lastName <= 'O')
                    {
                        time = timeOne;
                    }//if
                    else if (lastName <= 'Q')
                    {
                        time = timeTwo;
                    }//else if
                    else if (lastName <= 'S')
                    {
                        time = timeThree;
                    }//else if
                    else if (lastName <= 'V')
                    {
                        time = timeFour;
                    }// else if

                    else
                    {
                        time = timeFive;
                    }// else
                }//sophomore day2 block



                //calculates frehsman day 1 and time of registration 
                if (creditHours < sophomore && lastName <= 'L')
                {
                    day = freshDayOne;
                    if (lastName <= 'B')
                    {
                        time = timeOne;
                    }//if
                    else if (lastName <= 'D')
                    {
                        time = timeTwo;
                    }//else if
                    else if (lastName <= 'F')
                    {
                        time = timeThree;
                    }// else if
                    else if (lastName <= 'I')
                    {
                        time = timeFour;

                    }//else if
                    else
                    {
                        time = timeFive;
                    }//else
                }// if freshman day 1 




                //calculates freshman day 2 and time of registration 
                if (creditHours < sophomore && lastName > 'L')
                {
                    day = freshDayTwo;
                    if (lastName <= 'O')
                    {
                        time = timeOne;
                    }
                    else if (lastName <= 'Q')
                    {
                        time = timeTwo;
                    }
                    else if (lastName <= 'S')
                    {
                        time = timeThree;
                    }
                    else if (lastName <= 'V')
                    {
                        time = timeFour;
                    }
                }//if freshman day 2


                //outputs the day and time of registration 
                outPutLbl.Text = ($"{day} at {time}");

            }//validation else 

        }
    }
}
