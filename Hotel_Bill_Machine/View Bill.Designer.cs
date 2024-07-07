namespace Hotel_Bill_Machine
{
    partial class View_Bill
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
            this.btnclose = new System.Windows.Forms.Button();
            this.dgvbillmaster = new System.Windows.Forms.DataGridView();
            this.dgvbilltrans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbillnum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbillmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilltrans)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(314, 344);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 18;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dgvbillmaster
            // 
            this.dgvbillmaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbillmaster.Location = new System.Drawing.Point(13, 89);
            this.dgvbillmaster.Name = "dgvbillmaster";
            this.dgvbillmaster.Size = new System.Drawing.Size(807, 71);
            this.dgvbillmaster.TabIndex = 19;
            // 
            // dgvbilltrans
            // 
            this.dgvbilltrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbilltrans.Location = new System.Drawing.Point(15, 188);
            this.dgvbilltrans.Name = "dgvbilltrans";
            this.dgvbilltrans.Size = new System.Drawing.Size(541, 131);
            this.dgvbilltrans.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select Bill Number";
            // 
            // cmbbillnum
            // 
            this.cmbbillnum.FormattingEnabled = true;
            this.cmbbillnum.Location = new System.Drawing.Point(432, 39);
            this.cmbbillnum.Name = "cmbbillnum";
            this.cmbbillnum.Size = new System.Drawing.Size(70, 21);
            this.cmbbillnum.TabIndex = 22;
            this.cmbbillnum.SelectedIndexChanged += new System.EventHandler(this.cmbbillnum_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bill Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Items Details";
            // 
            // View_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbillnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvbilltrans);
            this.Controls.Add(this.dgvbillmaster);
            this.Controls.Add(this.btnclose);
            this.Name = "View_Bill";
            this.Text = "View_Bill";
            this.Load += new System.EventHandler(this.View_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbillmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilltrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dgvbillmaster;
        private System.Windows.Forms.DataGridView dgvbilltrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbillnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}