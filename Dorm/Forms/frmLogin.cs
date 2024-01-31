using System;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmLogin : Form
    {
        private string strErrorMessage = string.Empty;

        public frmLogin()
        {
            InitializeComponent();
        }

        private bool ValidateField(ErrorProvider error, out string message)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                message = "نام کاربری را وارد کنید";
                error.SetError(txtUserName, message);
                return true;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                error.Clear();
                message = "رمز عبور را وارد کنید";
                error.SetError(txtPassword, message);
                return true;
            }

            message = string.Empty;
            return false;
        }

        private bool DatabaseExsist()
        {
            return false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
            chkManager.Checked = false;
            errorProvider.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateField(errorProvider, out strErrorMessage))
                return;

            errorProvider.Clear();

            if (chkManager.Checked)
            {
                Manager objManager = new Manager();
                if (objManager.Login(txtUserName.Text, txtPassword.Text) == "1")
                {
                    frmMain formMain = new frmMain();
                    formMain.IsManager = true;
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    return;
                }
            }
            else
            {
                Eperator objEperator = new Eperator();
                if (objEperator.Login(txtUserName.Text, txtPassword.Text) == "1")
                {
                    frmMain formMain = new frmMain();

                    objEperator.GetAccessLevel(Eperator.UserID);

                    formMain.btnStudent.Enabled = AccessLevel.Student;
                    formMain.btnTerm.Enabled = AccessLevel.Term;
                    formMain.btnRoom.Enabled = AccessLevel.Room;
                    formMain.button1.Enabled = AccessLevel.Payment;
                    formMain.btnNewRegistration.Enabled = AccessLevel.NewRegistration;
                    formMain.btnOldRegistration.Enabled = AccessLevel.OldRegistration;
                    formMain.btnPaymentList.Enabled = AccessLevel.PaymentList;
                    formMain.btnDebtorsList.Enabled = AccessLevel.DebtorsList;
                    formMain.btnAddressBook.Enabled = AccessLevel.AddressBook;
                    formMain.btnCalc.Enabled = AccessLevel.Calculator;

                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void chkManager_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManager.Checked)
            {
                txtUserName.Enabled = false;
                txtUserName.Clear();
                txtUserName.Text = "مدیر سیستم";
            }
            else
            {
                txtUserName.Enabled = true; ;
                txtUserName.Clear();
            }
        }
    }
}
