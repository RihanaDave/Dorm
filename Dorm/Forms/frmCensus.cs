using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmCensus : Form
    {
        private Term objTerm;

        public frmCensus()
        {
            InitializeComponent();

            objTerm = new Term();
        }

        private void frmCensus_Load(object sender, EventArgs e)
        {
           
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

        private void cmbTerm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtCensus = objTerm.GetCensus(cmbTerm.SelectedValue.ToString());
            if (cmbTerm.SelectedValue != null)
            {
                if (dtCensus != null && dtCensus.Rows.Count != 0)
                {
                    lblPrice.Text = dtCensus.Rows[0][1].ToString();
                    lblTotalStudent.Text = dtCensus.Rows[0][0].ToString();
                }
                else
                {
                    lblTotalStudent.Text = "";
                    lblPrice.Text = "";
                }
            }
        }

        private void cmbTerm_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dtCensus = objTerm.GetCensus(cmbTerm.SelectedValue.ToString());
            if (cmbTerm.SelectedValue != null)
            {
                if (dtCensus != null && dtCensus.Rows.Count != 0)
                {
                    lblPrice.Text = dtCensus.Rows[0][1].ToString();
                    lblTotalStudent.Text = dtCensus.Rows[0][0].ToString();
                }
                else
                {
                    lblTotalStudent.Text = "";
                    lblPrice.Text = "";
                }
            }
        }
    }
}
