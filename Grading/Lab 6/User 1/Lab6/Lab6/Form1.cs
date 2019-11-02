//W6886
//LAB6
//MARCH 25, 2018
//CIS199-01
// This application allows a user to enter a number of 
//words typed and outputs a letter grade

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            int intNum = Convert.ToInt16(txtNum.Text);
            if (intNum <= 15 & intNum >= 0) // zero to 15
                lblGrade.Text = "F";
            else if (intNum >= 16 & intNum <= 30) // 16 to 30
                lblGrade.Text = "D";
            else if (intNum >= 31 & intNum <= 50) // 31 to 50
                lblGrade.Text = "C";
            else if (intNum >= 51 & intNum <= 75) // 51 to 75
                lblGrade.Text = "B";
            else if (intNum >= 76) //76 to 100+
                lblGrade.Text = "A";
            else
                lblGrade.Text = "Error";
        }
    }
}
