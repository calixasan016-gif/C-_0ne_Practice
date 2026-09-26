namespace Assingnment_2
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtnumericmonth = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lbldayname = new System.Windows.Forms.Label();
            this.lblnamemonth = new System.Windows.Forms.Label();
            this.lblnumericday = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnclear.Location = new System.Drawing.Point(534, 485);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(159, 49);
            this.btnclear.TabIndex = 0;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnshowinfo.Location = new System.Drawing.Point(335, 485);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(159, 49);
            this.btnshowinfo.TabIndex = 0;
            this.btnshowinfo.Text = "Show";
            this.btnshowinfo.UseVisualStyleBackColor = false;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(137, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 49);
            this.button3.TabIndex = 0;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(394, 90);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(313, 36);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnumericmonth
            // 
            this.txtnumericmonth.Location = new System.Drawing.Point(394, 162);
            this.txtnumericmonth.Multiline = true;
            this.txtnumericmonth.Name = "txtnumericmonth";
            this.txtnumericmonth.Size = new System.Drawing.Size(313, 36);
            this.txtnumericmonth.TabIndex = 1;
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(394, 231);
            this.txtmonth.Multiline = true;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(313, 36);
            this.txtmonth.TabIndex = 1;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(394, 299);
            this.txtyear.Multiline = true;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(313, 36);
            this.txtyear.TabIndex = 1;
            // 
            // lbldayname
            // 
            this.lbldayname.AutoSize = true;
            this.lbldayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayname.Location = new System.Drawing.Point(130, 93);
            this.lbldayname.Name = "lbldayname";
            this.lbldayname.Size = new System.Drawing.Size(202, 25);
            this.lbldayname.TabIndex = 2;
            this.lbldayname.Text = "Enter name of the day";
            // 
            // lblnamemonth
            // 
            this.lblnamemonth.AutoSize = true;
            this.lblnamemonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamemonth.Location = new System.Drawing.Point(110, 234);
            this.lblnamemonth.Name = "lblnamemonth";
            this.lblnamemonth.Size = new System.Drawing.Size(224, 25);
            this.lblnamemonth.TabIndex = 2;
            this.lblnamemonth.Text = "Enter name of the month";
            // 
            // lblnumericday
            // 
            this.lblnumericday.AutoSize = true;
            this.lblnumericday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumericday.Location = new System.Drawing.Point(114, 165);
            this.lblnumericday.Name = "lblnumericday";
            this.lblnumericday.Size = new System.Drawing.Size(222, 25);
            this.lblnumericday.TabIndex = 2;
            this.lblnumericday.Text = "Enter numeric of the day";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(187, 302);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(133, 25);
            this.lblyear.TabIndex = 2;
            this.lblyear.Text = "Enter the year";
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(118, 364);
            this.txtoutput.Multiline = true;
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(589, 87);
            this.txtoutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblnumericday);
            this.Controls.Add(this.lblnamemonth);
            this.Controls.Add(this.lbldayname);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtnumericmonth);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.btnclear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtnumericmonth;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lbldayname;
        private System.Windows.Forms.Label lblnamemonth;
        private System.Windows.Forms.Label lblnumericday;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.TextBox txtoutput;
    }
}

