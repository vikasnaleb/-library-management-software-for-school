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
    internal partial class Profile: Form
    {
        controllers.User obj = new controllers.User();
        DBForms.DBForm fh;
         
        internal Profile(long ID)
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            fh.Init<tables.User, tables.User>(panForm, obj);
            if (ID > 0)
            {
                obj.Set(ID);
                DBForms.DBForm.SetForm<tables.User>(obj, panForm);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}