//W4594
//Lab 7
// 4-1-18
// CIS 199-01
// This program has a form with inputs that are variables of NPV. 
// given the Rate, Years, and desired Future Value, the program will output the appropiate present value





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Precondition: Submit Button Click
        // Postcondition: Values from GUI are parsed and used to fill paramerters for netPresentValue(). result is output to the GUI under present value.
        private void CalcButton_Click(object sender, EventArgs e)
        {
          
            int.TryParse(futValTxt.Text, out int futureValueInput); //parsing Future Value from GUI
            double.TryParse(rateTxt.Text, out double rateInput); // parsing Rate from GUI
             int.TryParse(yearsTxt.Text, out int yearsInput); // parsing Years from GUI

            //using parsed values as the method call, filling the methods parameters
           double result = NetPresentValue(futureValueInput, rateInput, yearsInput);
            presValTxt.Text = Convert.ToString(result.ToString("C")); // converting to string and currency
            
        }

        // Precondition: values entered in the GUI are valid ( future value,years, rate > 0) 
        // Postcondition: values are used in the NPV function and the necessary Present Value is given as Result
        public static double NetPresentValue(int futureValue, double rate, int years)
        {
                                                                // This is using the NPV Formula to create an output
            return (futureValue / Math.Pow((1 + rate), years)); //  NPV = F / (1+R^N) 
        }
    }
}
