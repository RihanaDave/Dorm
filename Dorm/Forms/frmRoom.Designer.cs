namespace PresentationLayer
{
    partial class frmRoom
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
            this.txtCapicity = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnDevice = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancl = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCapicity
            // 
            this.txtCapicity.Location = new System.Drawing.Point(20, 47);
            this.txtCapicity.Name = "txtCapicity";
            this.txtCapicity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCapicity.Size = new System.Drawing.Size(217, 21);
            this.txtCapicity.TabIndex = 1;
            this.txtCapicity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapicity_KeyPress);
            this.txtCapicity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyUp);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(20, 20);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumber.Size = new System.Drawing.Size(217, 21);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyUp);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.txtNumber);
            this.groupBox.Controls.Add(this.txtCapicity);
            this.groupBox.Location = new System.Drawing.Point(8, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(312, 283);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ظرفیت کلی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "شماره اتاق :";
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel.Controls.Add(this.btnDevice);
            this.panel.Controls.Add(this.btnRefresh);
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.btnNew);
            this.panel.Controls.Add(this.btnSave);
            this.panel.Controls.Add(this.btnCancl);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 295);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(627, 73);
            this.panel.TabIndex = 4;
            // 
            // btnDevice
            // 
            this.btnDevice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDevice.Image = global::PresentationLayer.Properties.Resources.light;
            this.btnDevice.Location = new System.Drawing.Point(294, 6);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(60, 60);
            this.btnDevice.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnDevice, "امکانات اتاق");
            this.btnDevice.UseVisualStyleBackColor = true;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::PresentationLayer.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(360, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 60);
            this.btnRefresh.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnRefresh, "به روز رسانی");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::PresentationLayer.Properties.Resources.exit1;
            this.btnExit.Location = new System.Drawing.Point(8, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnExit, "خروج");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::PresentationLayer.Properties.Resources.add;
            this.btnNew.Location = new System.Drawing.Point(558, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(60, 60);
            this.btnNew.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnNew, "جدید");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PresentationLayer.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(492, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 60);
            this.btnSave.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnSave, "ثبت ");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancl
            // 
            this.btnCancl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancl.Image = global::PresentationLayer.Properties.Resources.undo1_png;
            this.btnCancl.Location = new System.Drawing.Point(426, 6);
            this.btnCancl.Name = "btnCancl";
            this.btnCancl.Size = new System.Drawing.Size(60, 60);
            this.btnCancl.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnCancl, "لغو تغیرات");
            this.btnCancl.UseVisualStyleBackColor = true;
            this.btnCancl.Click += new System.EventHandler(this.btnCancl_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.Location = new System.Drawing.Point(329, 39);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridView.Size = new System.Drawing.Size(289, 247);
            this.gridView.TabIndex = 0;
            this.gridView.TabStop = false;
           // this.gridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellEnter);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "RoomID";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RowNumber";
            this.Column4.HeaderText = "ردیف";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 40;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "number";
            this.Column1.HeaderText = "شماره اتاق ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "capicity";
            this.Column2.HeaderText = "ظرفیت ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "full";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(329, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 21);
            this.txtSearch.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtSearch, "جستجو");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(627, 368);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmRoom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اتاق ها";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapicity;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtSearch;
    }
}