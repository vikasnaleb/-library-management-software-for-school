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
    internal partial class Password: Form
    {
        controllers.User obj = new controllers.User();
        DBForms.DBForm fh;

        internal Password(long ID)
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            fh.Init<tables.User, tables.User>(this.panForm, obj);

            fh.SetFormButtons(obj, panForm, btnSave);

            obj.Set(ID);
        } 
    }
}