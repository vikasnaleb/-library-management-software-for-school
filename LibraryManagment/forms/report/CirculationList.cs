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
    internal partial class CirculationList: Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.Member, tables.Member> report;
        internal CirculationList()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose, null, btnMaximize);
            report = new DBForms.ListView<tables.Member, tables.Member>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
            report.SearchControl(txtTitle, "FullName");
        }

        private void dgvTable_DoubleClick(object sender, EventArgs e)
        {
           // if (report.Selected > 0)
               // new CirculationBookReturn(report.Selected).ShowDialog();
        }
    }
}