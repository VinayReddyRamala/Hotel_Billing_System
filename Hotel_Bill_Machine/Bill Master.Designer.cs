namespace Hotel_Bill_Machine
{
    partial class Bill_Master
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbillnum = new System.Windows.Forms.TextBox();
            this.btnadditem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtstax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbillamount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttbill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Bill Number";
            // 
            // txtbillnum
            // 
            this.txtbillnum.Location = new System.Drawing.Point(166, 32);
            this.txtbillnum.Name = "txtbillnum";
            this.txtbillnum.Size = new System.Drawing.Size(100, 20);
            this.txtbillnum.TabIndex = 1;
            // 
            // btnadditem
            // 
            this.btnadditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditem.Location = new System.Drawing.Point(294, 30);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(75, 23);
            this.btnadditem.TabIndex = 2;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.UseVisualStyleBackColor = true;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bill Date is";
            // 
            // txtdate
            // 
            this.txtdate.Enabled = false;
            this.txtdate.Location = new System.Drawing.Point(166, 58);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 4;
            this.txtdate.VisibleChanged += new System.EventHandler(this.txtdate_VisibleChanged);
            // 
            // txtstax
            // 
            this.txtstax.Enabled = false;
            this.txtstax.Location = new System.Drawing.Point(166, 110);
            this.txtstax.Name = "txtstax";
            this.txtstax.Size = new System.Drawing.Size(100, 20);
            this.txtstax.TabIndex = 8;
            this.txtstax.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Service Tax is";
            // 
            // txtbillamount
            // 
            this.txtbillamount.Enabled = false;
            this.txtbillamount.Location = new System.Drawing.Point(166, 84);
            this.txtbillamount.Name = "txtbillamount";
            this.txtbillamount.Size = new System.Drawing.Size(100, 20);
            this.txtbillamount.TabIndex = 6;
            this.txtbillamount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bill Amount is";
            // 
            // txttbill
            // 
            this.txttbill.Enabled = false;
            this.txttbill.Location = new System.Drawing.Point(166, 188);
            this.txttbill.Name = "txttbill";
            this.txttbill.Size = new System.Drawing.Size(100, 20);
            this.txttbill.TabIndex = 14;
            this.txttbill.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Bill";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(166, 162);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 20);
            this.txtdiscount.TabIndex = 12;
            this.txtdiscount.Text = "0";
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter Discount";
            // 
            // txtvat
            // 
            this.txtvat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtvat.Enabled = false;
            this.txtvat.Location = new System.Drawing.Point(166, 136);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(100, 20);
            this.txtvat.TabIndex = 10;
            this.txtvat.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "VAT is";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(36, 223);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(129, 223);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(223, 223);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 17;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Bill_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 271);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txttbill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtvat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtstax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbillamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.txtbillnum);
            this.Controls.Add(this.label1);
            this.Name = "Bill_Master";
            this.Text = "Bill_Master";
            this.Load += new System.EventHandler(this.Bill_Master_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadditem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        public System.Windows.Forms.TextBox txtbillnum;
        public System.Windows.Forms.TextBox txtdate;
        public System.Windows.Forms.TextBox txtstax;
        public System.Windows.Forms.TextBox txtbillamount;
        public System.Windows.Forms.TextBox txtvat;
        public System.Windows.Forms.TextBox txttbill;
    }
}