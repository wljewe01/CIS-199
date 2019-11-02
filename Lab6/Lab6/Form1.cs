/*
Grading ID: W2904
Lab 6
Due 3/25/18
CIS 199-01-4182
This program takes the user's input of words per minute
and then uses parallel arrays to determine the user's grade
based on words per minute. The program then outputs the user's grade.

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
using static System.Console;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AcceptButton = calcBttn;//allows user to hit enter to use button 
        }





        // event handler allows the user to click the button and output generated
        private void calcBttn_Click(object sender, EventArgs e)
        {
          
            int words; // user input 
            int[] wordsPerMinute = { 0, 16, 31, 51, 76 }; //array of words per minute range - lower limits
            string[] grades = { "F", "D", "C", "B", "A" };//array of grades based on words per minute 
            bool found = false; // defaults the users input as not found 
            string assumeGrade = "F"; //assumes the grade is 0 until i is found 

           

            words = int.Parse(inputTxtBox.Text); //input

            int i = wordsPerMinute.Length - 1; //stays within the array 

            if (words < 0) // if user enters number less than 0, error message 
            {
                MessageBox.Show("Please enter valid number");

            }
            else 
            {

                while (i >= 0 && !found) //keeps searching while i is greater than 0 AND it's not found 
                {
                    if (words >= wordsPerMinute[i]) 
                    {
                        found = true;
                    }
                    else
                    {
                        --i;//keep searching
                    }
                }//while

                if (found)//if it is found, then the parallel array grade index is the new assumed grade
                {
                    assumeGrade = grades[i];
                }
                outputLbl.Text = assumeGrade; //output the grade associated with word per minute
            }
        }
    }
}
