using System;
using System.Windows.Forms;
using System.Data;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmPayment : Form
    {
        private Student objStudent;
        private DataTable dtStudent;
        private string errorMessage = string.Empty;
        private bool IsPayment = false;
        private int CountPayment = 0;
        private float CountCheck = 0;

        public frmPayment()
        {
            InitializeComponent();

            objStudent = new Student();
        }

        private void PrintReciption()
        {
            //frmReciptionPrint f = new frmReciptionPrint();
            //f.date = DateTimeHelper.GetCurrentPersianDate();
            //f.name = gridView.CurrentRow.Cells[1].Value.ToString();
            //f.family = gridView.CurrentRow.Cells[2].Value.ToString();
            //f.CountCheck = CountCheck.ToString();
            //f.CountCash = txtPrice1.Text;
            //f.TotalCheck = CountPayment.ToString();
            //f.DateCheck1 = txtDateCheck1.Text;
            //f.DateCheck2 = txtDateCheck2.Text;
            //f.CheckNumber1 = txtNumberCheck1.Text;
            //f.CheckNumber2 = txtNumberCheck2.Text;
            //f.PriceCheck1 = txtPrice2.Text;
            //f.PriceCheck2 = txtPrice3.Text;
            //f.ShowDialog();
        }

        private void ClearText()
        {
            Type textBoxType = typeof(TextBox);
            Type maskTextBoxType = typeof(MaskedTextBox);

            foreach (Control control in this.groupBoxPayment .Controls  )
            {
                if (control.GetType() == textBoxType)
                    control.Text = string.Empty;

                if (control.GetType() == maskTextBoxType)
                    control.Text = string.Empty;
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;

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

            Term objTerm = new Term();
            DataTable dtTerm = objTerm.ShowData("2");
            cmbTerm.DataSource = dtTerm;
            cmbTerm.DisplayMember = "name";
            cmbTerm.ValueMember = "TermID";

            cmbTerm_SelectionChangeCommitted(null, null);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if ((!chkCash.Checked && !chkCheck1.Checked && !chkCheck2.Checked) || (txtPrice1.Text == string.Empty && txtPrice2.Text == string.Empty && txtPrice3.Text == string.Empty))
            {
                MessageBox.Show(" . لطفا مبلغ را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsPayment = false;
                return;
            }

            DialogResult dr1 = MessageBox.Show("? آیا مبلغ وارد شده درست است ", "سوال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr1 == DialogResult.OK)
            {
                string StudentID = gridView.CurrentRow.Cells[0].Value.ToString();

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
                        int result2 = objStudent.Pay(StudentID, cmbTerm.SelectedValue.ToString(), "2", Eperator.UserID, txtPrice2.Text, DateTimeHelper.GetCurrentPersianDate(), txtDateCheck1.Text , txtNumberCheck1.Text);
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
                DialogResult dr2 = MessageBox.Show(". پرداخت با موفقیت انجام شد ", "اطلاع", MessageBoxButtons.OKCancel, MessageBoxIcon.Information );
                if (dr2 == DialogResult.OK)
                {
                    ClearText();
                    btnPrint.Enabled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "[name] LIKE '%{0}%' OR [family] LIKE '%{0}%' OR [fathername] LIKE '%{0}%'";
            dtStudent.DefaultView.RowFilter = string.Format(query, txtSearch.Text);
        }

        private void cmbTerm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dtStudent != null)
                dtStudent.Clear();

            if (cmbTerm.SelectedValue != null)
            {
                dtStudent = objStudent.ShowStudentInTerm(cmbTerm.SelectedValue.ToString());
                if (dtStudent != null)
                {
                    gridView.AutoGenerateColumns = false;
                    gridView.DataSource = dtStudent;

                    if (gridView.RowCount == 0)
                        btnPayment.Enabled = false;
                    else
                        btnPayment.Enabled = true;
                }
            }
        }

        private void chkCash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCash.Checked == true)
                txtPrice1.Enabled = true;
            else
                txtPrice1.Enabled = false;
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
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
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

        private void cmbTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (dtStudent != null)
                dtStudent.Clear();

            if (cmbTerm.SelectedValue != null)
            {
                dtStudent = objStudent.ShowStudentInTerm(cmbTerm.SelectedValue.ToString());
                if (dtStudent != null)
                {
                    gridView.AutoGenerateColumns = false;
                    gridView.DataSource = dtStudent;

                    if (gridView.RowCount == 0)
                        btnPayment.Enabled = false;
                    else
                        btnPayment.Enabled = true;
                }
            }
        }
    }
}
