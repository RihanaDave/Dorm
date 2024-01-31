using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmTerm : Form
    {
        private Term objTerm;
        private DataTable dtTerm;
        private BindingManagerBase bindingManagerBase;
        private bool IsNewTerm = false;
        private string errorMessage = string.Empty;

        public frmTerm()
        {
            InitializeComponent();

            objTerm = new Term();
        }

        private void CreateDataBinding()
        {
            txtName.DataBindings.Add(new Binding("Text", dtTerm, "name"));
            txtStartDate.DataBindings.Add(new Binding("Text", dtTerm, "startdate"));
            txtEndDate.DataBindings.Add(new Binding("Text", dtTerm, "enddate"));
            txtTotalPrice.DataBindings.Add(new Binding("Text", dtTerm, "totalprice"));
        }

        private void ClearDdataBinding()
        {
            txtName.DataBindings.Clear();
            txtStartDate.DataBindings.Clear();
            txtEndDate.DataBindings.Clear();
            txtTotalPrice.DataBindings.Clear();
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
            Type maskTextBox = typeof(MaskedTextBox);
            foreach (Control control in this.groupBox.Controls)
            {
                if (control.GetType() == textBoxType)
                    control.Text = string.Empty;

                if (control.GetType() == maskTextBox)
                    control.Text = string.Empty;
            }
        }

        private bool ValidateField(ErrorProvider error,out string message)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                message = " ترم تحصیلی را وارد کنید";
                error.SetError(txtName, message);
                return true;
            }

            if (string.IsNullOrEmpty(txtTotalPrice.Text))
            {
                error.Clear();
                message = "مبلغ ترم تحصیلی را وارد کنید";
                error.SetError(txtTotalPrice, message);
                return true;
            }

            message = string.Empty;
            return false;
        }

        private void frmTerm_Load(object sender, EventArgs e)
        {
            ClearText();
            ControlWhitex();
            ClearDdataBinding();

            errorProvider.Clear();

            dtTerm = objTerm.ShowData ("1");
            CreateDataBinding();
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = dtTerm;

            bindingManagerBase = this.BindingContext[dtTerm];

            if (gridView.Rows.Count == 0)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
            ControlWhitex();
            IsNewTerm = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsNewTerm)
            {
                if (ValidateField(errorProvider ,out errorMessage))
                    return;

                errorProvider.Clear();

                if (objTerm.Exists(txtName.Text))
                {
                    MessageBox.Show(" . این مورد قبلا ثبت شده است ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int result = objTerm.Insert(txtName.Text, txtStartDate.Text, txtEndDate.Text, txtTotalPrice.Text);

                frmTerm_Load(null, null);

                IsNewTerm = false;
            }
            else
            {
                string TermID = gridView.CurrentRow.Cells[0].Value.ToString();
                int result = objTerm.Edit(TermID, txtName.Text, txtStartDate.Text , txtEndDate.Text , txtTotalPrice.Text);

                bindingManagerBase.EndCurrentEdit();
                ControlWhitex();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount  == 0)
                ClearText();

            bindingManagerBase.CancelCurrentEdit();
            ControlWhitex();
            IsNewTerm = false;
            errorProvider.Clear();

            if (gridView.RowCount  == 0)
                btnSave.Enabled = false;
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyCode != Keys.Tab && e.KeyCode != Keys.Enter)
                textBox.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "[name] LIKE '%{0}%'";
            dtTerm.DefaultView.RowFilter = string.Format(query, txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmTerm_Load(null, null);
        }

        private void txtTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

 
    }
}
