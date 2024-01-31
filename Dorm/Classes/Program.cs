using System;
using System.Globalization;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-ir"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
