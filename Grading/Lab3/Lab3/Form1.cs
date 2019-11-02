/*Grading ID:W9204
 Lab 3
 Due: 2/11/18
 CIS 199-01-4182
 Reads in user input of sphere radius using a text box, 
 then calculates and outputs the diameter, surface area, 
 and volume using labels. Also imports a picture of a sphere. */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{

    // form class
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AcceptButton = calcBttn; // allows user to hit enter to use button 
        }
        // calculate button 
        // event handler allows the button to be clicked, 
        //math to be done, and output to be produced 

        private void calcBttn_Click(object sender, EventArgs e) 
   

        {
            //variables
            double diameter; // holds the sphere diameter
            double surfaceArea; // holds the surface area of the sphere
            double volume; // holds the volume of the sphere
            double radius; // holds the radius of the sphere
            radius = double.Parse(radiusTxtBox.Text); // reads in the user's input of sphere radius

            // math for diameter, surface area, and volume
            diameter = radius * 2;
            surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            volume = ((4 * Math.PI * Math.Pow(radius, 3)) / 3);


            // label outputs
            diameterOutputLbl.Text = $"{diameter:F2}";
            surfaceAreaOutputLbl.Text = $"{surfaceArea:F2}";
            volumeOutputLbl.Text = $"{volume:F2}";
        }
    }
}
