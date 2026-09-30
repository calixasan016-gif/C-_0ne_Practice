using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

        private void lblinfo_Click(object sender, EventArgs e)
        {
            try
            {
                String food1 = txtfood1.Text;
                int Price1 = int.Parse(txtprice1.Text);
                String food2 = txtfood2.Text;
                int Price2 = int.Parse(txtprice2.Text);


                int tolal = Price1 + Price2;

                Double tax = tolal * 0.075;
                Double tips = tolal * 0.05;
                Double total = tolal + tax + tips;
                
                txtTotal.Text=
                    "tax is: " +tax.ToString("")+ 
                    "total1 is $:" + total.ToString("");
            }
            catch
            {
                MessageBox.Show("Please enter Vailed Price.");
            }
        }
        private void txtprice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice1_Click(object sender, EventArgs e)
        {

        }
    }
}
