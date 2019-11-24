/*
Grading ID: W2904
Lab 7
Due 4/1/18
CIS 199-01-4182
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

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AcceptButton = calcButton; // allows user to hit enter to use button 
        }

        //pre condition: futureVal>=0, yearVal >=0, interestVal > 0
        //post condition: calculates and returns required present value
        public static double CalcPresentValue(double futureVal, double interestVal, int yearVal)
        {
          
            
                double presentVal; //value that user will need to invest now
                presentVal = futureVal / (Math.Pow((1 + interestVal), yearVal));
                return presentVal;        
        }



        //pre condition: user must click button or hit enter
        //post condition: performs task 
        private void calcButton_Click(object sender, EventArgs e)
        {

            double futureRate; //value that the user wants to have in the future
            double annualIntRate; //value that holds interest rate 
            int yearRate;// value that holds the number of years for investing 


            double.TryParse(futureValInputTxtBox.Text, out futureRate);
            double.TryParse(intRateInputTxtBox.Text, out annualIntRate);
            int.TryParse(yearsInputTxtBox.Text, out yearRate);


            //checks that the future rate, years, and interest rate are positive numbers
            if (futureRate >= 0 && yearRate >= 0 && annualIntRate > 0)
            {
                prsntValOutputTxtBox.Text = CalcPresentValue(futureRate, annualIntRate, yearRate).ToString("C"); 
            }
            else
            {
                MessageBox.Show("Please enter valid number.");
            }


        }


    }
}
