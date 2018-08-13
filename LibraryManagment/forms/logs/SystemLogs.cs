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
    internal partial class SystemLogs: Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.SoftwareLogs, tables.SoftwareLogs> report;
        internal SystemLogs()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose, null, btnMaximize);
            report = new DBForms.ListView<tables.SoftwareLogs, tables.SoftwareLogs>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
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