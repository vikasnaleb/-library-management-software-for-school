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
    internal partial class BookCoppisList: Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.BookCoppy, tables.view.BookCoppy> report;
        internal BookCoppisList()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose, null, btnMaximize);
            report = new DBForms.ListView<tables.BookCoppy, tables.view.BookCoppy>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
            report.SearchControl(txtTitle, "Title");
            report.SearchControl(txtCoppyNo, "CoppyNo");
        }

        private void dgvTable_DoubleClick(object sender, EventArgs e)
        {
            if (report.Selected > 0)
                new book.BookCoppy(report.Selected).ShowDialog();
        }
    }
}