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
    internal partial class FineList: Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.Circulation, tables.view.MemberFine> report;
        internal FineList()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose, null, btnMaximize);
            report = new DBForms.ListView<tables.Circulation, tables.view.MemberFine>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
            report.SearchControl(txtMemberID, "MemberID");
            report.Where("Fine>", 0);
        }

        private void dgvTable_DoubleClick(object sender, EventArgs e)
        {
            if (report.Selected > 0)
                new circulation.CirculationDetails(report.Selected).ShowDialog();
        }
    }
}