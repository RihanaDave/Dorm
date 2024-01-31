using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmUser : Form
    {
        private Eperator objEperator;
        private DataTable dtEperator;
        private BindingManagerBase bindingManagerBase;
        private frmAccessLevel formAccessLevel = null;
        private bool IsNewUser = false;
        private string errorMessage = string.Empty;
        
        public frmUser()
        {
            InitializeComponent();

            objEperator = new Eperator();
        }

        private void CreateDataBinding()
        {
            txtName.DataBindings.Add(new Binding("Text", dtEperator, "name"));
            txtFamily.DataBindings.Add(new Binding("Text", dtEperator, "family"));
            txtUserName.DataBindings.Add(new Binding("Text", dtEperator, "username"));
            txtPassword.DataBindings.Add(new Binding("Text", dtEperator, "password"));
            txtPhone.DataBindings.Add(new Binding("Text", dtEperator, "phone"));
            txtAddress.DataBindings.Add(new Binding("Text", dtEperator, "address"));
            txtDescription.DataBindings.Add(new Binding("Text", dtEperator, "description"));
        }

        private void ClearDdataBinding()
        {
            txtName.DataBindings.Clear();
            txtFamily.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
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

        private void frmUser_Load(object sender, EventArgs e)
        {
            ClearText();
            ControlWhitex();
            ClearDdataBinding();

            errorProvider.Clear();

            dtEperator = objEperator.ShowData();
            CreateDataBinding();
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = dtEperator;

            bindingManagerBase = this.BindingContext[dtEperator];

            if (gridView.Rows.Count == 0)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnAccessLevel.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnAccessLevel.Enabled = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
            ControlWhitex();
            IsNewUser = true;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount  == 0)
                return;

            DialogResult dr = MessageBox.Show("آيا برای ادامه کار اطمينان داريد ؟ ", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string UserID = gridView.CurrentRow.Cells[0].Value.ToString();
                int index = gridView.CurrentRow.Index;
                objEperator.Delete(UserID);
                bindingManagerBase.RemoveAt(index);

                if (gridView.RowCount == 0)
                {
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAccessLevel.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsNewUser)
            {
                if (ValidateField(errorProvider ,out errorMessage))
                    return;

                errorProvider.Clear();

                if (objEperator.Exists(txtUserName.Text))
                {
                    MessageBox.Show(" . این مورد قبلا ثبت شده است ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int result = objEperator.Insert(txtName.Text, txtFamily.Text, txtPhone.Text, txtUserName.Text, txtPassword.Text,
                     txtAddress.Text, txtDescription.Text);

                frmUser_Load(null, null);

                IsNewUser = false;
            }
            else
            {
                string UserID = gridView.CurrentRow.Cells[0].Value.ToString();

                int result = objEperator.Edit(UserID, txtName.Text, txtFamily.Text, txtPhone.Text, txtUserName.Text, txtPassword.Text,
                     txtAddress.Text, txtDescription.Text);

                bindingManagerBase.EndCurrentEdit();

                ControlWhitex();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
                ClearText();

            bindingManagerBase.CancelCurrentEdit();
            ControlWhitex();
            IsNewUser = false;
            errorProvider.Clear();

            if (gridView.RowCount == 0)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnAccessLevel.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyCode != Keys.Tab && e.KeyCode != Keys.Enter)
                textBox.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "[name] LIKE '%{0}%' OR [family] LIKE '%{0}%' OR [username] LIKE '%{0}%'";
            dtEperator.DefaultView.RowFilter = string.Format(query, txtSearch.Text);
        }

        private void btnAccessLevel_Click(object sender, EventArgs e)
        {
            string UserID = gridView.CurrentRow.Cells[0].Value.ToString();
            if ((formAccessLevel == null) || (formAccessLevel.IsDisposed))
            {
                formAccessLevel = new frmAccessLevel();
            }
            formAccessLevel.UserID = UserID;
            formAccessLevel.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmUser_Load(null, null);
        }


    }
}
