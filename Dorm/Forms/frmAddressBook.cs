using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmAddressBook : Form
    {
        private AddressBook objAddressBook;
        private DataTable dtAddressBook;
        private BindingManagerBase bindingManagerBase;
        private bool IsNewAddressBook = false;
        private string errorMessage = string.Empty;

        public frmAddressBook()
        {
            InitializeComponent();

            objAddressBook = new AddressBook();
        }

        private void CreateDataBinding()
        {
            txtName.DataBindings.Add(new Binding("Text", dtAddressBook, "name"));
            txtFamily.DataBindings.Add(new Binding("Text", dtAddressBook, "family"));
            txtCompany.DataBindings.Add(new Binding("Text", dtAddressBook, "company"));
            txtTel1.DataBindings.Add(new Binding("Text", dtAddressBook, "tel1"));
            txtTel2.DataBindings.Add(new Binding("Text", dtAddressBook, "tel2"));
            txtTel3.DataBindings.Add(new Binding("Text", dtAddressBook, "tel3"));
            txtFax.DataBindings.Add(new Binding("Text", dtAddressBook, "fax"));
            txtEmail.DataBindings.Add(new Binding("Text", dtAddressBook, "email"));
            txtURL.DataBindings.Add(new Binding("Text", dtAddressBook, "url"));
            txtAddress.DataBindings.Add(new Binding("Text", dtAddressBook, "address"));
            txtDescription.DataBindings.Add(new Binding("Text", dtAddressBook, "description"));
        }

        private void ClearDdataBinding()
        {
            txtName.DataBindings.Clear();
            txtFamily.DataBindings.Clear();
            txtCompany.DataBindings.Clear ();
            txtTel1.DataBindings.Clear ();
            txtTel2.DataBindings.Clear ();
            txtTel3.DataBindings.Clear ();
            txtFax.DataBindings.Clear ();
            txtEmail.DataBindings.Clear ();
            txtURL.DataBindings.Clear ();
            txtAddress.DataBindings.Clear ();
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
            if (string.IsNullOrEmpty(txtName.Text))
            {
                message = "نام را وارد کنید";
                error.SetError(txtName, message);
                return true;
            }

            message = string.Empty;
            return false;
        }

        private void frmAddressBook_Load(object sender, EventArgs e)
        {
            ClearText();
            ControlWhitex();
            ClearDdataBinding();

            errorProvider.Clear();

            dtAddressBook = objAddressBook.ShowData(Eperator.UserID);
            CreateDataBinding();
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = dtAddressBook;

            bindingManagerBase = this.BindingContext[dtAddressBook];

            if (gridView.RowCount == 0)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true ;
                btnDelete.Enabled = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            IsNewAddressBook = true;
            ClearText();
            ControlWhitex();
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsNewAddressBook)
            {
                if (ValidateField(errorProvider, out errorMessage))
                    return;

                errorProvider.Clear();

                int result = objAddressBook.Insert(Eperator.UserID, txtName.Text, txtFamily.Text, txtCompany.Text, txtTel1.Text, txtTel2.Text, txtTel3.Text, txtFax.Text, txtEmail.Text, txtURL.Text, txtAddress.Text, txtDescription.Text);

                frmAddressBook_Load(null, null);

                IsNewAddressBook = false;

            }
            else
            {
                string AddressBookID = gridView.CurrentRow.Cells[0].Value.ToString();

                int result = objAddressBook.Edit(AddressBookID, Eperator.UserID, txtName.Text, txtFamily.Text, txtCompany.Text, txtTel1.Text, txtTel2.Text, txtTel3.Text, txtFax.Text, txtEmail.Text, txtURL.Text, txtAddress.Text, txtDescription.Text);

                bindingManagerBase.EndCurrentEdit();

                ControlWhitex();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
                ClearText();

            bindingManagerBase.CancelCurrentEdit();
            ControlWhitex();
            IsNewAddressBook = false;
            errorProvider.Clear();

            if (gridView.RowCount == 0)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
                return;

            DialogResult dr = MessageBox.Show("آيا برای ادامه کار اطمينان داريد ؟ ", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                string AddressBookID = gridView.CurrentRow.Cells[0].Value.ToString();
                int index = gridView.CurrentRow.Index;
                objAddressBook.Delete(AddressBookID);
                bindingManagerBase.RemoveAt(index);

                if (gridView.RowCount == 0)
                {
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
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
            string query = "[name] LIKE '%{0}%' OR [family] LIKE '%{0}%'";
            dtAddressBook.DefaultView.RowFilter = string.Format(query, txtSearch.Text);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyCode != Keys.Tab && e.KeyCode != Keys.Enter)
                textBox.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmAddressBook_Load(null, null);
        }
    }
}
