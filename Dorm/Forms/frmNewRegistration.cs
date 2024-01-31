using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmNewRegistration : Form
    {
        private Room objRoom;
        private string ErrorMessage = string.Empty;
        private bool IsPayment = false;
        private int CountPayment = 0;
        private float CountCheck = 0;

        public frmNewRegistration()
        {
            InitializeComponent();

            objRoom = new Room();
        }

        private void PrintReciption()
        {

        }

        private void ClearText()
        {
            Type TextBoxType = typeof(TextBox);
            Type maskTextBoxType = typeof(MaskedTextBox);

            foreach (Control control in this.groupBoxStudent.Controls)
            {
                if (control.GetType() == TextBoxType)
                    control.Text = string.Empty;
            }

            foreach (Control control in this.groupBoxPayment.Controls)
            {
                if (control.GetType() == TextBoxType)
                    control.Text = string.Empty;

                if (control.GetType() == maskTextBoxType)
                    control.Text = string.Empty;
            }
        }

        private bool ValidateField(ErrorProvider error, out string message)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                message = "نام را وارد کنید";
                error.SetError(txtName, message);
                return true;
            }

            if (string.IsNullOrEmpty(txtFamily.Text))
            {
                error.Clear();
                message = "نام و نام خانوادگی را وارد کنید";
                error.SetError(txtFamily, message);
                return true;
            }

            message = string.Empty;
            return false;
        }

        private void frmNewRegistration_Load(object sender, EventArgs e)
        {
            btnPrint.Enabled = true;

            chkCash.Checked = false;
            txtPrice1.Enabled = false;

            chkCheck1.Checked = false;
            txtPrice2.Enabled = false;
            txtDateCheck1.Enabled = false;
            txtNumberCheck1.Enabled = false;

            chkCheck2.Checked = false;
            txtPrice3.Enabled = false;
            txtDateCheck2.Enabled = false;
            txtNumberCheck2.Enabled = false;

            errorProvider.Clear();

            DataTable dtRoom = objRoom.ShowData("2");
            cmbRoom.DataSource = dtRoom;
            cmbRoom.DisplayMember = "number";
            cmbRoom.ValueMember = "RoomID";
            lblRemainderRoom.Text = objRoom.GetRemainderRoom(cmbRoom.SelectedValue.ToString());

            Term objTerm = new Term();
            DataTable dtTerm = objTerm.ShowData("2");
            cmbTerm.DataSource = dtTerm;
            cmbTerm.DisplayMember = "name";
            cmbTerm.ValueMember = "TermID";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            if (ValidateField(errorProvider, out ErrorMessage))
                return;

            Student objStudent = new Student();

            if (!chkCash.Checked && !chkCheck1.Checked && !chkCheck2.Checked)
            {
                int result = objStudent.Insert(cmbRoom.SelectedValue.ToString(), txtName.Text, txtFamily.Text, txtFatherName.Text, txtCellPhone.Text, txtHomePhone.Text, txtFatherTel.Text, txtFeild.Text, txtEntry.Text, txtAddress.Text, txtDescriprion.Text);
                string StudentID = objStudent.GetLastIdentity().ToString();

                MessageBox.Show(" . عملیات با موفقیت انجام شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IsPayment = false;
                ClearText();
                return;
            }

            else
            {
                if (txtPrice1.Text == string.Empty && txtPrice2.Text == string.Empty && txtPrice3.Text == string.Empty)
                {
                    MessageBox.Show(" . لطفا مبلغ را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsPayment = false;
                    return;
                }

                DialogResult dr1 = MessageBox.Show("? آیا مبلغ وارد شده درست است ", "سوال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr1 == DialogResult.OK)
                {
                    int result = objStudent.Insert(cmbRoom.SelectedValue.ToString(), txtName.Text, txtFamily.Text, txtFatherName.Text, txtCellPhone.Text, txtHomePhone.Text, txtFatherTel.Text, txtFeild.Text, txtEntry.Text, txtAddress.Text, txtDescriprion.Text);
                    string StudentID = objStudent.GetLastIdentity().ToString();

                    if (chkCash.Checked)
                    {
                        if (txtPrice1.Text != string.Empty)
                        {
                            int result1 = objStudent.Pay(StudentID, cmbTerm.SelectedValue.ToString(), "1", Eperator.UserID, txtPrice1.Text, DateTimeHelper.GetCurrentPersianDate(), "", "");
                            if (result1 == 1)
                                IsPayment = true;
                        }
                    }

                    if (chkCheck1.Checked)
                    {
                        if (txtPrice2.Text != string.Empty)
                        {
                            int result2 = objStudent.Pay(StudentID, cmbTerm.SelectedValue.ToString(), "2", Eperator.UserID, txtPrice2.Text, DateTimeHelper.GetCurrentPersianDate(), txtDateCheck1.Text, txtNumberCheck1.Text);
                            if (result2 == 1)
                            {
                                IsPayment = true;
                                CountPayment++;
                                CountCheck += float.Parse(txtPrice2.Text);
                            }
                        }
                    }

                    if (chkCheck2.Checked)
                    {
                        if (txtPrice3.Text != string.Empty)
                        {
                            int result3 = objStudent.Pay(StudentID, cmbTerm.SelectedValue.ToString(), "2", Eperator.UserID, txtPrice3.Text, DateTimeHelper.GetCurrentPersianDate(), txtDateCheck2.Text , txtNumberCheck2.Text);
                            if (result3 == 1)
                            {
                                IsPayment = true;
                                CountPayment++;
                                CountCheck += float.Parse(txtPrice2.Text);
                            }
                        }
                    }
                }

                if (IsPayment)
                {
                    DialogResult dr2 = MessageBox.Show(". پرداخت با موفقیت انجام شد ", "اطلاع", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr2 == DialogResult.OK)
                    {
                        ClearText();
                        btnPrint.Enabled = true;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void cmbRoom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblRemainderRoom.Text = string.Empty;
            if (cmbRoom.SelectedValue != null)
            {
                string result = objRoom.GetRemainderRoom(cmbRoom.SelectedValue.ToString());
                if (result != string.Empty)
                    lblRemainderRoom.Text = result;
            }
        }

        private void chkCash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCash.Checked == true)
            {
                txtPrice1.Enabled = true;
            }
            else
            {
                txtPrice1.Enabled = false;
                txtPrice1.Clear();
            }
        }

        private void chkCheck1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck1.Checked == true)
            {
                txtPrice2.Enabled = true;
                txtDateCheck1.Enabled = true;
                txtNumberCheck1.Enabled = true;
            }
            else
            {
                txtPrice2.Enabled = false;
                txtDateCheck1.Enabled = false;
                txtNumberCheck1.Enabled = false;

                txtPrice2.Clear();
                txtNumberCheck1.Clear();
            }
        }

        private void chkCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheck2.Checked == true)
            {
                txtPrice3.Enabled = true;
                txtDateCheck2.Enabled = true;
                txtNumberCheck2.Enabled = true;
            }
            else
            {
                txtPrice3.Enabled = false;
                txtDateCheck2.Enabled = false;
                txtNumberCheck2.Enabled = false;

                txtPrice3.Clear();
                txtNumberCheck2.Clear();
            }
        }

        private void txtPrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintReciption();
        }

        private void cmbRoom_KeyDown(object sender, KeyEventArgs e)
        {
            lblRemainderRoom.Text = string.Empty;
            if (cmbRoom.SelectedValue != null)
            {
                string result = objRoom.GetRemainderRoom(cmbRoom.SelectedValue.ToString());
                if (result != string.Empty)
                    lblRemainderRoom.Text = result;
            }
        }
    }
}
