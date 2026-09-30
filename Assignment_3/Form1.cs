using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
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

        private void btninfo_Click(object sender, EventArgs e)
        {
            // Creating variables with using try and catch
            try
    {
                string customerName = txtCustmer.Text;
                double previousReading = double.Parse(txtPrevious.Text);
                double currentReading = double.Parse(txtCurrent.Text);
                double pricePerUnit = double.Parse(txtUniPrice.Text);

                double unitsUsed = currentReading - previousReading;
                double electricityCost = unitsUsed * pricePerUnit;
                double tax = electricityCost * 0.05;
                double fixedCharge = 10;
                double totalBill = electricityCost + tax + fixedCharge;

                // Display result
                txtResult.Text =
                    "Customer Name: " + customerName + "\r\n" +
                    "Units Used: " + unitsUsed.ToString("0.00") + "\r\n" +
                    "Electricity Cost: $" + electricityCost.ToString("0.00") + "\r\n" +
                    "Tax: $" + tax.ToString("0.00") + "\r\n" +
                    "Fixed Charge: $" + fixedCharge.ToString("0.00") + "\r\n" +
                    "Total Bill: $" + totalBill.ToString("0.00");
            }
    catch
    {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}
