namespace PresentationLayer
{
    partial class frmPaymentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewPaymentList = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPaymentTotal = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.lblDebtorsTtotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentList)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewStudent
            // 
            this.gridViewStudent.AllowUserToAddRows = false;
            this.gridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridViewStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column12,
            this.Column13});
            this.gridViewStudent.Location = new System.Drawing.Point(292, 36);
            this.gridViewStudent.MultiSelect = false;
            this.gridViewStudent.Name = "gridViewStudent";
            this.gridViewStudent.ReadOnly = true;
            this.gridViewStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridViewStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewStudent.Size = new System.Drawing.Size(425, 230);
            this.gridViewStudent.TabIndex = 2;
            this.gridViewStudent.TabStop = false;
            this.gridViewStudent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewStudent_CellEnter);
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
            // Column12
            // 
            this.Column12.DataPropertyName = "fathername";
            this.Column12.HeaderText = "نام پدر";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.DataPropertyName = "number";
            this.Column13.HeaderText = "شماره اتاق";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // cmbTerm
            // 
            this.cmbTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(37, 26);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(206, 21);
            this.cmbTerm.TabIndex = 0;
            this.cmbTerm.SelectionChangeCommitted += new System.EventHandler(this.cmbTerm_SelectionChangeCommitted);
            this.cmbTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTerm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 8);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ترم تحصیلی :";
            // 
            // gridViewPaymentList
            // 
            this.gridViewPaymentList.AllowUserToAddRows = false;
            this.gridViewPaymentList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridViewPaymentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPaymentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column5,
            this.Column6});
            this.gridViewPaymentList.Location = new System.Drawing.Point(8, 272);
            this.gridViewPaymentList.MultiSelect = false;
            this.gridViewPaymentList.Name = "gridViewPaymentList";
            this.gridViewPaymentList.ReadOnly = true;
            this.gridViewPaymentList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridViewPaymentList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewPaymentList.Size = new System.Drawing.Size(709, 150);
            this.gridViewPaymentList.TabIndex = 5;
            this.gridViewPaymentList.TabStop = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "UserName";
            this.Column7.HeaderText = "دریافت کننده";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PayType";
            this.Column8.HeaderText = "نوع پرداخت";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "price";
            this.Column9.HeaderText = "مبلغ ( تومان )";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "date";
            this.Column10.HeaderText = "تاریخ";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "checkdate";
            this.Column5.HeaderText = "تاریخ چک";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "checknumber";
            this.Column6.HeaderText = "شماره چک";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(292, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(425, 21);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TabStop = false;
            this.toolTip.SetToolTip(this.txtSearch, "جستجو");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::PresentationLayer.Properties.Resources.exit1;
            this.btnExit.Location = new System.Drawing.Point(8, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnExit, "خروج");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPaymentTotal
            // 
            this.lblPaymentTotal.AutoSize = true;
            this.lblPaymentTotal.Location = new System.Drawing.Point(50, 119);
            this.lblPaymentTotal.Name = "lblPaymentTotal";
            this.lblPaymentTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPaymentTotal.Size = new System.Drawing.Size(35, 13);
            this.lblPaymentTotal.TabIndex = 12;
            this.lblPaymentTotal.Text = "label4";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::PresentationLayer.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(74, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 60);
            this.btnRefresh.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnRefresh, "به روز رسانی");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 119);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "جمع پرداختی ( تومان ) :\r\n";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.btnRefresh);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 431);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(724, 76);
            this.panel.TabIndex = 38;
            // 
            // lblDebtorsTtotal
            // 
            this.lblDebtorsTtotal.AutoSize = true;
            this.lblDebtorsTtotal.Location = new System.Drawing.Point(50, 183);
            this.lblDebtorsTtotal.Name = "lblDebtorsTtotal";
            this.lblDebtorsTtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDebtorsTtotal.Size = new System.Drawing.Size(35, 13);
            this.lblDebtorsTtotal.TabIndex = 40;
            this.lblDebtorsTtotal.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 183);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "مانده بدهی ( تومان ) :\r\n";
            // 
            // frmPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(724, 507);
            this.Controls.Add(this.lblDebtorsTtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPaymentTotal);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridViewPaymentList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTerm);
            this.Controls.Add(this.gridViewStudent);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmPaymentList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست صورت حساب ها";
            this.Load += new System.EventHandler(this.frmPaymentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentList)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewStudent;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewPaymentList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPaymentTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblDebtorsTtotal;
        private System.Windows.Forms.Label label4;

    }
}