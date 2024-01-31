using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmRoom : Form
    {
        private Room objRoom;
        private DataTable dtRoom;
        private BindingManagerBase bindingManagerBase;
        private frmDevice formDevice = null;
        private bool IsNewRoom = false;
        private string errorMessage = string.Empty;

        public frmRoom()
        {
            InitializeComponent();

            objRoom = new Room();
        }

        private void CreateDataBinding()
        {
            txtNumber.DataBindings.Add(new Binding("Text", dtRoom, "number"));
            txtCapicity.DataBindings.Add(new Binding("Text", dtRoom, "capicity"));
        }

        private void ClearDdataBinding()
        {
            txtNumber.DataBindings.Clear();
            txtCapicity.DataBindings.Clear();
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
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                message = "شماره اتاق را وارد کنید";
                error.SetError(txtNumber, message);
                return true;
            }

            message = string.Empty;
            return false;
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            ClearText();
            ControlWhitex();
            ClearDdataBinding();

            errorProvider.Clear();

            dtRoom = objRoom.ShowData("1");
            CreateDataBinding();
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = dtRoom;

            bindingManagerBase = this.BindingContext[dtRoom];

            if (gridView.RowCount == 0)
            {
                btnSave.Enabled = false;
                btnDevice.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true ;
                btnDevice.Enabled = true ;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
            ControlWhitex();
            IsNewRoom = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsNewRoom)
            {
                if (ValidateField(errorProvider ,out errorMessage))
                    return;

                errorProvider.Clear();

                if (objRoom.Exists(txtNumber.Text))
                {
                    MessageBox.Show(" . این مورد قبلا ثبت شده است ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int result = objRoom.Insert(txtNumber.Text, txtCapicity.Text);

                frmRoom_Load(null, null);

                IsNewRoom = false;
            }
            else
            {
                string RoomID = gridView.CurrentRow.Cells[0].Value.ToString();
                int result = objRoom.Edit(RoomID, txtNumber.Text, txtCapicity.Text);

                bindingManagerBase.EndCurrentEdit();
                ControlWhitex();
            }
        }

        private void btnCancl_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
                ClearText();

            bindingManagerBase.CancelCurrentEdit();
            ControlWhitex();
            IsNewRoom = false;
            errorProvider.Clear();

            if (gridView.RowCount == 0)
            {
                btnSave.Enabled = false;
                btnDevice.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtNumber_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyCode != Keys.Tab && e.KeyCode != Keys.Enter)
                textBox.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmRoom_Load(null, null);
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            if ((formDevice == null) || (formDevice.IsDisposed))
            {
                formDevice = new frmDevice();
            }
            formDevice.RoomID = gridView.CurrentRow.Cells[0].Value.ToString();
            formDevice.ShowDialog();
        }

        private void txtCapicity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "[number] LIKE '%{0}%'";
            dtRoom.DefaultView.RowFilter = string.Format(query, txtSearch.Text);
        }
    }
}
