namespace Assignment_3
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
            this.btninfo = new System.Windows.Forms.Button();
            this.lblCustmer = new System.Windows.Forms.Label();
            this.txtCustmer = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtUniPrice = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblUniPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btninfo
            // 
            this.btninfo.BackColor = System.Drawing.Color.Khaki;
            this.btninfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninfo.Location = new System.Drawing.Point(320, 247);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(146, 45);
            this.btninfo.TabIndex = 0;
            this.btninfo.Text = "Calculate Bill";
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // lblCustmer
            // 
            this.lblCustmer.AutoSize = true;
            this.lblCustmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustmer.Location = new System.Drawing.Point(132, 106);
            this.lblCustmer.Name = "lblCustmer";
            this.lblCustmer.Size = new System.Drawing.Size(186, 20);
            this.lblCustmer.TabIndex = 1;
            this.lblCustmer.Text = "Enter Customer Name";
            // 
            // txtCustmer
            // 
            this.txtCustmer.Location = new System.Drawing.Point(449, 100);
            this.txtCustmer.Name = "txtCustmer";
            this.txtCustmer.Size = new System.Drawing.Size(211, 26);
            this.txtCustmer.TabIndex = 2;
            // 
            // txtPrevious
            // 
            this.txtPrevious.Location = new System.Drawing.Point(449, 132);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.Size = new System.Drawing.Size(211, 26);
            this.txtPrevious.TabIndex = 2;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(449, 164);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(211, 26);
            this.txtCurrent.TabIndex = 2;
            // 
            // txtUniPrice
            // 
            this.txtUniPrice.Location = new System.Drawing.Point(449, 196);
            this.txtUniPrice.Name = "txtUniPrice";
            this.txtUniPrice.Size = new System.Drawing.Size(211, 26);
            this.txtUniPrice.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(136, 328);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(524, 124);
            this.txtResult.TabIndex = 2;
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(132, 138);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(198, 20);
            this.lblPrevious.TabIndex = 1;
            this.lblPrevious.Text = "Enter Previous Reading";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(132, 170);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(190, 20);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "Enter Current Reading";
            // 
            // lblUniPrice
            // 
            this.lblUniPrice.AutoSize = true;
            this.lblUniPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniPrice.Location = new System.Drawing.Point(132, 202);
            this.lblUniPrice.Name = "lblUniPrice";
            this.lblUniPrice.Size = new System.Drawing.Size(195, 20);
            this.lblUniPrice.TabIndex = 1;
            this.lblUniPrice.Text = "Enter Price Per Unit ($)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtUniPrice);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtCustmer);
            this.Controls.Add(this.lblUniPrice);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustmer);
            this.Controls.Add(this.btninfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Label lblCustmer;
        private System.Windows.Forms.TextBox txtCustmer;
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtUniPrice;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblUniPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

