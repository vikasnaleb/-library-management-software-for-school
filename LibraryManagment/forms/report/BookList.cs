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
    internal partial class BookList: Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.Book, tables.view.Book> report;
        internal BookList()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose, null, btnMaximize);
            report = new DBForms.ListView<tables.Book, tables.view.Book>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
            report.SearchControl(txtTitle, "Title");
        }

        private void dgvTable_DoubleClick(object sender, EventArgs e)
        {
            if (report.Selected > 0)
                new book.Book(report.Selected).ShowDialog();
        }
    }
}