using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLogin
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        [Obsolete]
        public Login()
        {
            InitializeComponent();
        }

        public bool CheckLogin(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txtUsername.Text, txtPassword.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Hệ thống!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
