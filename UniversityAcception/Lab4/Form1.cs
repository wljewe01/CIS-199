/*
Grading ID: W2904
Lab 4
Due 2/18/18
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int acceptedCount = 0; // count of accepted applications
        int rejectedCount = 0; // count of rejected applications
        public Form1()
        {
            InitializeComponent(); 
            AcceptButton = calcBttn; // allows user to press enter to use the button
           

        }
        // event handler allows the user to click the button and output generated
        private void calcBttn_Click(object sender, EventArgs e)
        {
            double gpa; // user's GPA
            int testScore; //user's test score
           
            double.TryParse(gpaTxtBox.Text, out gpa); //reads in user's gpa only as a double
            int.TryParse(tstScoreTxtBox.Text, out testScore); //reads in user's test score only as an int

            // if the gpa is greater or equal to 3.0 AND the test score is greater or equal to 60
         
            if (gpa >= 3.0)
            {
                if (testScore >= 60)
                {
                    resultsOutputLbl.Text = "Accepted"; //outputs that they are accepted
                    acceptedCount++; // accepted count goes up by 1
                }

            // if the gpa or the test scores don't meet requirements, then they are rejected
           
                else
                {
                    resultsOutputLbl.Text = "Rejected"; //outputs that they are rejected
                    rejectedCount++; // rejected count goes up by 1

                }
            }
          // if the gpa is less than 3.0 but the test score is greater than or equal to 80, then they are accepted
          //and the accepted count goes up by 1
            else
            {
                if (testScore >= 80)
                {
                    resultsOutputLbl.Text = "Accepted"; //outputs that they are accepted
                    acceptedCount++; // accepted count goes up by 1
                }
           // if the gpa is less than 3.0 AND the test score is less than 80, then they are rejected
           // and the rejected count goes up by 1
                else
                {
                    resultsOutputLbl.Text = "Rejected";//outputs that they are rejected
                    rejectedCount++; // rejected count goes up by 1
                }
            }
            //outputs to the user the count of accepted and rejected applications 
            accptOutputLbl.Text = acceptedCount.ToString();
            rjctOutPutLbl.Text = rejectedCount.ToString();


        }
    }
}
