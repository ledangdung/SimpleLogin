using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLogin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            DialogResult checkLogin = login.ShowDialog();
            if (checkLogin == DialogResult.OK)
            {
                mainform mainform = new mainform();
                mainform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn đã hủy đăng nhập!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
