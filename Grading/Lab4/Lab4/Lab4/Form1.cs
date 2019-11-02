// Grading ID: W2177
// Lab 4
// Due: February 18th, 2018
// CIS 199-01

// This program takes the inputs of GPA and test score from a user
// and determines if they can be admitted into a hypothetical university.
// It also keeps a running total of the number of accpeted and
// rejected students.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Lab4
{
    public partial class LabForm : Form
    {
        int acceptCount; // Running total of accpeted students
        int rejectCount; // Running total of rejected students

        public LabForm()
        {
            InitializeComponent();
        }

        // Determines student eligibility displays running total
        // of accepted and rejected students
        private void testButton_Click(object sender, EventArgs e)
        {
            float gpa;     // GPA as entered by the user
            int testScore; // Test score as entered by the user

            // Determines eligibility
            if (float.TryParse(gpaTxt.Text, out gpa) && (gpa >= 0)) // Ensures GPA is valid
            {
                if (int.TryParse(testScoreTxt.Text, out testScore) && (testScore >= 0) && (testScore <= 100)) // Ensures test score is valid
                {
                    if (gpa >= 3.0 || testScore >= 80) // Checks GPA and test score
                    {
                        resultLbl.Text = "Accept";
                    }
                    else
                    {
                        resultLbl.Text = "Reject";
                    }
                }
                else
                {
                    MessageBox.Show("Enter a vaild test score!");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid GPA!");
            }
            // Calculates and displays running total for each
            if (resultLbl.Text == "Accept") // Reads the result label
            {
                acceptCount += 1;
                acceptCountLbl.Text = $"{acceptCount}";
            }
            else
            {
                rejectCount += 1;
                rejectCountLbl.Text = $"{rejectCount}";
            }
        }
    }
}
