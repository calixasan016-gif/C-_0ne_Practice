using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_of_ca244
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bfnshowinfo_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            int studentid = int.Parse(txtstudentid.Text);
            String department = txtdepartment.Text;
            int semester = int.Parse(txtsemester.Text);

            lbloutput.Text = "Student Name: " + name +

                             "\r\nStudent ID: " + studentid +

                             "\r\nDepartment: " + department +

                             "\r\nSemester: " + semester;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
