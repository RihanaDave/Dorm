namespace PresentationLayer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Divelements.SandRibbon.StatusBarStrip statusBar;
            Divelements.SandRibbon.Rendering.RibbonRenderer ribbonRenderer1 = new Divelements.SandRibbon.Rendering.RibbonRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblDayOfWeek = new Divelements.SandRibbon.Label();
            this.lblDayOfMonth = new Divelements.SandRibbon.Label();
            this.lblYearMonth = new Divelements.SandRibbon.Label();
            this.label1 = new Divelements.SandRibbon.Label();
            this.lblUserName = new Divelements.SandRibbon.Label();
            this.ribbonManager = new Divelements.SandRibbon.RibbonManager(this.components);
            this.ribbon = new Divelements.SandRibbon.Ribbon();
            this.applicationMenu1 = new Divelements.SandRibbon.ApplicationMenu();
            this.ribbonTab1 = new Divelements.SandRibbon.RibbonTab();
            this.ribbonChunk1 = new Divelements.SandRibbon.RibbonChunk();
            this.btnStudent = new Divelements.SandRibbon.Button();
            this.ribbonChunk4 = new Divelements.SandRibbon.RibbonChunk();
            this.btnTerm = new Divelements.SandRibbon.Button();
            this.ribbonChunk5 = new Divelements.SandRibbon.RibbonChunk();
            this.btnRoom = new Divelements.SandRibbon.Button();
            this.ribbonChunk6 = new Divelements.SandRibbon.RibbonChunk();
            this.btnUser = new Divelements.SandRibbon.Button();
            this.ribbonChunk7 = new Divelements.SandRibbon.RibbonChunk();
            this.btnChangePassword = new Divelements.SandRibbon.Button();
            this.ribbonChunk8 = new Divelements.SandRibbon.RibbonChunk();
            this.btnAbout = new Divelements.SandRibbon.Button();
            this.ribbonChunk9 = new Divelements.SandRibbon.RibbonChunk();
            this.btnExit = new Divelements.SandRibbon.Button();
            this.ribbonTab2 = new Divelements.SandRibbon.RibbonTab();
            this.ribbonChunk10 = new Divelements.SandRibbon.RibbonChunk();
            this.buttonGroup1 = new Divelements.SandRibbon.ButtonGroup();
            this.btnNewRegistration = new Divelements.SandRibbon.Button();
            this.btnOldRegistration = new Divelements.SandRibbon.Button();
            this.btnPayment = new Divelements.SandRibbon.RibbonChunk();
            this.button1 = new Divelements.SandRibbon.Button();
            this.ribbonChunk12 = new Divelements.SandRibbon.RibbonChunk();
            this.btnPaymentList = new Divelements.SandRibbon.Button();
            this.ribbonChunk11 = new Divelements.SandRibbon.RibbonChunk();
            this.btnDebtorsList = new Divelements.SandRibbon.Button();
            this.ribbonTab3 = new Divelements.SandRibbon.RibbonTab();
            this.ribbonChunk2 = new Divelements.SandRibbon.RibbonChunk();
            this.btnCensus = new Divelements.SandRibbon.Button();
            this.ribbonChunk14 = new Divelements.SandRibbon.RibbonChunk();
            this.btnBachupRestore = new Divelements.SandRibbon.Button();
            this.ribbonChunk3 = new Divelements.SandRibbon.RibbonChunk();
            this.btnAddressBook = new Divelements.SandRibbon.Button();
            this.ribbonChunk13 = new Divelements.SandRibbon.RibbonChunk();
            this.btnCalc = new Divelements.SandRibbon.Button();
            this.statusBar1 = new Divelements.SandRibbon.StatusBar();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            statusBar = new Divelements.SandRibbon.StatusBarStrip();
            this.ribbon.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.lblDayOfWeek,
            this.lblDayOfMonth,
            this.lblYearMonth,
            this.label1,
            this.lblUserName});
            statusBar.LayoutOrder = Divelements.SandRibbon.LayoutOrder.FarToNear;
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.Text = "label1";
            // 
            // lblDayOfMonth
            // 
            this.lblDayOfMonth.Text = "label2";
            // 
            // lblYearMonth
            // 
            this.lblYearMonth.Text = "label3";
            // 
            // label1
            // 
            this.label1.Text = "کاربر وارد شده ";
            // 
            // lblUserName
            // 
            this.lblUserName.Text = "label2";
            // 
            // ribbonManager
            // 
            this.ribbonManager.OwnerForm = this;
            ribbonRenderer1.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.LunaBlue;
            this.ribbonManager.Renderer = ribbonRenderer1;
            // 
            // ribbon
            // 
            this.ribbon.ApplicationMenu = this.applicationMenu1;
            this.ribbon.ApplicationToolTip = new Divelements.SandRibbon.SuperToolTip("File", "Click here to see everything you can do with your document.", null, true);
            this.ribbon.AutoContextMenu = false;
            this.ribbon.Controls.Add(this.ribbonTab1);
            this.ribbon.Controls.Add(this.ribbonTab2);
            this.ribbon.Controls.Add(this.ribbonTab3);
            this.ribbon.HelpText = "";
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Manager = this.ribbonManager;
            this.ribbon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ribbon.Name = "ribbon";
            this.ribbon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbon.Size = new System.Drawing.Size(806, 145);
            this.ribbon.TabIndex = 0;
            this.ribbon.ToolBar = null;
            this.ribbon.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ribbon_HelpRequested);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.AutoCloseForm = false;
            this.applicationMenu1.DisplayAreaVisible = false;
            this.applicationMenu1.ExitButtonImage = ((System.Drawing.Image)(resources.GetObject("applicationMenu1.ExitButtonImage")));
            this.applicationMenu1.ExitButtonVisible = false;
            this.applicationMenu1.OptionsButtonImage = ((System.Drawing.Image)(resources.GetObject("applicationMenu1.OptionsButtonImage")));
            this.applicationMenu1.OptionsButtonVisible = false;
            this.applicationMenu1.Visible = false;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Chunks.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.ribbonChunk1,
            this.ribbonChunk4,
            this.ribbonChunk5,
            this.ribbonChunk6,
            this.ribbonChunk7,
            this.ribbonChunk8,
            this.ribbonChunk9});
            this.ribbonTab1.Location = new System.Drawing.Point(1, 52);
            this.ribbonTab1.Manager = this.ribbonManager;
            this.ribbonTab1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Size = new System.Drawing.Size(804, 90);
            this.ribbonTab1.TabIndex = 0;
            this.ribbonTab1.Text = "اطلاعات پایه";
            // 
            // ribbonChunk1
            // 
            this.ribbonChunk1.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnStudent});
            this.ribbonChunk1.Text = "دانشجویان";
            // 
            // btnStudent
            // 
            this.btnStudent.Image = global::PresentationLayer.Properties.Resources.student;
            this.btnStudent.ToolTip = new Divelements.SandRibbon.SuperToolTip("دانشجویان");
            this.btnStudent.Activate += new System.EventHandler(this.btnStudent_Activate);
            // 
            // ribbonChunk4
            // 
            this.ribbonChunk4.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnTerm});
            this.ribbonChunk4.Text = "ترم تحصیلی";
            // 
            // btnTerm
            // 
            this.btnTerm.Image = global::PresentationLayer.Properties.Resources.term;
            this.btnTerm.ToolTip = new Divelements.SandRibbon.SuperToolTip("ترم تحصیلی");
            this.btnTerm.Activate += new System.EventHandler(this.btnTerm_Activate);
            // 
            // ribbonChunk5
            // 
            this.ribbonChunk5.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnRoom});
            this.ribbonChunk5.Text = "اتاق ها";
            // 
            // btnRoom
            // 
            this.btnRoom.Image = global::PresentationLayer.Properties.Resources.room;
            this.btnRoom.ToolTip = new Divelements.SandRibbon.SuperToolTip("اتاق ها");
            this.btnRoom.Activate += new System.EventHandler(this.btnRoom_Activate);
            // 
            // ribbonChunk6
            // 
            this.ribbonChunk6.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnUser});
            this.ribbonChunk6.Text = "کاربران";
            // 
            // btnUser
            // 
            this.btnUser.Image = global::PresentationLayer.Properties.Resources.user;
            this.btnUser.ToolTip = new Divelements.SandRibbon.SuperToolTip("کاربران");
            this.btnUser.Activate += new System.EventHandler(this.btnUser_Activate);
            // 
            // ribbonChunk7
            // 
            this.ribbonChunk7.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnChangePassword});
            this.ribbonChunk7.Text = "تغییر رمز عبور";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Image = global::PresentationLayer.Properties.Resources.password;
            this.btnChangePassword.ToolTip = new Divelements.SandRibbon.SuperToolTip("تغییر رمز عبور");
            this.btnChangePassword.Activate += new System.EventHandler(this.btnChangePassword_Activate);
            // 
            // ribbonChunk8
            // 
            this.ribbonChunk8.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnAbout});
            this.ribbonChunk8.Text = "درباره برنامه";
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::PresentationLayer.Properties.Resources.about1;
            this.btnAbout.ToolTip = new Divelements.SandRibbon.SuperToolTip("درباره برنامه");
            this.btnAbout.Activate += new System.EventHandler(this.btnAbout_Activate);
            // 
            // ribbonChunk9
            // 
            this.ribbonChunk9.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnExit});
            this.ribbonChunk9.Text = "خروج";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::PresentationLayer.Properties.Resources.exit;
            this.btnExit.ToolTip = new Divelements.SandRibbon.SuperToolTip("خروج");
            this.btnExit.Activate += new System.EventHandler(this.btnExit_Activate);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Chunks.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.ribbonChunk10,
            this.btnPayment,
            this.ribbonChunk12,
            this.ribbonChunk11});
            this.ribbonTab2.Location = new System.Drawing.Point(1, 52);
            this.ribbonTab2.Manager = this.ribbonManager;
            this.ribbonTab2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Size = new System.Drawing.Size(804, 90);
            this.ribbonTab2.TabIndex = 1;
            this.ribbonTab2.Text = "عملیات";
            // 
            // ribbonChunk10
            // 
            this.ribbonChunk10.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.buttonGroup1});
            this.ribbonChunk10.Text = "ثبت نام";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnNewRegistration,
            this.btnOldRegistration});
            // 
            // btnNewRegistration
            // 
            this.btnNewRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRegistration.Image")));
            this.btnNewRegistration.ToolTip = new Divelements.SandRibbon.SuperToolTip("ثبت نام دانشجوی جدید");
            this.btnNewRegistration.Activate += new System.EventHandler(this.btnNewRegistration_Activate);
            // 
            // btnOldRegistration
            // 
            this.btnOldRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnOldRegistration.Image")));
            this.btnOldRegistration.ToolTip = new Divelements.SandRibbon.SuperToolTip("ثبت نام دانشجوی قدیمی");
            this.btnOldRegistration.Activate += new System.EventHandler(this.btnOldRegistration_Activate);
            // 
            // btnPayment
            // 
            this.btnPayment.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.button1});
            this.btnPayment.Text = "پرداخت شهریه";
            // 
            // button1
            // 
            this.button1.Image = global::PresentationLayer.Properties.Resources.payment;
            this.button1.ToolTip = new Divelements.SandRibbon.SuperToolTip("پرداخت شهریه");
            this.button1.Activate += new System.EventHandler(this.button1_Activate);
            // 
            // ribbonChunk12
            // 
            this.ribbonChunk12.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnPaymentList});
            this.ribbonChunk12.Text = "صورت حساب ها";
            // 
            // btnPaymentList
            // 
            this.btnPaymentList.Image = global::PresentationLayer.Properties.Resources.list;
            this.btnPaymentList.ToolTip = new Divelements.SandRibbon.SuperToolTip("لیست صورت حساب ها");
            this.btnPaymentList.Activate += new System.EventHandler(this.btnPaymentList_Activate);
            // 
            // ribbonChunk11
            // 
            this.ribbonChunk11.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnDebtorsList});
            this.ribbonChunk11.Text = "بدهکاری ها";
            // 
            // btnDebtorsList
            // 
            this.btnDebtorsList.Image = global::PresentationLayer.Properties.Resources.deptor;
            this.btnDebtorsList.ToolTip = new Divelements.SandRibbon.SuperToolTip("لیست بدهکاری ها");
            this.btnDebtorsList.Activate += new System.EventHandler(this.btnDebtorsList_Activate);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Chunks.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.ribbonChunk2,
            this.ribbonChunk14,
            this.ribbonChunk3,
            this.ribbonChunk13});
            this.ribbonTab3.Location = new System.Drawing.Point(1, 52);
            this.ribbonTab3.Manager = this.ribbonManager;
            this.ribbonTab3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Size = new System.Drawing.Size(804, 90);
            this.ribbonTab3.TabIndex = 2;
            this.ribbonTab3.Text = "امکانات";
            // 
            // ribbonChunk2
            // 
            this.ribbonChunk2.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnCensus});
            this.ribbonChunk2.Text = "آمار";
            // 
            // btnCensus
            // 
            this.btnCensus.Image = global::PresentationLayer.Properties.Resources.census;
            this.btnCensus.ToolTip = new Divelements.SandRibbon.SuperToolTip("آمار کلی ترم تحصیلی");
            this.btnCensus.Activate += new System.EventHandler(this.btnCensus_Activate);
            // 
            // ribbonChunk14
            // 
            this.ribbonChunk14.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnBachupRestore});
            this.ribbonChunk14.Text = "پشتیبان گیری";
            // 
            // btnBachupRestore
            // 
            this.btnBachupRestore.Image = global::PresentationLayer.Properties.Resources.backup;
            this.btnBachupRestore.ToolTip = new Divelements.SandRibbon.SuperToolTip("مدیریت پشتیتان");
            this.btnBachupRestore.Activate += new System.EventHandler(this.btnBachupRestore_Activate);
            // 
            // ribbonChunk3
            // 
            this.ribbonChunk3.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnAddressBook});
            this.ribbonChunk3.Text = "دفترچه تلفن";
            // 
            // btnAddressBook
            // 
            this.btnAddressBook.Image = global::PresentationLayer.Properties.Resources.address_book;
            this.btnAddressBook.ToolTip = new Divelements.SandRibbon.SuperToolTip("دفترچه تلفن");
            this.btnAddressBook.Activate += new System.EventHandler(this.btnAddressBook_Activate);
            // 
            // ribbonChunk13
            // 
            this.ribbonChunk13.Items.AddRange(new Divelements.SandRibbon.WidgetBase[] {
            this.btnCalc});
            this.ribbonChunk13.Text = "ماشین حساب";
            // 
            // btnCalc
            // 
            this.btnCalc.Image = global::PresentationLayer.Properties.Resources.calc;
            this.btnCalc.ToolTip = new Divelements.SandRibbon.SuperToolTip("ماشین حساب");
            this.btnCalc.Activate += new System.EventHandler(this.btnCalc_Activate);
            // 
            // statusBar1
            // 
            this.statusBar1.ExtendedStrip = null;
            this.statusBar1.Location = new System.Drawing.Point(0, 438);
            this.statusBar1.MainStrip = statusBar;
            this.statusBar1.Manager = this.ribbonManager;
            this.statusBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(806, 22);
            this.statusBar1.TabIndex = 1;
            // 
            // openDialog
            // 
            this.openDialog.Title = "انتخاب تصویر";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 460);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMain";
            this.Text = "خوابگاه دانشجوی ولی عصر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Divelements.SandRibbon.RibbonManager ribbonManager;
        private Divelements.SandRibbon.Ribbon ribbon;
        private Divelements.SandRibbon.RibbonTab ribbonTab1;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk1;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk4;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk5;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk6;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk7;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk8;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk9;
        private Divelements.SandRibbon.RibbonTab ribbonTab2;
        private Divelements.SandRibbon.RibbonChunk btnPayment;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk10;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk11;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk12;
        private Divelements.SandRibbon.RibbonTab ribbonTab3;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk3;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk13;
        private Divelements.SandRibbon.StatusBar statusBar1;
        private Divelements.SandRibbon.Button btnUser;
        private Divelements.SandRibbon.Button btnChangePassword;
        private Divelements.SandRibbon.Button btnAbout;
        private Divelements.SandRibbon.Button btnExit;
        private Divelements.SandRibbon.ButtonGroup buttonGroup1;
        private Divelements.SandRibbon.Label lblDayOfWeek;
        private Divelements.SandRibbon.Label lblDayOfMonth;
        private Divelements.SandRibbon.Label lblYearMonth;
        private Divelements.SandRibbon.Label label1;
        private Divelements.SandRibbon.Label lblUserName;
        public Divelements.SandRibbon.Button btnStudent;
        public Divelements.SandRibbon.Button btnTerm;
        public Divelements.SandRibbon.Button btnRoom;
        public Divelements.SandRibbon.Button button1;
        public Divelements.SandRibbon.Button btnNewRegistration;
        public Divelements.SandRibbon.Button btnOldRegistration;
        public Divelements.SandRibbon.Button btnDebtorsList;
        public Divelements.SandRibbon.Button btnPaymentList;
        public Divelements.SandRibbon.Button btnAddressBook;
        public Divelements.SandRibbon.Button btnCalc;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk2;
        private Divelements.SandRibbon.Button btnCensus;
        private Divelements.SandRibbon.RibbonChunk ribbonChunk14;
        private Divelements.SandRibbon.Button btnBachupRestore;
        private Divelements.SandRibbon.ApplicationMenu applicationMenu1;
    }
}