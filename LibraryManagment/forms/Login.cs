using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms
{
    internal partial class Login : Form
    {
        int attempts = 3;
        controllers.User user = new controllers.User();
        //controllers.Softeare software = new controllers.Softeare();
        internal Login()
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
            txtUsername.Text = "Demo";
            txtPassword.Text = "1234";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            if (user.Set(txtUsername.Text,txtPassword.Text))
            {
                Core._user = user;
                Core.Userlog("Successfully loged in...");
                DialogResult = DialogResult.OK;
            }
            else
            {
                Core.Userlog("Invalid login for " + txtUsername.Text.Trim() + " using " + txtPassword.Text.Trim() + " password. [attempt " + attempts + "]");
                attempts--;
                if (attempts > 0 && MessageBox.Show("Invalid Details,  You Have " + attempts + " Attempts", "Confirmation", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    txtUsername.Focus();
                }
                else
                {
                    DialogResult = DialogResult.No;
                    Close();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
      
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !txtPassword.Focused)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
                e.Handled = true;
            }
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sohaminfotechs.com");
        }

        private void pcbSoftwareLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sohaminfotechs.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Core.application.RestoreDatabase();
        }
    }
}
