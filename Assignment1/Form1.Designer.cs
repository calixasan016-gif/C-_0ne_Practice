namespace Example_of_ca244
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
            this.lblname = new System.Windows.Forms.Label();
            this.ldlstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.bfnshowinfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(105, 122);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(199, 20);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Enter the student name";
            // 
            // ldlstudentid
            // 
            this.ldlstudentid.AutoSize = true;
            this.ldlstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlstudentid.Location = new System.Drawing.Point(105, 196);
            this.ldlstudentid.Name = "ldlstudentid";
            this.ldlstudentid.Size = new System.Drawing.Size(174, 20);
            this.ldlstudentid.TabIndex = 1;
            this.ldlstudentid.Text = "Enter the student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(105, 270);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(247, 20);
            this.lbldepartment.TabIndex = 1;
            this.lbldepartment.Text = "Enter the student department";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(105, 343);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(229, 20);
            this.lblsemester.TabIndex = 1;
            this.lblsemester.Text = "Enter the student semester";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(395, 108);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(351, 46);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(395, 182);
            this.txtstudentid.Multiline = true;
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(351, 46);
            this.txtstudentid.TabIndex = 2;
            this.txtstudentid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(395, 329);
            this.txtsemester.Multiline = true;
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(351, 46);
            this.txtsemester.TabIndex = 2;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(395, 256);
            this.txtdepartment.Multiline = true;
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(351, 46);
            this.txtdepartment.TabIndex = 2;
            // 
            // lbloutput
            // 
            this.lbloutput.Location = new System.Drawing.Point(109, 405);
            this.lbloutput.Multiline = true;
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(637, 92);
            this.lbloutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(256, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDEN INFORMATION";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnexit.Location = new System.Drawing.Point(553, 521);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(168, 51);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnclear.Location = new System.Drawing.Point(344, 521);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(168, 51);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // bfnshowinfo
            // 
            this.bfnshowinfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bfnshowinfo.Location = new System.Drawing.Point(133, 521);
            this.bfnshowinfo.Name = "bfnshowinfo";
            this.bfnshowinfo.Size = new System.Drawing.Size(168, 51);
            this.bfnshowinfo.TabIndex = 3;
            this.bfnshowinfo.Text = "Show information";
            this.bfnshowinfo.UseVisualStyleBackColor = false;
            this.bfnshowinfo.Click += new System.EventHandler(this.bfnshowinfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 609);
            this.Controls.Add(this.bfnshowinfo);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.ldlstudentid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label ldlstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox lbloutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button bfnshowinfo;
    }
}

