/* Grading ID:W9204
 Lab 2
 Due: 2/4/18
 CIS 199-01-4182
 Reads in user input of meal price by a text box in a form, 
 multiplies that number by 3 different tip percentages,
 and then outputs the products into labels */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //calculate and display tips
        private void calculateBttn_Click(object sender, EventArgs e)
        {
            const double tip1 = 0.15; //constant value of first tip %
            const double tip2 = 0.18; //constant value of second tip %
            const double tip3 = 0.20; // constant value of third tip %
            double tip1Total; // holds value of first tip % * meal price
            double tip2Total; //holds value of second tip % *meal price
            double tip3Total; //holds value of third tip % * meal price
            double mealPriceInput; // holds value of meal price input by user

     

            //convert input to decimal
            mealPriceInput = double.Parse(priceTxtBox.Text);

            // calculate tip amounts
            tip1Total = mealPriceInput * tip1;
            tip2Total = mealPriceInput * tip2;
            tip3Total = mealPriceInput * tip3;

            //outputs the total of meal price * tip %

            tip1OutputLbl.Text = $"{tip1Total:C}";
            tip2OutputLbl.Text = $"{tip2Total:C}";
            tip3OutputLbl.Text = $"{tip3Total:C}";



        }

        private void tip2OutputLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
