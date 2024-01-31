using System;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmChangePassword : Form
    {
        private Manager objManager;
        private string errorMessage = string.Empty;

        public frmChangePassword()
        {
            InitializeComponent();

            objManager = new Manager();
        }

        private bool ValidateField(ErrorProvider error, out string message)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text))
            {
                message = "رمز عبور قبلی را وارد کنید";
                error.SetError(txtOldPassword, message);
                return true;
            }

            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                error.Clear();
                message = "رمز عبور جدید را وارد کنید";
                error.SetError(txtNewPassword, message);
                return true;
            }

            if (string.IsNullOrEmpty(txtReplayPassword.Text))
            {
                error.Clear();
                message = "تکرار رمز عبور را وارد کنید";
                error.SetError(txtReplayPassword, message);
                return true;
            }

            if (!string.Equals(txtNewPassword.Text, txtReplayPassword.Text))
            {
                error.Clear();
                message = "رمز عبور قبلی و جدید یکسان نیستند";
                error.SetError(txtNewPassword, message);
                return true;
            }

            if (!string.Equals(txtOldPassword.Text, objManager.GetPassword()))
            {
                error.Clear();
                message = "رمز عبور قبلی درست نیست";
                error.SetError(txtOldPassword, message);
                return true;
            }

            message = string.Empty;
            return false;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txtNewPassword.Clear();
            txtOldPassword.Clear();
            txtReplayPassword.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateField(errorProvider, out errorMessage))
                return;

            errorProvider.Clear();

            int result = objManager.ChangePassword(txtNewPassword.Text);

            if (result == 1)
            {
                DialogResult dr = MessageBox.Show("رمز عبور با موفقیت ثبت شد", "اطاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                    this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
