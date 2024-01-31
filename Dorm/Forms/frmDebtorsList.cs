using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmDebtorsList : Form
    {
        private DataTable dtStudent;
        private DataTable dtPaymentList;
        private Student objStudent;
        
        public frmDebtorsList()
        {
            InitializeComponent();

            objStudent = new Student();
        }

        private void frmDebtorsList_Load(object sender, EventArgs e)
        {
            Term objTerm = new Term();
            DataTable dtTerm = objTerm.ShowData("2");
            cmbTerm.DataSource = dtTerm;
            cmbTerm.DisplayMember = "name";
            cmbTerm.ValueMember = "TermID";

            cmbTerm_SelectionChangeCommitted(null, null);
        }

        private void cmbTerm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblDebtorsTtotal.Text = string.Empty;
            lblPaymentTotal.Text = string.Empty;

            if (dtStudent != null)
                dtStudent.Clear();

            if (dtPaymentList != null)
                dtPaymentList.Clear();

            if (cmbTerm.SelectedValue != null)
            {
                dtStudent = objStudent.DebtorsList(cmbTerm.SelectedValue.ToString());
                if (dtStudent != null)
                {
                    gridViewStudent.AutoGenerateColumns = false;
                    gridViewStudent.DataSource = dtStudent;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "[name] LIKE '%{0}%' OR [family] LIKE '%{0}%' OR [fathername] LIKE '%{0}%' ";
            dtStudent.DefaultView.RowFilter = string.Format(query, txtSearch.Text);
            if (gridViewStudent.RowCount == 0)
            {
                if (dtPaymentList != null)
                    dtPaymentList.Clear();
                gridViewPaymentList.DataSource = dtPaymentList;
                lblDebtorsTtotal.Text = string.Empty;
                lblPaymentTotal.Text = string.Empty;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbTerm_SelectionChangeCommitted(null, null);
        }

        private void gridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string StudentID = gridViewStudent.CurrentRow.Cells[0].Value.ToString();
            float paymentTotal = 0, debtorsTtotal = 0;

            Term objTerm = new Term();

            if (dtPaymentList != null)
                dtPaymentList.Clear();

            dtPaymentList = objStudent.ShowPaymentList(StudentID, cmbTerm.SelectedValue.ToString());
            gridViewPaymentList.AutoGenerateColumns = false;
            gridViewPaymentList.DataSource = dtPaymentList;

            for (int i = 0; i < gridViewPaymentList.RowCount; i++)
            {
                paymentTotal += (float)gridViewPaymentList.Rows[i].Cells[2].Value;
            }
            lblPaymentTotal.Text = paymentTotal.ToString();

            debtorsTtotal = objTerm.GetTotalPrice(cmbTerm.SelectedValue.ToString()) - paymentTotal;
            lblDebtorsTtotal.Text = debtorsTtotal.ToString();
        }

        private void cmbTerm_KeyDown(object sender, KeyEventArgs e)
        {
            lblDebtorsTtotal.Text = string.Empty;
            lblPaymentTotal.Text = string.Empty;

            if (dtStudent != null)
                dtStudent.Clear();

            if (dtPaymentList != null)
                dtPaymentList.Clear();

            if (cmbTerm.SelectedValue != null)
            {
                dtStudent = objStudent.DebtorsList(cmbTerm.SelectedValue.ToString());
                if (dtStudent != null)
                {
                    gridViewStudent.AutoGenerateColumns = false;
                    gridViewStudent.DataSource = dtStudent;
                }
            }
        }
    }
}
