using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmAboutUs : Form
    {
        public frmAboutUs()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
