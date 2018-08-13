using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms.report
{
    internal partial class UserList: Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.User, tables.User> report;
        internal UserList()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose, null, btnMaximize);
            report = new DBForms.ListView<tables.User, tables.User>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
            report.SearchControl(txtUsername, "Username");
        }

        private void dgvTable_DoubleClick(object sender, EventArgs e)
        {
            if (report.Selected > 0)
                new user.User(report.Selected).ShowDialog();
        }
    }
}