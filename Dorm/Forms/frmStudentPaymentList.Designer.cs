namespace PresentationLayer
{
    partial class frmStudentPaymentList
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
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPaymentTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridViewPaymentList = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblDebtorsTtotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel.Controls.Add(this.btnExit);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 280);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(731, 71);
            this.panel.TabIndex = 34;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::PresentationLayer.Properties.Resources.exit1;
            this.btnExit.Location = new System.Drawing.Point(12, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbTerm
            // 
            this.cmbTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(508, 11);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(135, 21);
            this.cmbTerm.TabIndex = 0;
            this.cmbTerm.SelectionChangeCommitted += new System.EventHandler(this.cmbTerm_SelectionChangeCommitted);
            this.cmbTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTerm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ترم تحصیلی :";
            // 
            // lblPaymentTotal
            // 
            this.lblPaymentTotal.AutoSize = true;
            this.lblPaymentTotal.Location = new System.Drawing.Point(406, 250);
            this.lblPaymentTotal.Name = "lblPaymentTotal";
            this.lblPaymentTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPaymentTotal.Size = new System.Drawing.Size(35, 13);
            this.lblPaymentTotal.TabIndex = 37;
            this.lblPaymentTotal.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 250);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "جمع پرداختی ( تومان ) :\r\n";
            // 
            // gridViewPaymentList
            // 
            this.gridViewPaymentList.AllowUserToAddRows = false;
            this.gridViewPaymentList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridViewPaymentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPaymentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column5,
            this.Column6});
            this.gridViewPaymentList.Location = new System.Drawing.Point(12, 43);
            this.gridViewPaymentList.MultiSelect = false;
            this.gridViewPaymentList.Name = "gridViewPaymentList";
            this.gridViewPaymentList.ReadOnly = true;
            this.gridViewPaymentList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridViewPaymentList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewPaymentList.Size = new System.Drawing.Size(707, 191);
            this.gridViewPaymentList.TabIndex = 35;
            this.gridViewPaymentList.TabStop = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StudentID";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 14);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "نام :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 14);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "نام خانوادگی :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(367, 14);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "label10";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(136, 14);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFamily.Size = new System.Drawing.Size(35, 13);
            this.lblFamily.TabIndex = 40;
            this.lblFamily.Text = "label9";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "خروج";
            // 
            // lblDebtorsTtotal
            // 
            this.lblDebtorsTtotal.AutoSize = true;
            this.lblDebtorsTtotal.Location = new System.Drawing.Point(136, 250);
            this.lblDebtorsTtotal.Name = "lblDebtorsTtotal";
            this.lblDebtorsTtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDebtorsTtotal.Size = new System.Drawing.Size(35, 13);
            this.lblDebtorsTtotal.TabIndex = 43;
            this.lblDebtorsTtotal.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 250);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "مانده بدهی ( تومان ) :\r\n";
            // 
            // frmStudentPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(731, 351);
            this.Controls.Add(this.lblDebtorsTtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPaymentTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridViewPaymentList);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cmbTerm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentPaymentList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست صورت حساب";
            this.Load += new System.EventHandler(this.frmStudentPaymentList_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaymentTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridViewPaymentList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblDebtorsTtotal;
        private System.Windows.Forms.Label label4;
    }
}