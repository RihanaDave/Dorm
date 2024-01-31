namespace PresentationLayer
{
    partial class frmAccessLevel
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.chkCalculator = new System.Windows.Forms.CheckBox();
            this.chkOldRegistration = new System.Windows.Forms.CheckBox();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.chkRoom = new System.Windows.Forms.CheckBox();
            this.chkTerm = new System.Windows.Forms.CheckBox();
            this.chkNewRegistration = new System.Windows.Forms.CheckBox();
            this.chkPayment = new System.Windows.Forms.CheckBox();
            this.chkPaymentList = new System.Windows.Forms.CheckBox();
            this.chkDebtorsList = new System.Windows.Forms.CheckBox();
            this.chkAddressBook = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel.Controls.Add(this.btnOK);
            this.panel.Controls.Add(this.btnCancle);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 162);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(367, 73);
            this.panel.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::PresentationLayer.Properties.Resources.accepted_48;
            this.btnOK.Location = new System.Drawing.Point(74, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 60);
            this.btnOK.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnOK, "تایید");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Image = global::PresentationLayer.Properties.Resources.cancel_48;
            this.btnCancle.Location = new System.Drawing.Point(8, 6);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(60, 60);
            this.btnCancle.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnCancle, "انصراف");
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.chkCalculator);
            this.groupBox.Controls.Add(this.chkOldRegistration);
            this.groupBox.Controls.Add(this.chkStudent);
            this.groupBox.Controls.Add(this.chkRoom);
            this.groupBox.Controls.Add(this.chkTerm);
            this.groupBox.Controls.Add(this.chkNewRegistration);
            this.groupBox.Controls.Add(this.chkPayment);
            this.groupBox.Controls.Add(this.chkPaymentList);
            this.groupBox.Controls.Add(this.chkDebtorsList);
            this.groupBox.Controls.Add(this.chkAddressBook);
            this.groupBox.Location = new System.Drawing.Point(8, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(351, 156);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // chkCalculator
            // 
            this.chkCalculator.AutoSize = true;
            this.chkCalculator.Location = new System.Drawing.Point(78, 116);
            this.chkCalculator.Name = "chkCalculator";
            this.chkCalculator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCalculator.Size = new System.Drawing.Size(92, 17);
            this.chkCalculator.TabIndex = 9;
            this.chkCalculator.Text = "ماشین حساب";
            this.chkCalculator.UseVisualStyleBackColor = true;
            // 
            // chkOldRegistration
            // 
            this.chkOldRegistration.AutoSize = true;
            this.chkOldRegistration.Location = new System.Drawing.Point(28, 24);
            this.chkOldRegistration.Name = "chkOldRegistration";
            this.chkOldRegistration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkOldRegistration.Size = new System.Drawing.Size(142, 17);
            this.chkOldRegistration.TabIndex = 5;
            this.chkOldRegistration.Text = "ثبت نام دانشجوی قدیمی";
            this.chkOldRegistration.UseVisualStyleBackColor = true;
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(248, 24);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkStudent.Size = new System.Drawing.Size(74, 17);
            this.chkStudent.TabIndex = 0;
            this.chkStudent.Text = "دانشجویان";
            this.chkStudent.UseVisualStyleBackColor = true;
            // 
            // chkRoom
            // 
            this.chkRoom.AutoSize = true;
            this.chkRoom.Location = new System.Drawing.Point(264, 70);
            this.chkRoom.Name = "chkRoom";
            this.chkRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRoom.Size = new System.Drawing.Size(59, 17);
            this.chkRoom.TabIndex = 2;
            this.chkRoom.Text = "اتاق ها";
            this.chkRoom.UseVisualStyleBackColor = true;
            // 
            // chkTerm
            // 
            this.chkTerm.AutoSize = true;
            this.chkTerm.Location = new System.Drawing.Point(241, 47);
            this.chkTerm.Name = "chkTerm";
            this.chkTerm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTerm.Size = new System.Drawing.Size(82, 17);
            this.chkTerm.TabIndex = 1;
            this.chkTerm.Text = "ترم تحصیلی";
            this.chkTerm.UseVisualStyleBackColor = true;
            // 
            // chkNewRegistration
            // 
            this.chkNewRegistration.AutoSize = true;
            this.chkNewRegistration.Location = new System.Drawing.Point(191, 116);
            this.chkNewRegistration.Name = "chkNewRegistration";
            this.chkNewRegistration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkNewRegistration.Size = new System.Drawing.Size(132, 17);
            this.chkNewRegistration.TabIndex = 4;
            this.chkNewRegistration.Text = "ثبت نام دانشجوی جدید";
            this.chkNewRegistration.UseVisualStyleBackColor = true;
            // 
            // chkPayment
            // 
            this.chkPayment.AutoSize = true;
            this.chkPayment.Location = new System.Drawing.Point(230, 93);
            this.chkPayment.Name = "chkPayment";
            this.chkPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPayment.Size = new System.Drawing.Size(93, 17);
            this.chkPayment.TabIndex = 3;
            this.chkPayment.Text = "پرداخت شهریه";
            this.chkPayment.UseVisualStyleBackColor = true;
            // 
            // chkPaymentList
            // 
            this.chkPaymentList.AutoSize = true;
            this.chkPaymentList.Location = new System.Drawing.Point(51, 47);
            this.chkPaymentList.Name = "chkPaymentList";
            this.chkPaymentList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPaymentList.Size = new System.Drawing.Size(119, 17);
            this.chkPaymentList.TabIndex = 6;
            this.chkPaymentList.Text = "لیست صورت حساب";
            this.chkPaymentList.UseVisualStyleBackColor = true;
            // 
            // chkDebtorsList
            // 
            this.chkDebtorsList.AutoSize = true;
            this.chkDebtorsList.Location = new System.Drawing.Point(58, 70);
            this.chkDebtorsList.Name = "chkDebtorsList";
            this.chkDebtorsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDebtorsList.Size = new System.Drawing.Size(112, 17);
            this.chkDebtorsList.TabIndex = 7;
            this.chkDebtorsList.Text = "لیست بدهکاری ها";
            this.chkDebtorsList.UseVisualStyleBackColor = true;
            // 
            // chkAddressBook
            // 
            this.chkAddressBook.AutoSize = true;
            this.chkAddressBook.Location = new System.Drawing.Point(88, 93);
            this.chkAddressBook.Name = "chkAddressBook";
            this.chkAddressBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAddressBook.Size = new System.Drawing.Size(82, 17);
            this.chkAddressBook.TabIndex = 8;
            this.chkAddressBook.Text = "دفترچه تلفن";
            this.chkAddressBook.UseVisualStyleBackColor = true;
            // 
            // frmAccessLevel
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(367, 235);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccessLevel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعیین سطح دسترسی";
            this.Load += new System.EventHandler(this.frmAccessLevel_Load);
            this.panel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox chkCalculator;
        private System.Windows.Forms.CheckBox chkOldRegistration;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.CheckBox chkRoom;
        private System.Windows.Forms.CheckBox chkTerm;
        private System.Windows.Forms.CheckBox chkNewRegistration;
        private System.Windows.Forms.CheckBox chkPayment;
        private System.Windows.Forms.CheckBox chkPaymentList;
        private System.Windows.Forms.CheckBox chkDebtorsList;
        private System.Windows.Forms.CheckBox chkAddressBook;
        private System.Windows.Forms.ToolTip toolTip;
    }
}