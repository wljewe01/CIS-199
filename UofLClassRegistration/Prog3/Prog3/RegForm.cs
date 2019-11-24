// Program 2
// CIS 199-01
// Due: 3/31/2018
// By:  W9204


using System;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        // Find and display earliest registration time
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "March 28"; // 1st day of registration
            const string DAY2 = "March 29"; // 2nd day of registration
            const string DAY3 = "March 30"; // 3rd day of registration
            const string DAY4 = "April 2";  // 4th day of registration
            const string DAY5 = "April 3";  // 5th day of registration
            const string DAY6 = "April 4";  // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            const float SOPHOMORE = 30; // Hours needed to be sophomore
            const float JUNIOR = 60;    // Hours needed to be junior
            const float SENIOR = 90;    // Hours needed to be senior

            string lastNameStr;         // Entered last name
            char lastNameLetterCh;      // First letter of last name, as char
            string dateStr = "Error";   // Holds date of registration
            string timeStr = "Error";   // Holds time of registration
            float creditHours;          // Previously earned credit hours
            bool isUpperClass;          // Upperclass or not?
           


            lastNameStr = lastNameTxt.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name
                lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case
                

                if (float.TryParse(creditHoursTxt.Text, out creditHours) && creditHours >= 0)
                {
                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        isUpperClass = (creditHours >= JUNIOR);
                        // Juniors and Seniors share same schedule but different days
                        if (isUpperClass)
                        {
                            char[] letters = { 'A', 'E', 'J', 'P', 'T' }; // lower limits for last names
                            string[] times = { TIME1, TIME2, TIME3, TIME4, TIME5 }; //different times of registration 
                            bool found = false; // default, last name char not found yet 

                            if (creditHours >= SENIOR)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;
                            int i = letters.Length - 1;
                            while (i >= 0 && !found)
                            {

                                if (lastNameLetterCh >= letters[i]) 
                                {
                                    found = true;
                                }//if
                                else
                                {
                                    --i;
                                }//else

                                if (found)
                                    timeStr = times[i];
                               
                            }//while
                        }
                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {

                            if (creditHours >= SOPHOMORE)
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= 'L'))   // <= L
                                    dateStr = DAY3;
                                else // All other letters on next day
                                    dateStr = DAY4;
                            }
                            else // must be freshman
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= 'L'))   // <= L
                                    dateStr = DAY5;
                                else // All other letters on next day
                                    dateStr = DAY6;
                            }


                            char[] letters = { 'A', 'C', 'E', 'G', 'J','M','P','R','T','W' }; //lower limit of last names
                        
                            string[] times = { TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, TIME5 }; //different times of registration 
                            bool found = false; //default value, last name char not found yet 

                            int i = letters.Length - 1;
                            while (i >= 0 && !found)
                            {

                                if (lastNameLetterCh >= letters[i])
                                {
                                    found = true;
                                }//if
                                else
                                {
                                    --i;
                                }//else

                                if (found)
                                    timeStr = times[i];

                            }//while

                        }

                        // Output results
                        dateTimeLbl.Text = dateStr + " at " + timeStr;
                    }
                    else // Not A-Z
                        MessageBox.Show("Make sure last name starts with a letter!");
                }
                else
                    MessageBox.Show("Enter a valid number of credit hours!");
            }
            else // Empty textbox
                MessageBox.Show("Please enter last name!");
        }
    }
}
