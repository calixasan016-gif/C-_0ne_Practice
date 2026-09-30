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
            this.lblinfo = new System.Windows.Forms.Button();
            this.lblfood1 = new System.Windows.Forms.Label();
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtprice1 = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtprice2 = new System.Windows.Forms.TextBox();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblfood2 = new System.Windows.Forms.Label();
            this.lblprice2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.Location = new System.Drawing.Point(483, 390);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(161, 48);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Calculate The Price";
            this.lblinfo.UseVisualStyleBackColor = true;
            this.lblinfo.Click += new System.EventHandler(this.lblinfo_Click);
            // 
            // lblfood1
            // 
            this.lblfood1.AutoSize = true;
            this.lblfood1.Location = new System.Drawing.Point(220, 105);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(156, 20);
            this.lblfood1.TabIndex = 1;
            this.lblfood1.Text = "Enter Name Food 1 :";
            // 
            // txtfood1
            // 
            this.txtfood1.Location = new System.Drawing.Point(457, 97);
            this.txtfood1.Multiline = true;
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(204, 38);
            this.txtfood1.TabIndex = 2;
            // 
            // txtprice1
            // 
            this.txtprice1.Location = new System.Drawing.Point(457, 141);
            this.txtprice1.Multiline = true;
            this.txtprice1.Name = "txtprice1";
            this.txtprice1.Size = new System.Drawing.Size(204, 37);
            this.txtprice1.TabIndex = 2;
            this.txtprice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprice1.TextChanged += new System.EventHandler(this.txtprice1_TextChanged);
            // 
            // txtfood2
            // 
            this.txtfood2.Location = new System.Drawing.Point(457, 187);
            this.txtfood2.Multiline = true;
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(204, 37);
            this.txtfood2.TabIndex = 2;
            // 
            // txtprice2
            // 
            this.txtprice2.Location = new System.Drawing.Point(457, 233);
            this.txtprice2.Multiline = true;
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(204, 37);
            this.txtprice2.TabIndex = 2;
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Location = new System.Drawing.Point(220, 144);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(141, 20);
            this.lblPrice1.TabIndex = 1;
            this.lblPrice1.Text = "Enter Price Food 1";
            this.lblPrice1.Click += new System.EventHandler(this.lblPrice1_Click);
            // 
            // lblfood2
            // 
            this.lblfood2.AutoSize = true;
            this.lblfood2.Location = new System.Drawing.Point(220, 190);
            this.lblfood2.Name = "lblfood2";
            this.lblfood2.Size = new System.Drawing.Size(148, 20);
            this.lblfood2.TabIndex = 1;
            this.lblfood2.Text = "Enter Name Food 2";
            // 
            // lblprice2
            // 
            this.lblprice2.AutoSize = true;
            this.lblprice2.Location = new System.Drawing.Point(220, 236);
            this.lblprice2.Name = "lblprice2";
            this.lblprice2.Size = new System.Drawing.Size(141, 20);
            this.lblprice2.TabIndex = 1;
            this.lblprice2.Text = "Enter Price Food 2";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(457, 289);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(204, 86);
            this.txtTotal.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.txtprice1);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtfood1);
            this.Controls.Add(this.lblprice2);
            this.Controls.Add(this.lblfood2);
            this.Controls.Add(this.lblPrice1);
            this.Controls.Add(this.lblfood1);
            this.Controls.Add(this.lblinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblinfo;
        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtprice1;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtprice2;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblfood2;
        private System.Windows.Forms.Label lblprice2;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

