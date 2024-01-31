namespace PresentationLayer
{
    partial class frmStudentPayment
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
            this.components = new System.ComponentModel.Container();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtDateCheck2 = new System.Windows.Forms.MaskedTextBox();
            this.txtDateCheck1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtPrice3 = new System.Windows.Forms.TextBox();
            this.chkCheck2 = new System.Windows.Forms.CheckBox();
            this.txtNumberCheck2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.chkCheck1 = new System.Windows.Forms.CheckBox();
            this.txtNumberCheck1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkCash = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtDateCheck2);
            this.groupBox.Controls.Add(this.txtDateCheck1);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Controls.Add(this.txtPrice1);
            this.groupBox.Controls.Add(this.txtPrice2);
            this.groupBox.Controls.Add(this.txtPrice3);
            this.groupBox.Controls.Add(this.chkCheck2);
            this.groupBox.Controls.Add(this.txtNumberCheck2);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label19);
            this.groupBox.Controls.Add(this.chkCheck1);
            this.groupBox.Controls.Add(this.txtNumberCheck1);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.chkCash);
            this.groupBox.Location = new System.Drawing.Point(9, 32);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(537, 197);
            this.groupBox.TabIndex = 29;
            this.groupBox.TabStop = false;
            // 
            // txtDateCheck2
            // 
            this.txtDateCheck2.Location = new System.Drawing.Point(68, 163);
            this.txtDateCheck2.Mask = "0000/00/00";
            this.txtDateCheck2.Name = "txtDateCheck2";
            this.txtDateCheck2.Size = new System.Drawing.Size(100, 21);
            this.txtDateCheck2.TabIndex = 35;
            // 
            // txtDateCheck1
            // 
            this.txtDateCheck1.Location = new System.Drawing.Point(68, 102);
            this.txtDateCheck1.Mask = "0000/00/00";
            this.txtDateCheck1.Name = "txtDateCheck1";
            this.txtDateCheck1.Size = new System.Drawing.Size(100, 21);
            this.txtDateCheck1.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 166);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = " مبلغ ( تومان) :\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 105);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 138;
            this.label4.Text = " مبلغ ( تومان) :\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(447, 49);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 137;
            this.label13.Text = " مبلغ ( تومان) :\r\n";
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(343, 46);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice1.Size = new System.Drawing.Size(100, 21);
            this.txtPrice1.TabIndex = 2;
            this.txtPrice1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice1_KeyPress);
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(343, 102);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice2.Size = new System.Drawing.Size(100, 21);
            this.txtPrice2.TabIndex = 4;
            this.txtPrice2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice1_KeyPress);
            // 
            // txtPrice3
            // 
            this.txtPrice3.Location = new System.Drawing.Point(339, 163);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice3.Size = new System.Drawing.Size(100, 21);
            this.txtPrice3.TabIndex = 8;
            this.txtPrice3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice1_KeyPress);
            // 
            // chkCheck2
            // 
            this.chkCheck2.AutoSize = true;
            this.chkCheck2.Location = new System.Drawing.Point(387, 140);
            this.chkCheck2.Name = "chkCheck2";
            this.chkCheck2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCheck2.Size = new System.Drawing.Size(49, 17);
            this.chkCheck2.TabIndex = 7;
            this.chkCheck2.Text = "چک2 ";
            this.chkCheck2.UseVisualStyleBackColor = true;
            this.chkCheck2.CheckedChanged += new System.EventHandler(this.chkCheck2_CheckedChanged);
            // 
            // txtNumberCheck2
            // 
            this.txtNumberCheck2.Location = new System.Drawing.Point(181, 163);
            this.txtNumberCheck2.Name = "txtNumberCheck2";
            this.txtNumberCheck2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberCheck2.Size = new System.Drawing.Size(147, 21);
            this.txtNumberCheck2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 144);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "شماره چک :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(108, 144);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 114;
            this.label19.Text = "تاریخ چک :";
            // 
            // chkCheck1
            // 
            this.chkCheck1.AutoSize = true;
            this.chkCheck1.Location = new System.Drawing.Point(393, 82);
            this.chkCheck1.Name = "chkCheck1";
            this.chkCheck1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCheck1.Size = new System.Drawing.Size(46, 17);
            this.chkCheck1.TabIndex = 3;
            this.chkCheck1.Text = "چک1";
            this.chkCheck1.UseVisualStyleBackColor = true;
            this.chkCheck1.CheckedChanged += new System.EventHandler(this.chkCheck1_CheckedChanged);
            // 
            // txtNumberCheck1
            // 
            this.txtNumberCheck1.Location = new System.Drawing.Point(181, 102);
            this.txtNumberCheck1.Name = "txtNumberCheck1";
            this.txtNumberCheck1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberCheck1.Size = new System.Drawing.Size(147, 21);
            this.txtNumberCheck1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "شماره چک :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 82);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "تاریخ چک :";
            // 
            // chkCash
            // 
            this.chkCash.AutoSize = true;
            this.chkCash.Location = new System.Drawing.Point(356, 19);
            this.chkCash.Name = "chkCash";
            this.chkCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCash.Size = new System.Drawing.Size(85, 17);
            this.chkCash.TabIndex = 1;
            this.chkCash.Text = "پرداخت نقدی";
            this.chkCash.UseVisualStyleBackColor = true;
            this.chkCash.CheckedChanged += new System.EventHandler(this.chkCash_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ترم تحصیلی :";
            // 
            // cmbTerm
            // 
            this.cmbTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(317, 8);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(135, 21);
            this.cmbTerm.TabIndex = 0;
            this.cmbTerm.SelectionChangeCommitted += new System.EventHandler(this.cmbTerm_SelectionChangeCommitted);
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel.Controls.Add(this.btnPrint);
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.btnPayment);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 236);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(555, 73);
            this.panel.TabIndex = 30;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::PresentationLayer.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(417, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 60);
            this.btnPrint.TabIndex = 14;
            this.toolTip.SetToolTip(this.btnPrint, "چاپ رسید");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::PresentationLayer.Properties.Resources.exit1;
            this.btnExit.Location = new System.Drawing.Point(8, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 13;
            this.toolTip.SetToolTip(this.btnExit, "خروج");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Image = global::PresentationLayer.Properties.Resources.payment1;
            this.btnPayment.Location = new System.Drawing.Point(483, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(60, 60);
            this.btnPayment.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnPayment, "پرداخت ");
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 11);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "نام خانوادگی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 11);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "نام :";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(36, 11);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFamily.Size = new System.Drawing.Size(35, 13);
            this.lblFamily.TabIndex = 33;
            this.lblFamily.Text = "label9";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(190, 11);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "label10";
            // 
            // frmStudentPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(555, 309);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTerm);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentPayment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرداخت شهریه";
            this.Load += new System.EventHandler(this.frmStudentPayment_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox chkCheck2;
        private System.Windows.Forms.TextBox txtNumberCheck2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkCheck1;
        private System.Windows.Forms.TextBox txtNumberCheck1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkCash;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtPrice3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.MaskedTextBox txtDateCheck2;
        private System.Windows.Forms.MaskedTextBox txtDateCheck1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}