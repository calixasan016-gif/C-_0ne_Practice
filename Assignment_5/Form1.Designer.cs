namespace Airline_Ticket_Booking_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.Groupbox3 = new System.Windows.Forms.GroupBox();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.cmbClass = new System.Windows.Forms.GroupBox();
            this.rdbFirst = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbBusiness = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBaggage = new System.Windows.Forms.TextBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Groupbox3.SuspendLayout();
            this.cmbClass.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // Groupbox3
            // 
            this.Groupbox3.Controls.Add(this.checkbox1);
            this.Groupbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupbox3.Location = new System.Drawing.Point(13, 352);
            this.Groupbox3.Name = "Groupbox3";
            this.Groupbox3.Size = new System.Drawing.Size(525, 78);
            this.Groupbox3.TabIndex = 12;
            this.Groupbox3.TabStop = false;
            this.Groupbox3.Text = "Aditional Options";
            // 
            // checkbox1
            // 
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(26, 33);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(437, 39);
            this.checkbox1.TabIndex = 0;
            this.checkbox1.Text = "AddTravel insurance ($25 Per ticket)";
            this.checkbox1.UseVisualStyleBackColor = true;
            // 
            // cmbClass
            // 
            this.cmbClass.Controls.Add(this.rdbFirst);
            this.cmbClass.Controls.Add(this.rdbNormal);
            this.cmbClass.Controls.Add(this.rdbBusiness);
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.Location = new System.Drawing.Point(12, 256);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(527, 86);
            this.cmbClass.TabIndex = 11;
            this.cmbClass.TabStop = false;
            this.cmbClass.Text = "Travel Class";
            // 
            // rdbFirst
            // 
            this.rdbFirst.AutoSize = true;
            this.rdbFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFirst.Location = new System.Drawing.Point(12, 40);
            this.rdbFirst.Name = "rdbFirst";
            this.rdbFirst.Size = new System.Drawing.Size(119, 24);
            this.rdbFirst.TabIndex = 0;
            this.rdbFirst.TabStop = true;
            this.rdbFirst.Text = "First Class";
            this.rdbFirst.UseVisualStyleBackColor = true;
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormal.Location = new System.Drawing.Point(198, 40);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(139, 24);
            this.rdbNormal.TabIndex = 1;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal Class";
            this.rdbNormal.UseVisualStyleBackColor = true;
            // 
            // rdbBusiness
            // 
            this.rdbBusiness.AutoSize = true;
            this.rdbBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBusiness.Location = new System.Drawing.Point(350, 40);
            this.rdbBusiness.Name = "rdbBusiness";
            this.rdbBusiness.Size = new System.Drawing.Size(156, 24);
            this.rdbBusiness.TabIndex = 2;
            this.rdbBusiness.TabStop = true;
            this.rdbBusiness.Text = "Business Class";
            this.rdbBusiness.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.txtTickets);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.txtBaggage);
            this.groupBox1.Controls.Add(this.lblTicket);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 214);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(207, 121);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(224, 26);
            this.txtTickets.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(155, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Passenger Name :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(56, 81);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(141, 20);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Passenger Age :";
            // 
            // txtBaggage
            // 
            this.txtBaggage.Location = new System.Drawing.Point(207, 164);
            this.txtBaggage.Name = "txtBaggage";
            this.txtBaggage.Size = new System.Drawing.Size(224, 26);
            this.txtBaggage.TabIndex = 4;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(37, 127);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(164, 20);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Number of Tickets :";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(23, 170);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(179, 20);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Baggege weight(kg) :";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(207, 75);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(224, 26);
            this.txtAge.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(207, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(584, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(461, 424);
            this.listBox1.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(379, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 53);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(197, 453);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 53);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(12, 453);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(163, 53);
            this.btninfo.TabIndex = 10;
            this.btninfo.Text = "Calculate";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 676);
            this.Controls.Add(this.Groupbox3);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Groupbox3.ResumeLayout(false);
            this.cmbClass.ResumeLayout(false);
            this.cmbClass.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Groupbox3;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.GroupBox cmbClass;
        private System.Windows.Forms.RadioButton rdbFirst;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbBusiness;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBaggage;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Label label1;
    }
}

