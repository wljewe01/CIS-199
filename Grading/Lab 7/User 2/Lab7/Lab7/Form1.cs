// Grading ID: W7422
// Lab 7
// CIS199-01
// 4.1.2018 (Happy Easter Fools Day!)
/* This form allows the user to calculate the present value of an investment by entering future value, interest rate and number of years. It does this via a
   value-returning method called CalcPresentValue that uses the NPV formula and returns a PV. Pre- and postconditions are also introduced. */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        // Precondition: Method is performed when the Calculate button is clicked
        // Postcondition: If valid values are entered, the output label will display the user's present value
        private void calcBtn_Click(object sender, EventArgs e)
        {
            double myFV;              // user's FV
            double myRate;            // user's rate
            int myYears;              // user's number of years
            double myPV = 0;          // user's PV (0 is a placeholder value)
            bool validValues = false; // ensures all values entered are valid, used to test whether output is produced

            if (double.TryParse(fvTxt.Text, out myFV)) // nested ifs go input-by-input to check whether a valid value was entered
            {
                if (double.TryParse(rateTxt.Text, out myRate))
                {
                    if (int.TryParse(yearTxt.Text, out myYears))
                    {
                        validValues = true;
                        myPV = CalcPresentValue(myFV, myRate, myYears); // calls the CalcPresentValue method                        
                    }
                    else
                        MessageBox.Show("Please enter a valid number of years"); // error messages are displayed if any inputs are invalid
                }
                else
                    MessageBox.Show("Please enter a valid rate");
            }
            else
                MessageBox.Show("Please enter a valid future value");

            // If all values entered are valid, output is produced in the output label!
            if(validValues)
                outputLbl.Text = $"{myPV:C}";
        }

        // Precondition: User must enter a valid double FV, valid double rate, and valid int number of years
        // Postcondition: Returns the PV to the previous method
        public static double CalcPresentValue(double futureValue, double rate, int numYears)
        {
            double presentValue; // PV
            presentValue = futureValue / (Math.Pow(1 + rate, numYears)); // PV formula
            return presentValue; // PV is returned to the previous method and stored in the myPV variable
        }
    }
}
