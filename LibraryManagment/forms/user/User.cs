using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms.user
{
    internal partial class User: Form
    {
        controllers.User obj = new controllers.User();
        DBForms.DBForm fh;

        internal User()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);

            fh.Init<tables.User, tables.User>(this.panForm, obj);

            fh.SetFormButtons(obj, panForm, btnSave, btnReset);

            cmbActive.Enabled = Core._user.info.UserType == UserTypes.Admin;
            cmbUserType.Enabled = Core._user.info.UserType == UserTypes.Admin;
        }

        internal User(long ID)
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            fh.Init<tables.User, tables.User>(this.panForm, obj);
            fh.SetFormButtons(obj, panForm, btnSave, btnReset);

            cmbUserType.Enabled = (Core._user.info.UserType == UserTypes.Admin && ID != Core._user.info.ID);
            cmbActive.Enabled = Core._user.info.UserType == UserTypes.Admin;

            btnReset.Visible = false;
            txtPassword.Enabled = Core._user.info.UserType == UserTypes.Admin; ;

            if (ID > 0)
            {
                obj.Set(ID);
                DBForms.DBForm.SetForm<tables.User>(obj, panForm);
                txtUsername.Enabled = false;
                btnSave.Text = "UPDATE";
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}