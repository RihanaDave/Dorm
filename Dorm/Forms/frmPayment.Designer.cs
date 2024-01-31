namespace PresentationLayer
{
    partial class frmPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.txtDateCheck2 = new System.Windows.Forms.MaskedTextBox();
            this.txtDateCheck1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBoxPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel.Controls.Add(this.btnPrint);
            this.panel.Controls.Add(this.btnRefresh);
            this.panel.Controls.Add(this.btnClear);
            this.panel.Controls.Add(this.btnPayment);
            this.panel.Controls.Add(this.btnExit);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 352);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(757, 71);
            this.panel.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::PresentationLayer.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(623, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 60);
            this.btnPrint.TabIndex = 27;
            this.toolTip.SetToolTip(this.btnPrint, "چاپ رسید");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::PresentationLayer.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(557, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 60);
            this.btnRefresh.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnRefresh, "به روز رسانی");
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Image = global::PresentationLayer.Properties.Resources.Untitled_1;
            this.btnClear.Location = new System.Drawing.Point(491, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 60);
            this.btnClear.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnClear, "پاک کن");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Image = global::PresentationLayer.Properties.Resources.payment1;
            this.btnPayment.Location = new System.Drawing.Point(689, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(60, 60);
            this.btnPayment.TabIndex = 13;
            this.toolTip.SetToolTip(this.btnPayment, "پرداخت ");
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::PresentationLayer.Properties.Resources.exit1;
            this.btnExit.Location = new System.Drawing.Point(8, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnExit, "خروج");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.gridView.Location = new System.Drawing.Point(318, 35);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridView.Size = new System.Drawing.Size(431, 308);
            this.gridView.TabIndex = 1;
            this.gridView.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "نام";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "family";
            this.Column3.HeaderText = "نام خانوادگی";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "fathername";
            this.Column4.HeaderText = "نام پدر";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "number";
            this.Column6.HeaderText = "شماره اتاق";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(318, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(431, 21);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TabStop = false;
            this.toolTip.SetToolTip(this.txtSearch, "جستجو");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ترم تحصیلی :";
            // 
            // cmbTerm
            // 
            this.cmbTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(23, 9);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(195, 21);
            this.cmbTerm.TabIndex = 4;
            this.cmbTerm.SelectionChangeCommitted += new System.EventHandler(this.cmbTerm_SelectionChangeCommitted);
            this.cmbTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTerm_KeyDown);
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.txtDateCheck2);
            this.groupBoxPayment.Controls.Add(this.txtDateCheck1);
            this.groupBoxPayment.Controls.Add(this.label4);
            this.groupBoxPayment.Controls.Add(this.label3);
            this.groupBoxPayment.Controls.Add(this.txtPrice1);
            this.groupBoxPayment.Controls.Add(this.txtPrice2);
            this.groupBoxPayment.Controls.Add(this.txtPrice3);
            this.groupBoxPayment.Controls.Add(this.chkCheck2);
            this.groupBoxPayment.Controls.Add(this.txtNumberCheck2);
            this.groupBoxPayment.Controls.Add(this.label7);
            this.groupBoxPayment.Controls.Add(this.label19);
            this.groupBoxPayment.Controls.Add(this.chkCheck1);
            this.groupBoxPayment.Controls.Add(this.txtNumberCheck1);
            this.groupBoxPayment.Controls.Add(this.label2);
            this.groupBoxPayment.Controls.Add(this.label8);
            this.groupBoxPayment.Controls.Add(this.chkCash);
            this.groupBoxPayment.Controls.Add(this.label13);
            this.groupBoxPayment.Location = new System.Drawing.Point(8, 28);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(304, 315);
            this.groupBoxPayment.TabIndex = 26;
            this.groupBoxPayment.TabStop = false;
            // 
            // txtDateCheck2
            // 
            this.txtDateCheck2.Location = new System.Drawing.Point(111, 275);
            this.txtDateCheck2.Mask = "0000/00/00";
            this.txtDateCheck2.Name = "txtDateCheck2";
            this.txtDateCheck2.Size = new System.Drawing.Size(100, 21);
            this.txtDateCheck2.TabIndex = 140;
            // 
            // txtDateCheck1
            // 
            this.txtDateCheck1.Location = new System.Drawing.Point(110, 157);
            this.txtDateCheck1.Mask = "0000/00/00";
            this.txtDateCheck1.Name = "txtDateCheck1";
            this.txtDateCheck1.Size = new System.Drawing.Size(100, 21);
            this.txtDateCheck1.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 224);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 138;
            this.label4.Text = " مبلغ ( تومان) :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 106);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = " مبلغ ( تومان) :\r\n";
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(76, 42);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice1.Size = new System.Drawing.Size(135, 21);
            this.txtPrice1.TabIndex = 136;
            this.txtPrice1.TabStop = false;
            this.txtPrice1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice1_KeyPress);
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(76, 103);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice2.Size = new System.Drawing.Size(134, 21);
            this.txtPrice2.TabIndex = 135;
            this.txtPrice2.TabStop = false;
            this.txtPrice2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice1_KeyPress);
            // 
            // txtPrice3
            // 
            this.txtPrice3.Location = new System.Drawing.Point(76, 221);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice3.Size = new System.Drawing.Size(135, 21);
            this.txtPrice3.TabIndex = 134;
            this.txtPrice3.TabStop = false;
            this.txtPrice3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice1_KeyPress);
            // 
            // chkCheck2
            // 
            this.chkCheck2.AutoSize = true;
            this.chkCheck2.Location = new System.Drawing.Point(158, 198);
            this.chkCheck2.Name = "chkCheck2";
            this.chkCheck2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCheck2.Size = new System.Drawing.Size(49, 17);
            this.chkCheck2.TabIndex = 118;
            this.chkCheck2.Text = "چک2 ";
            this.chkCheck2.UseVisualStyleBackColor = true;
            this.chkCheck2.CheckedChanged += new System.EventHandler(this.chkCheck2_CheckedChanged);
            // 
            // txtNumberCheck2
            // 
            this.txtNumberCheck2.Location = new System.Drawing.Point(16, 248);
            this.txtNumberCheck2.Name = "txtNumberCheck2";
            this.txtNumberCheck2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberCheck2.Size = new System.Drawing.Size(195, 21);
            this.txtNumberCheck2.TabIndex = 112;
            this.txtNumberCheck2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 251);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "شماره چک :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(212, 278);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 114;
            this.label19.Text = "تاریخ چک :";
            // 
            // chkCheck1
            // 
            this.chkCheck1.AutoSize = true;
            this.chkCheck1.Location = new System.Drawing.Point(161, 80);
            this.chkCheck1.Name = "chkCheck1";
            this.chkCheck1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCheck1.Size = new System.Drawing.Size(46, 17);
            this.chkCheck1.TabIndex = 111;
            this.chkCheck1.Text = "چک1";
            this.chkCheck1.UseVisualStyleBackColor = true;
            this.chkCheck1.CheckedChanged += new System.EventHandler(this.chkCheck1_CheckedChanged);
            // 
            // txtNumberCheck1
            // 
            this.txtNumberCheck1.Location = new System.Drawing.Point(15, 130);
            this.txtNumberCheck1.Name = "txtNumberCheck1";
            this.txtNumberCheck1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberCheck1.Size = new System.Drawing.Size(196, 21);
            this.txtNumberCheck1.TabIndex = 108;
            this.txtNumberCheck1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 133);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "شماره چک :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 160);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "تاریخ چک :";
            // 
            // chkCash
            // 
            this.chkCash.AutoSize = true;
            this.chkCash.Location = new System.Drawing.Point(124, 16);
            this.chkCash.Name = "chkCash";
            this.chkCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCash.Size = new System.Drawing.Size(85, 17);
            this.chkCash.TabIndex = 104;
            this.chkCash.TabStop = false;
            this.chkCash.Text = "پرداخت نقدی";
            this.chkCash.UseVisualStyleBackColor = true;
            this.chkCash.CheckedChanged += new System.EventHandler(this.chkCash_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 45);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 102;
            this.label13.Text = " مبلغ ( تومان) :\r\n";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(757, 423);
            this.Controls.Add(this.groupBoxPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTerm);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرداخت شهریه";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.CheckBox chkCheck2;
        private System.Windows.Forms.TextBox txtNumberCheck2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkCheck1;
        private System.Windows.Forms.TextBox txtNumberCheck1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkCash;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtPrice3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.MaskedTextBox txtDateCheck1;
        private System.Windows.Forms.MaskedTextBox txtDateCheck2;
        private System.Windows.Forms.ToolTip toolTip;
    }
}