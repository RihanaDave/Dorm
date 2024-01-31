namespace PresentationLayer
{
    partial class frmChangeRoom
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblRemainderRoom = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel.Controls.Add(this.btnCancel);
            this.panel.Controls.Add(this.btnOK);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 109);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(323, 73);
            this.panel.TabIndex = 108;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::PresentationLayer.Properties.Resources.cancel_48;
            this.btnCancel.Location = new System.Drawing.Point(9, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 60);
            this.btnCancel.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnCancel, "انصراف");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::PresentationLayer.Properties.Resources.accepted_48;
            this.btnOK.Location = new System.Drawing.Point(78, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 60);
            this.btnOK.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnOK, "تایید");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label23);
            this.groupBox.Controls.Add(this.lblRemainderRoom);
            this.groupBox.Controls.Add(this.cmbRoom);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Location = new System.Drawing.Point(9, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(307, 100);
            this.groupBox.TabIndex = 111;
            this.groupBox.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(212, 67);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(90, 13);
            this.label23.TabIndex = 114;
            this.label23.Text = "ظرفیت باقیمانده  :";
            // 
            // lblRemainderRoom
            // 
            this.lblRemainderRoom.AutoSize = true;
            this.lblRemainderRoom.Location = new System.Drawing.Point(162, 67);
            this.lblRemainderRoom.Name = "lblRemainderRoom";
            this.lblRemainderRoom.Size = new System.Drawing.Size(0, 13);
            this.lblRemainderRoom.TabIndex = 113;
            // 
            // cmbRoom
            // 
            this.cmbRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(11, 32);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(195, 21);
            this.cmbRoom.TabIndex = 0;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            this.cmbRoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRoom_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 35);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "اتاق :";
            // 
            // frmChangeRoom
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(323, 182);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeRoom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعویض اتاق";
            this.Load += new System.EventHandler(this.frmChangeRoom_Load);
            this.panel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRemainderRoom;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label23;
    }
}