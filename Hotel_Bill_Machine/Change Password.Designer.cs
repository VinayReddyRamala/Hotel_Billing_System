namespace Hotel_Bill_Machine
{
    partial class ChangePassword
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
            this.radiooldpass = new System.Windows.Forms.RadioButton();
            this.radiohques = new System.Windows.Forms.RadioButton();
            this.txthques = new System.Windows.Forms.Label();
            this.cmbhques = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthanswer = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.cmbfname = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salect Type";
            // 
            // radiooldpass
            // 
            this.radiooldpass.AutoSize = true;
            this.radiooldpass.Checked = true;
            this.radiooldpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiooldpass.Location = new System.Drawing.Point(42, 66);
            this.radiooldpass.Name = "radiooldpass";
            this.radiooldpass.Size = new System.Drawing.Size(138, 17);
            this.radiooldpass.TabIndex = 1;
            this.radiooldpass.TabStop = true;
            this.radiooldpass.Text = "Using Old Password";
            this.radiooldpass.UseVisualStyleBackColor = true;
            this.radiooldpass.CheckedChanged += new System.EventHandler(this.radiooldpass_CheckedChanged);
            // 
            // radiohques
            // 
            this.radiohques.AutoSize = true;
            this.radiohques.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiohques.Location = new System.Drawing.Point(186, 66);
            this.radiohques.Name = "radiohques";
            this.radiohques.Size = new System.Drawing.Size(135, 20);
            this.radiohques.TabIndex = 2;
            this.radiohques.Text = "Using Hint Question";
            this.radiohques.UseVisualStyleBackColor = true;
            this.radiohques.CheckedChanged += new System.EventHandler(this.radiohques_CheckedChanged);
            // 
            // txthques
            // 
            this.txthques.AutoSize = true;
            this.txthques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthques.Location = new System.Drawing.Point(39, 103);
            this.txthques.Name = "txthques";
            this.txthques.Size = new System.Drawing.Size(147, 16);
            this.txthques.TabIndex = 3;
            this.txthques.Text = "Select Hint Question";
            this.txthques.Visible = false;
            // 
            // cmbhques
            // 
            this.cmbhques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbhques.FormattingEnabled = true;
            this.cmbhques.Location = new System.Drawing.Point(192, 100);
            this.cmbhques.Name = "cmbhques";
            this.cmbhques.Size = new System.Drawing.Size(121, 23);
            this.cmbhques.TabIndex = 4;
            this.cmbhques.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Old Password";
            // 
            // txthanswer
            // 
            this.txthanswer.Location = new System.Drawing.Point(192, 127);
            this.txthanswer.Name = "txthanswer";
            this.txthanswer.Size = new System.Drawing.Size(121, 20);
            this.txthanswer.TabIndex = 6;
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(192, 153);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(121, 20);
            this.txtnewpass.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter New Password";
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(192, 179);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.Size = new System.Drawing.Size(121, 20);
            this.txtrepass.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Re-Enter Password";
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(192, 222);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 26);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(84, 222);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 26);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // cmbfname
            // 
            this.cmbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfname.FormattingEnabled = true;
            this.cmbfname.Location = new System.Drawing.Point(192, 100);
            this.cmbfname.Name = "cmbfname";
            this.cmbfname.Size = new System.Drawing.Size(121, 23);
            this.cmbfname.TabIndex = 13;
            this.cmbfname.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 276);
            this.Controls.Add(this.cmbfname);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtrepass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthanswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbhques);
            this.Controls.Add(this.txthques);
            this.Controls.Add(this.radiohques);
            this.Controls.Add(this.radiooldpass);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiooldpass;
        private System.Windows.Forms.RadioButton radiohques;
        private System.Windows.Forms.Label txthques;
        private System.Windows.Forms.ComboBox cmbhques;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthanswer;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrepass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ComboBox cmbfname;
    }
}