using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms.user
{
    internal partial class Verify : Form
    {
       
        controllers.User user = new controllers.User();

        internal Verify()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            if (user.Set(txtUsername.Text,txtPassword.Text))
            {
                if (user.info.UserType == UserTypes.Admin)
                    DialogResult = DialogResult.OK;
                else
                {
                    DialogResult = DialogResult.Cancel;
                    MessageBox.Show("You don't have permitions to reset data please contact Admin..");
                }
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                Close();
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
    }
}
