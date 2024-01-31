using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmChangeRoom : Form
    {
        private Room objRoom;
        public string StudentID = string.Empty;

        public frmChangeRoom()
        {
            InitializeComponent();

            objRoom = new Room();
        }

        private void frmChangeRoom_Load(object sender, EventArgs e)
        {
            DataTable dtRoom = objRoom.ShowData("2");
            cmbRoom.DataSource = dtRoom;
            cmbRoom.DisplayMember = "number";
            cmbRoom.ValueMember = "RoomID";
            lblRemainderRoom.Text = objRoom.GetRemainderRoom(cmbRoom.SelectedValue.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Student objStudent = new Student();
            int result = objStudent.ChangeRoom(StudentID, cmbRoom.SelectedValue.ToString());
            if (result == 1)
            {
                DialogResult dr = MessageBox.Show("عملیات با موفقیت ثبت شد", "اطاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                    this.Close();
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRemainderRoom.Text = string.Empty;
            if (cmbRoom.SelectedValue != null)
            {
                string result = objRoom.GetRemainderRoom(cmbRoom.SelectedValue.ToString());
                if (result != string.Empty)
                    lblRemainderRoom.Text = result;
            }
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
