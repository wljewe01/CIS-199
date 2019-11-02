// Grading ID: W2613
// Lab #: Lab2 
// Due Date: 02/04/2018
// Section #: Section 01
//  Breif: Computes and calculates Tip from user input amount

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
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MealTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            //Declared Variables

            double MealPrice; // User input meal price
            double LowTip; // calculation for 15% tip
            double MediumTip; // calculation for 18% tip
            double HighTip; // calculation for 20% tip
            const double LowRate = .15; // variable for 15% tip
            const double MedRate = .18; // variable for 18% tip
            const double HighRate = .20; // variable for 20% tip

            
            //Input Collected
            MealPrice = double.Parse(MealTextBox.Text);

            //Tip Calculations 
            LowTip = MealPrice * LowRate;
            MediumTip = MealPrice * MedRate;
            HighTip = MealPrice * HighRate;

            // Output 
            LowTipL.Text = ($"{LowTip:C2}");
            MediumTipL.Text= ($"{MediumTip:C2}");
            HighTipL.Text=($"{HighTip:C2}");




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
