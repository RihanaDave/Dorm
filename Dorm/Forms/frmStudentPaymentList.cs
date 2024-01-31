using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmStudentPaymentList : Form
    {
        public string StudentID = string.Empty;
        private DataTable dtPaymentList;

        public frmStudentPaymentList()
        {
            InitializeComponent();
        }

        private void frmStudentPaymentList_Load(object sender, EventArgs e)
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
            float paymentTotal = 0, debtorsTtotal = 0;

            Term objTerm = new Term();
            Student objStudent = new Student();

            if (dtPaymentList != null)
                dtPaymentList.Clear();

            if (cmbTerm.SelectedValue != null)
            {
                dtPaymentList = objStudent.ShowPaymentList(StudentID, cmbTerm.SelectedValue.ToString());
                if (dtPaymentList != null)
                {
                    gridViewPaymentList.AutoGenerateColumns = false;
                    gridViewPaymentList.DataSource = dtPaymentList;

                    for (int i = 0; i < gridViewPaymentList.RowCount; i++)
                    {
                        paymentTotal += (float)gridViewPaymentList.Rows[i].Cells[3].Value;
                    }
                    lblPaymentTotal.Text = paymentTotal.ToString();

                    debtorsTtotal = objTerm.GetTotalPrice(cmbTerm.SelectedValue.ToString()) - paymentTotal;
                    if (debtorsTtotal == paymentTotal)
                        lblDebtorsTtotal.Text = "0";
                    else
                        lblDebtorsTtotal.Text = debtorsTtotal.ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmbTerm_KeyDown(object sender, KeyEventArgs e)
        {
            float paymentTotal = 0, debtorsTtotal = 0;

            Term objTerm = new Term();
            Student objStudent = new Student();

            if (dtPaymentList != null)
                dtPaymentList.Clear();

            if (cmbTerm.SelectedValue != null)
            {
                dtPaymentList = objStudent.ShowPaymentList(StudentID, cmbTerm.SelectedValue.ToString());
                if (dtPaymentList != null)
                {
                    gridViewPaymentList.AutoGenerateColumns = false;
                    gridViewPaymentList.DataSource = dtPaymentList;

                    for (int i = 0; i < gridViewPaymentList.RowCount; i++)
                    {
                        paymentTotal += (float)gridViewPaymentList.Rows[i].Cells[3].Value;
                    }
                    lblPaymentTotal.Text = paymentTotal.ToString();

                    debtorsTtotal = objTerm.GetTotalPrice(cmbTerm.SelectedValue.ToString()) - paymentTotal;
                    if (debtorsTtotal == paymentTotal)
                        lblDebtorsTtotal.Text = "0";
                    else
                        lblDebtorsTtotal.Text = debtorsTtotal.ToString();
                }
            }
        }
    }
}
