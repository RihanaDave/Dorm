using System;
using System.IO;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmBackupRestore : Form
    {
        BackupRestore objBackupRestore;

        public frmBackupRestore()
        {
            InitializeComponent();

            objBackupRestore = new BackupRestore();
        }

        private void frmBackupAndRestore_Load(object sender, EventArgs e)
        {
            txtBackupPath.Text = string.Empty;
            txtRestorePath.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            //if (tabControl.TabIndex == 0)
            //{
            //    if (txtBackupPath.Text == string.Empty)
            //    {
            //        MessageBox.Show("مسیری برای ایجاد فایل پشتیبان مشخص کنید", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    string result = objBackupRestore.Backup(saveDialog.FileName);
            //    if (result == "0")
            //    {
            //        DialogResult dr = MessageBox.Show("عملیات با موفقیت ثبت شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        if (dr == DialogResult.OK)
            //            this.Close();
            //    }
            //}
            //else if (tabControl.TabIndex == 1)
            //{
            //    if (txtBackupPath.Text == string.Empty)
            //    {
            //        MessageBox.Show("مسیر فایل پشتیبان را مشخص کنید", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    string result = objBackupRestore.Restore(openDialog.FileName);
            //    if (result == "0")
            //    {
            //        DialogResult dr = MessageBox.Show("عملیات با موفقیت ثبت شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        if (dr == DialogResult.OK)
            //            this.Close();
            //    }
            //}
            //else
            //{
            //}

            //saveDialog.ShowDialog();

            //saveDialog.Filter = "Database file | *.mdf | Database log file | *.ldf";

          //  File.Copy(Application.StartupPath + "\\Database\\DB.mdf", "c:\\DB.mdf", false);

           // File.Copy(Application.StartupPath + "\\Database\\DB_log.ldf", "c:\\DB_log.ldf", false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = string.Empty;
                txtBackupPath.Text = saveDialog.FileName;
            }
        }

        private void btnRestorePath_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txtRestorePath.Text = string.Empty;
                txtRestorePath.Text = openDialog.FileName;
            }
        }
    }
}
