using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingnment_2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            String Dayname = txtname.Text;
            int NumericMonth = int.Parse(txtnumericmonth.Text);
            String MonthName = txtmonth.Text;
            string Year = txtyear.Text;

            txtoutput.Text =
               Dayname + " " +
               NumericMonth + " " +
               MonthName + " " +
               Year;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtnumericmonth.Clear();
            txtmonth.Clear();
            txtyear.Clear();
            txtoutput.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
     }
    }

