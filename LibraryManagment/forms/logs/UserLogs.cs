using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms.logs
{
    internal partial class UserLogs: Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.UserLog, tables.UserLog> report;
        internal UserLogs()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose, null, btnMaximize);
            report = new DBForms.ListView<tables.UserLog, tables.UserLog>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
            report.SearchControl(txtUserName, "UserName");
            report.SearchControl(dtpFromDate, "Created>");
            report.SearchControl(dtpToDate, "Created<");
            DBForms.DBForm.SetDateRange(dtpFromDate, dtpToDate);
        }

        private void dgvTable_DoubleClick(object sender, EventArgs e)
        {
             
        }
    }
}