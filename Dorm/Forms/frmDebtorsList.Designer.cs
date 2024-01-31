namespace PresentationLayer
{
    partial class frmDebtorsList
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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gridViewPaymentList = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDebtorsTtotal = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblPaymentTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentList)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.Column5,
            this.Column4,
            this.Column6});
            this.gridViewStudent.Location = new System.Drawing.Point(155, 35);
            this.gridViewStudent.MultiSelect = false;
            this.gridViewStudent.Name = "gridViewStudent";
            this.gridViewStudent.ReadOnly = true;
            this.gridViewStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridViewStudent.Size = new System.Drawing.Size(491, 245);
            this.gridViewStudent.TabIndex = 0;
            this.gridViewStudent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellEnter);
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
            // Column5
            // 
            this.Column5.DataPropertyName = "fathername";
            this.Column5.HeaderText = "نام پدر";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "number";
            this.Column4.HeaderText = "شماره اتاق";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "sum";
            this.Column6.HeaderText = "جمع پرداختی";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(155, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(486, 21);
            this.txtSearch.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtSearch, "جستجو");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ترم تحصیلی :";
            // 
            // cmbTerm
            // 
            this.cmbTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(7, 30);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(134, 21);
            this.cmbTerm.TabIndex = 0;
            this.cmbTerm.SelectionChangeCommitted += new System.EventHandler(this.cmbTerm_SelectionChangeCommitted);
            this.cmbTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTerm_KeyDown);
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
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::PresentationLayer.Properties.Resources.exit1;
            this.btnExit.Location = new System.Drawing.Point(12, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnExit, "خروج");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gridViewPaymentList.Location = new System.Drawing.Point(7, 286);
            this.gridViewPaymentList.MultiSelect = false;
            this.gridViewPaymentList.Name = "gridViewPaymentList";
            this.gridViewPaymentList.ReadOnly = true;
            this.gridViewPaymentList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridViewPaymentList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewPaymentList.Size = new System.Drawing.Size(641, 116);
            this.gridViewPaymentList.TabIndex = 32;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "username";
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "checkdate";
            this.dataGridViewTextBoxColumn2.HeaderText = "تاریخ چک";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "checknumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "شماره چک";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "مانده بدهی ( تومان ) :\r\n";
            // 
            // lblDebtorsTtotal
            // 
            this.lblDebtorsTtotal.AutoSize = true;
            this.lblDebtorsTtotal.Location = new System.Drawing.Point(53, 130);
            this.lblDebtorsTtotal.Name = "lblDebtorsTtotal";
            this.lblDebtorsTtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDebtorsTtotal.Size = new System.Drawing.Size(35, 13);
            this.lblDebtorsTtotal.TabIndex = 33;
            this.lblDebtorsTtotal.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 178);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "جمع پرداختی ( تومان ) :\r\n";
            // 
            // lblPaymentTotal
            // 
            this.lblPaymentTotal.AutoSize = true;
            this.lblPaymentTotal.Location = new System.Drawing.Point(50, 202);
            this.lblPaymentTotal.Name = "lblPaymentTotal";
            this.lblPaymentTotal.Size = new System.Drawing.Size(35, 13);
            this.lblPaymentTotal.TabIndex = 39;
            this.lblPaymentTotal.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 76);
            this.panel1.TabIndex = 40;
            // 
            // frmDebtorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(653, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPaymentTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDebtorsTtotal);
            this.Controls.Add(this.gridViewPaymentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTerm);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridViewStudent);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmDebtorsList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست بدهکاری ها";
            this.Load += new System.EventHandler(this.frmDebtorsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewStudent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gridViewPaymentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDebtorsTtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPaymentTotal;
        private System.Windows.Forms.Panel panel1;
    }
}