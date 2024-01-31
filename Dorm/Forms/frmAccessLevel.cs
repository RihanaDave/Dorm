using System;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmAccessLevel : Form
    {
        private Eperator objEperator;
        public string UserID = string.Empty;

        public frmAccessLevel()
        {
            InitializeComponent();

            objEperator = new Eperator();
        }

        private void frmAccessLevel_Load(object sender, EventArgs e)
        {
            objEperator.GetAccessLevel(UserID);

            chkStudent.Checked = AccessLevel.Student;
            chkTerm.Checked = AccessLevel.Term;
            chkRoom.Checked = AccessLevel.Room;
            chkPayment.Checked = AccessLevel.Payment;
            chkNewRegistration.Checked = AccessLevel.NewRegistration;
            chkOldRegistration.Checked = AccessLevel.OldRegistration;
            chkPaymentList.Checked = AccessLevel.PaymentList;
            chkDebtorsList.Checked = AccessLevel.DebtorsList;
            chkAddressBook.Checked = AccessLevel.AddressBook;
            chkCalculator.Checked = AccessLevel.Calculator;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int s1;
            int s2;
            int s3;
            int s4;
            int s5;
            int s6;
            int s7;
            int s8;
            int s9;
            int s10;

            if (chkStudent.Checked) s1 = 1; else s1 = 0;
            if (chkTerm.Checked) s2 = 1; else s2 = 0;
            if (chkRoom.Checked) s3 = 1; else s3 = 0;
            if (chkPayment.Checked) s4 = 1; else s4 = 0;
            if (chkNewRegistration.Checked) s5 = 1; else s5 = 0;
            if (chkOldRegistration.Checked) s6 = 1; else s6 = 0;
            if (chkPaymentList.Checked) s7 = 1; else s7 = 0;
            if (chkDebtorsList.Checked) s8 = 1; else s8 = 0;
            if (chkAddressBook.Checked) s9 = 1; else s9 = 0;
            if (chkCalculator.Checked) s10 = 1; else s10 = 0;

            int result = objEperator.SetAccessLevel(UserID, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);

            if (result == 1)
            {
                DialogResult dr = MessageBox.Show("عملیات با موفقیت ثبت شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                    this.Close();
            }
        }
        
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
