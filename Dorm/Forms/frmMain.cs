using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        private PersianCalendar calendar;
        private frmStudent formStudent = null;
        private frmTerm formTerm = null;
        private frmRoom formRoom = null;
        private frmAboutUs formAboutUs = null;
        private frmUser formUser = null;
        private frmChangePassword formChangePassword = null;
        private frmOldRegistration formOldRegistration = null;
        private frmNewRegistration formNewRegistration = null;
        private frmPayment formPayment = null;
        private frmPaymentList formPaymentList = null;
        private frmAddressBook formAddressBook = null;
        private frmDebtorsList formDebtorsList = null;
        private frmCensus formCensus = null;
        private frmBackupRestore formBackupRestore = null;
        public bool IsManager = false;

        public frmMain()
        {
            InitializeComponent();
            calendar = new PersianCalendar();
        }

        private string GetDayOfWeek()
        {
            string day = string.Empty;
            DayOfWeek result = calendar.GetDayOfWeek(DateTime.Now);
            switch (result)
            {
                case DayOfWeek.Saturday:
                    day = "شنبه";
                    break;
                case DayOfWeek.Sunday:
                    day = "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    day = "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    day = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    day = "چهارشنبه ";
                    break;
                case DayOfWeek.Thursday:
                    day = "پنج شنبه";
                    break;
                case DayOfWeek.Friday:
                    day = "جمعه";
                    break;
            }
            return day;

        }

        private string GetMonth()
        {
            string month = string.Empty;
            int result = calendar.GetMonth(DateTime.Now);
            switch (result)
            {
                case 1:
                    month = "فروردین";
                    break;
                case 2:
                    month = "اردیبهشت";
                    break;
                case 3:
                    month = "خرداد";
                    break;
                case 4:
                    month = "تیر";
                    break;
                case 5:
                    month = "مرداد";
                    break;
                case 6:
                    month = "شهریور";
                    break;
                case 7:
                    month = "مهر";
                    break;
                case 8:
                    month = "آبان";
                    break;
                case 9:
                    month = "آذر";
                    break;
                case 10:
                    month = "دی";
                    break;
                case 11:
                    month = "بهمن";
                    break;
                case 12:
                    month = "اسفند";
                    break;
            }

            return month;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!IsManager)
            {
                btnUser.Enabled = false;
                btnChangePassword.Enabled = false;
                btnCensus.Enabled = false;
                btnBachupRestore.Enabled = false;
            }

            lblYearMonth.Text =  GetMonth() + "   " + calendar.GetYear(DateTime.Now).ToString();
            lblDayOfMonth.Text =  calendar.GetDayOfMonth(DateTime.Now).ToString();
            lblDayOfWeek.Text =  GetDayOfWeek();

            lblUserName.Text = Eperator.UserName;
        }

        private void btnStudent_Activate(object sender, EventArgs e)
        {
            if ((formStudent == null) || (formStudent.IsDisposed))
            {
                formStudent = new frmStudent();
            }
            formStudent.MdiParent = this;
            formStudent.Show();
        }

        private void btnTerm_Activate(object sender, EventArgs e)
        {
            if ((formTerm == null) || (formTerm.IsDisposed))
            {
                formTerm = new frmTerm();
            }
            formTerm.MdiParent = this;
            formTerm.Show();
        }

        private void btnRoom_Activate(object sender, EventArgs e)
        {
            if ((formRoom == null) || (formRoom.IsDisposed))
            {
                formRoom = new frmRoom();
            }
            formRoom.MdiParent = this;
            formRoom.Show();
        }

        private void btnUser_Activate(object sender, EventArgs e)
        {
            if ((formUser == null) || (formUser.IsDisposed))
            {
                formUser = new frmUser();
            }
            formUser.MdiParent = this;
            formUser.Show();
        }

        private void btnChangePassword_Activate(object sender, EventArgs e)
        {
            if ((formChangePassword == null) || (formChangePassword.IsDisposed))
            {
                formChangePassword = new frmChangePassword();
            }
            formChangePassword.MdiParent = this;
            formChangePassword.Show();
        }

        private void btnAbout_Activate(object sender, EventArgs e)
        {
            if ((formAboutUs == null) || (formAboutUs.IsDisposed))
            {
                formAboutUs = new frmAboutUs();
            }
            formAboutUs.MdiParent = this;
            formAboutUs.Show();
        }

        private void btnExit_Activate(object sender, EventArgs e)
        {
            
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void button1_Activate(object sender, EventArgs e)
        {
            if ((formPayment == null) || (formPayment.IsDisposed))
            {
                formPayment = new frmPayment();
            }
            formPayment.MdiParent = this;
            formPayment.Show();
        }

        private void btnNewRegistration_Activate(object sender, EventArgs e)
        {
            if ((formNewRegistration == null) || (formNewRegistration.IsDisposed))
            {
                formNewRegistration = new frmNewRegistration();
            }
            formNewRegistration.MdiParent = this;
            formNewRegistration.Show();
        }

        private void btnOldRegistration_Activate(object sender, EventArgs e)
        {
            if ((formOldRegistration == null) || (formOldRegistration.IsDisposed))
            {
                formOldRegistration = new frmOldRegistration();
            }
            formOldRegistration.MdiParent = this;
            formOldRegistration.Show();
        }

        private void btnDebtorsList_Activate(object sender, EventArgs e)
        {
            if ((formDebtorsList == null) || (formDebtorsList.IsDisposed))
            {
                formDebtorsList = new frmDebtorsList();
            }
            formDebtorsList.MdiParent = this;
            formDebtorsList.Show();
        }

        private void btnPaymentList_Activate(object sender, EventArgs e)
        {
            if ((formPaymentList == null) || (formPaymentList.IsDisposed))
            {
                formPaymentList = new frmPaymentList();
            }
            formPaymentList.MdiParent = this;
            formPaymentList.Show();
        }

        private void btnAddressBook_Activate(object sender, EventArgs e)
        {
            if ((formAddressBook == null) || (formAddressBook.IsDisposed))
            {
                formAddressBook = new frmAddressBook();
            }
            formAddressBook.MdiParent = this;
            formAddressBook.Show();
        }

        private void btnCalc_Activate(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void btnCensus_Activate(object sender, EventArgs e)
        {
            if ((formCensus == null) || (formCensus.IsDisposed))
            {
                formCensus = new frmCensus();
            }
            formCensus.MdiParent = this;
            formCensus.Show();
        }

        private void btnBachupRestore_Activate(object sender, EventArgs e)
        {
            if ((formBackupRestore == null) || (formBackupRestore.IsDisposed))
            {
                formBackupRestore = new frmBackupRestore();
            }
            formBackupRestore.MdiParent = this;
            formBackupRestore.Show();
        }

        private void ribbon_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (ribbon.Minimized)
                ribbon.Minimized = false;
            else
                ribbon.Minimized = true;
        }
    }
}
