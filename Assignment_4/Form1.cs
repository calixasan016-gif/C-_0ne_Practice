using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            // Creating Variables
            int age, tickets;
            double baggage;

            // Validate Age
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Enter valid age");
                return;
            }

            // Validate Tickets
            if (!int.TryParse(txtTickets.Text, out tickets))
            {
                MessageBox.Show("Enter valid number of tickets");
                return;
            }

            // Validate Baggage
            if (!double.TryParse(txtBaggage.Text, out baggage))
            {
                MessageBox.Show("Enter valid baggage weight");
                return;
            }

            // Booking Validation
            if (age < 1 || age > 100)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Rejected: Age must be 1-100");
                return;
            }
            else if (tickets < 1 || tickets > 5)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Rejected: Tickets must be 1-5");
                return;
            }
            else if (baggage < 0 || baggage > 50)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Rejected: Baggage must be 0-50 kg");
                return;
            }
            else if (age < 12 && rdbFirst.Checked == true)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(
                    "Rejected: Child cannot book First Class");
                return;
            }

            // Determine Ticket Price
            double ticketPrice = 0;
            string travelClass = "";

            if (rdbFirst.Checked == true)
            {
                ticketPrice = 300;
                travelClass = "First Class";
            }
            else if (rdbNormal.Checked == true)
            {
                ticketPrice = 100;
                travelClass = "Normal Class";
            }
            else if (rdbBusiness.Checked == true)
            {
                ticketPrice = 200;
                travelClass = "Business Class";
            }
            else
            {
                MessageBox.Show("Please Select Travel Class");
                return;
            }

            // Basic Ticket Cost
            double basicCost = ticketPrice * tickets;
            double total = basicCost;

            // Ticket Discount
            double ticketDiscount = 0;

            if (tickets >= 3 && tickets <= 4)
                ticketDiscount = total * 0.05;
            else if (tickets == 5)
                ticketDiscount = total * 0.10;

            total = total - ticketDiscount;

            // Child Discount
            double childDiscount = 0;

            if (age < 12)
            {
                childDiscount = total * 0.20;
                total = total - childDiscount;
            }

            // Senior Discount
            double seniorDiscount = 0;

            if (age >= 60)
            {
                seniorDiscount = total * 0.10;
                total = total - seniorDiscount;
            }

            // Travel Insurance
            double insuranceCost = 0;

            if (checkbox1.Checked == true)
            {
                insuranceCost = 25 * tickets;
                total = total + insuranceCost;
            }

            // Baggage Cost
            double baggageCost = 0;

            if (baggage > 20)
            {
                baggageCost = (baggage - 20) * 10;
                total = total + baggageCost;
            }

            // Display Results in ListBox
            listBox1.Items.Clear();

            listBox1.Items.Add("FLIGHT BOOKING APPROVED");
            listBox1.Items.Add("----------------------------");
            listBox1.Items.Add("Passenger Age: " + age);
            listBox1.Items.Add("Travel Class: " + travelClass);
            listBox1.Items.Add("Number of Tickets: " + tickets);
            listBox1.Items.Add("Baggage Weight: " + baggage + " kg");
            listBox1.Items.Add("----------------------------");
            listBox1.Items.Add("Ticket Price: $" + ticketPrice);
            listBox1.Items.Add("Basic Cost: $" + basicCost.ToString("0.00"));
            listBox1.Items.Add("Ticket Discount: $" + ticketDiscount.ToString("0.00"));
            listBox1.Items.Add("Child Discount: $" + childDiscount.ToString("0.00"));
            listBox1.Items.Add("Senior Discount: $" + seniorDiscount.ToString("0.00"));
            listBox1.Items.Add("Insurance Cost: $" + insuranceCost.ToString("0.00"));
            listBox1.Items.Add("Baggage Cost: $" + baggageCost.ToString("0.00"));
            listBox1.Items.Add("----------------------------");
            listBox1.Items.Add("TOTAL COST: $" + total.ToString("0.00"));
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtTickets.Clear();
            txtBaggage.Clear();

            rdbFirst.Checked = false;
            rdbNormal.Checked = false;
            rdbBusiness.Checked = false;

            checkbox1.Checked = false;
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
