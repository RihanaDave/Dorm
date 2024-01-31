namespace PresentationLayer
{
    partial class frmBackupRestore
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtRestorePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestorePath = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(410, 211);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.btnBackupPath);
            this.tabPage1.Controls.Add(this.txtBackupPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ایجاد پشتیتان";
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackupPath.Location = new System.Drawing.Point(23, 90);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(40, 23);
            this.btnBackupPath.TabIndex = 2;
            this.btnBackupPath.Text = "...";
            this.btnBackupPath.UseVisualStyleBackColor = true;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Enabled = false;
            this.txtBackupPath.Location = new System.Drawing.Point(69, 90);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupPath.Size = new System.Drawing.Size(304, 21);
            this.txtBackupPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "مسیری را برای ذخیره فایل پشتیبان انتخاب کنبد :\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.txtRestorePath);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnRestorePath);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "بازیابی پشتیتان";
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Enabled = false;
            this.txtRestorePath.Location = new System.Drawing.Point(69, 90);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestorePath.Size = new System.Drawing.Size(304, 21);
            this.txtRestorePath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "مسیر فایل پشتیبان را انتخاب کنبد :\r\n";
            // 
            // btnRestorePath
            // 
            this.btnRestorePath.Location = new System.Drawing.Point(23, 90);
            this.btnRestorePath.Name = "btnRestorePath";
            this.btnRestorePath.Size = new System.Drawing.Size(40, 23);
            this.btnRestorePath.TabIndex = 0;
            this.btnRestorePath.Text = "...";
            this.btnRestorePath.UseVisualStyleBackColor = true;
            this.btnRestorePath.Click += new System.EventHandler(this.btnRestorePath_Click);
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel.Controls.Add(this.btnCreate);
            this.panel.Controls.Add(this.btnCancel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 213);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(410, 71);
            this.panel.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Image = global::PresentationLayer.Properties.Resources.accepted_48;
            this.btnCreate.Location = new System.Drawing.Point(73, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(60, 60);
            this.btnCreate.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnCreate, "تایید");
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::PresentationLayer.Properties.Resources.cancel_48;
            this.btnCancel.Location = new System.Drawing.Point(7, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 60);
            this.btnCancel.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnCancel, "انصراف");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openDialog
            // 
            this.openDialog.FilterIndex = 0;
            this.openDialog.Title = "انتخاب مسیر";
            // 
            // saveDialog
            // 
            this.saveDialog.FilterIndex = 0;
            this.saveDialog.Title = "انتخاب مسیر";
            // 
            // frmBackupRestore
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 284);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmBackupRestore";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت پشتیتان";
            this.Load += new System.EventHandler(this.frmBackupAndRestore_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBackupPath;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRestorePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestorePath;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ToolTip toolTip;
    }
}