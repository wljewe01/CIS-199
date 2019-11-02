// Exam 2, Part 3
// CIS 199-01
// Spring 2018
// Prompt the user to enter customer id and purchase price. If the
// entered id is found in the list of best customers, receive larger
// discount. Calculated discount and sale price are displayed.

// By: W9204

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2Part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsBestCustomer(string customerID)
        {
            // The best customers
            string[] bestCustomers = { "A1234", "A6543", "B7890", "C5678", "B4321", "A9090", "D8765", "J1122", "E3456", "Z7777" };
            bool theyAreBestCustomer = false;
            for (int i = 0; i<bestCustomers.Length && !theyAreBestCustomer; i++)
            {
                if(customerID==bestCustomers[i])
                {
                    theyAreBestCustomer = true;
                }
            }
            return theyAreBestCustomer;
           
           
        }

        private void calcSalePriceBtn_Click(object sender, EventArgs e)
        {
            const double REG_DISCOUNT = 0.25;  // Discount percentage for regular customers
            const double BEST_DISCOUNT = 0.35; // Discount percentage for best customers

            string customerID;    // Entered customer id
            double purchasePrice; // Entered purchase price
            double discount;      // Calculated discount percentage
            double salePrice;     // Calculated sale price
            bool bestCust = false;
            customerID = idTxt.Text.ToUpper(); // Extracts id and converts to upper case letters

            if (double.TryParse(purchasePriceTxt.Text, out purchasePrice) && purchasePrice > 0) // Try to parse purchase price
            {
                bestCust = IsBestCustomer(customerID);

                if (bestCust == true)
                {
                    discount = BEST_DISCOUNT;
                    discountOutputLbl.Text = discount.ToString("P");
                    salePrice = purchasePrice- purchasePrice * discount;
                    salePriceOutputLbl.Text = salePrice.ToString("C");
                }
                else
                {
                    discount = REG_DISCOUNT;
                    discountOutputLbl.Text = discount.ToString("P");
                    salePrice = purchasePrice - purchasePrice * discount;
                    salePriceOutputLbl.Text = salePrice.ToString("C");
                }
                
            }
            else
            {
                MessageBox.Show("Please enter valid purchase price!");
            }

        }
    }
}
