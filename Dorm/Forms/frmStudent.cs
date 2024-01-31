using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmStudent : Form
    {
        private Student objStudent;
        private DataTable dtStudent;
        private BindingManagerBase bindingManagerBase;
        private string errorMessage = string.Empty;

        public frmStudent()
        {
            InitializeComponent();

            objStudent = new Student();
        }

        private void CreateDataBinding()
        {
            txtName.DataBindings.Add(new Binding("Text", dtStudent, "name"));
            txtFamily.DataBindings.Add(new Binding("Text", dtStudent, "family"));
            txtFatherName.DataBindings.Add(new Binding("Text", dtStudent, "fathername"));
            lblRoom.DataBindings.Add(new Binding("Text", dtStudent, "number"));
            txtCellPhone.DataBindings.Add(new Binding("Text", dtStudent, "cellphone"));
            txtHomePhone.DataBindings.Add(new Binding("Text", dtStudent, "homephone"));
            txtFatherTel.DataBindings.Add(new Binding("Text", dtStudent, "fathertel"));
            txtFeild.DataBindings.Add(new Binding("Text", dtStudent, "feild"));
            txtEntry.DataBindings.Add(new Binding("Text", dtStudent, "entery"));
            txtAddress.DataBindings.Add(new Binding("Text", dtStudent, "address"));
            txtDescriprion.DataBindings.Add(new Binding("Text", dtStudent, "description"));
        }

        private void ClearDdataBinding()
        {
            txtName.DataBindings.Clear();
            txtFamily.DataBindings.Clear();
            txtFatherName.DataBindings.Clear();
            lblRoom.DataBindings.Clear();
            txtCellPhone.DataBindings.Clear();
            txtHomePhone.DataBindings.Clear();
            txtFatherTel.DataBindings.Clear();
            txtFeild.DataBindings.Clear();
            txtEntry.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtDescriprion.DataBindings.Clear();
        }

        private void ControlWhitex()
        {
            Type textBoxType = typeof(TextBox);
            foreach (Control control in this.groupBox.Controls)
            {
                if (control.GetType() == textBoxType)
                    control.BackColor = Color.White;
            }
        }

        private void ClearText()
        {
            Type textBoxType = typeof(TextBox);
            foreach (Control control in this.groupBox.Controls)
            {
                if (control.GetType() == textBoxType)
                    control.Text = string.Empty;
            }
        }

        private bool ValidateField(ErrorProvider error,out string message)
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
                error.SetError(txtName, message);
                return true;
            }

            message = string.Empty;
            return false;
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            errorProvider.Clear();

            Term objTerm = new Term();
            DataTable dtTerm = objTerm.ShowData("2");
            cmbTerm.DataSource = dtTerm;
            cmbTerm.DisplayMember = "name";
            cmbTerm.ValueMember = "TermID";

            cmbTerm_SelectionChangeCommitted(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateField(errorProvider, out errorMessage))
                return;

            string StudentID = gridView.CurrentRow.Cells[0].Value.ToString();

            int result = objStudent.Edit(StudentID, txtName.Text,
                  txtFamily.Text, txtFatherName.Text, txtCellPhone.Text, txtHomePhone.Text,
                  txtFatherTel.Text, txtFeild.Text, txtEntry.Text, txtAddress.Text, txtDescriprion.Text);

            bindingManagerBase.EndCurrentEdit();

            ControlWhitex();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
                return;

            DialogResult dr = MessageBox.Show(" اگر دانشجوی مورد نظر را حذف کنید تمام سوابق آن نیز از بین میرود ", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                string StudentID = gridView.CurrentRow.Cells[0].Value.ToString();
                int index = gridView.CurrentRow.Index;
                objStudent.Delete(StudentID);
                bindingManagerBase.RemoveAt(index);

                if (gridView.RowCount == 0)
                {
                    btnPayment.Enabled = false;
                    btnPaymentList.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount  == 0)
                ClearText();

            bindingManagerBase.CancelCurrentEdit();
            ControlWhitex();
            errorProvider.Clear();

            if (gridView.RowCount == 0)
            {
                btnPayment.Enabled = false;
                btnPaymentList.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "[name] LIKE '%{0}%' OR [family] LIKE '%{0}%' OR [fathername] LIKE '%{0}%'";
            dtStudent.DefaultView.RowFilter = string.Format(query, txtSearch.Text);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyCode != Keys.Tab && e.KeyCode != Keys.Enter)
                textBox.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmStudentPayment formStudentPayment = new frmStudentPayment();
            formStudentPayment.StudentID = gridView.CurrentRow.Cells[0].Value.ToString();
            formStudentPayment.lblName.Text = gridView.CurrentRow.Cells[2].Value.ToString();
            formStudentPayment.lblFamily.Text = gridView.CurrentRow.Cells[3].Value.ToString();
            formStudentPayment.ShowDialog();
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

                    ClearDdataBinding();
                    ClearText();
                    ControlWhitex();

                    CreateDataBinding();
                    gridView.AutoGenerateColumns = false;
                    gridView.DataSource = dtStudent;

                    bindingManagerBase = this.BindingContext[dtStudent];

                    if (gridView.RowCount == 0)
                    {
                        btnPayment.Enabled = false;
                        btnPaymentList.Enabled = false;
                        btnDelete.Enabled = false;
                        btnSave.Enabled = false;
                        lblRoom.Enabled = false;
                    }
                    else
                    {
                        btnPayment.Enabled = true;
                        btnPaymentList.Enabled = true;
                        btnDelete.Enabled = true;
                        btnSave.Enabled = true;
                        lblRoom.Enabled = true;
                    }
                }
            }
        }

        private void btnPaymentList_Click(object sender, EventArgs e)
        {
            frmStudentPaymentList formStudentPaymentList = new frmStudentPaymentList();
            formStudentPaymentList.StudentID = gridView.CurrentRow.Cells[0].Value.ToString();
            formStudentPaymentList.lblName.Text = gridView.CurrentRow.Cells[2].Value.ToString();
            formStudentPaymentList.lblFamily.Text = gridView.CurrentRow.Cells[3].Value.ToString();
            formStudentPaymentList.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmStudent_Load(null, null);
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

                    ClearDdataBinding();
                    ClearText();
                    ControlWhitex();

                    CreateDataBinding();
                    gridView.AutoGenerateColumns = false;
                    gridView.DataSource = dtStudent;

                    bindingManagerBase = this.BindingContext[dtStudent];

                    if (gridView.RowCount == 0)
                    {
                        btnPayment.Enabled = false;
                        btnPaymentList.Enabled = false;
                        btnDelete.Enabled = false;
                        btnSave.Enabled = false;
                        lblRoom.Enabled = false;
                    }
                    else
                    {
                        btnPayment.Enabled = true;
                        btnPaymentList.Enabled = true;
                        btnDelete.Enabled = true;
                        btnSave.Enabled = true;
                        lblRoom.Enabled = true;
                    }
                }
            }
        }

 
    }
}
