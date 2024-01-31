using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmDevice : Form
    {
        private Room objRoom;
        private DataTable dtDevice;
        private BindingManagerBase bindingManagerBase;
        private bool IsNewDevice = false;
        private string errorMessage = string.Empty;
        public string RoomID = string.Empty;

        public frmDevice()
        {
            InitializeComponent();

            objRoom = new Room();
        }

        private void CreateDataBinding()
        {
            txtName.DataBindings.Add(new Binding("Text", dtDevice , "name"));
            txtQuantity.DataBindings.Add(new Binding("Text", dtDevice, "quantity"));
        }

        private void ClearDdataBinding()
        {
            txtName.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
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

            if (string.IsNullOrEmpty(txtQuantity .Text))
            {
                message = "تعداد را وارد کنید";
                error.SetError(txtQuantity, message);
                return true;
            }

            message = string.Empty;
            return false;
        }

        private void frmDevice_Load(object sender, EventArgs e)
        {
            ClearText();
            ControlWhitex();
            ClearDdataBinding();

            errorProvider.Clear();

            dtDevice = objRoom.DeviceShowData(RoomID);
            gridView.DataSource = dtDevice;
            gridView.AutoGenerateColumns = false;
            CreateDataBinding();

            bindingManagerBase = this.BindingContext[dtDevice];

            if (gridView.Rows.Count == 0)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            IsNewDevice = true;
            ClearText();
            ControlWhitex();
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsNewDevice)
            {
                if (ValidateField(errorProvider, out errorMessage))
                    return;

                errorProvider.Clear();

                int result = objRoom.AddDevice(RoomID, txtName.Text, txtQuantity.Text);

                frmDevice_Load(null, null);

                IsNewDevice = false;
            }
            else
            {
                string DeviceID = gridView.CurrentRow.Cells[0].Value.ToString();

                int result = objRoom.EditDevice(DeviceID, txtName.Text, txtQuantity.Text);

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
            IsNewDevice = false;
            errorProvider.Clear();

            if (gridView.Rows.Count == 0)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmDevice_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount == 0)
                return;

            DialogResult dr = MessageBox.Show("آيا برای ادامه کار اطمينان داريد ؟ ", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                string DeviceID = gridView.CurrentRow.Cells[1].Value.ToString();
                int index = gridView.CurrentRow.Index;
                objRoom.RemoveDevice(DeviceID);
                bindingManagerBase.RemoveAt(index);

                if (gridView.Rows.Count == 0)
                {
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                e.Handled = true;
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyCode != Keys.Tab && e.KeyCode != Keys.Enter)
                textBox.BackColor = Color.FromArgb(192, 255, 255);
        }
    }
}
