using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms.circulation
{
    internal partial class BookSearch : Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.Book, tables.view.BooksList> report;
        controllers.Book book = new controllers.Book();
        internal BookSearch()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            report = new DBForms.ListView<tables.Book, tables.view.BooksList>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
            report.SearchControl(txtBookTitle, "Title");
            report.SearchControl(txtBookAuthor, "Author");
            DBForms.DBForm.PopulateCombobox<tables.BookCategory>(cmbCategoryID, "ID", "CategoryName");
        }

        private void dgvTable_DoubleClick(object sender, EventArgs e)
        {
            if (report.Selected > 0)
            {
                book.Set(report.Selected);
                DBForms.Common.ObjectToForm(gpbBookDetails, book.info);
                txtTotalCoppies.Text = "" + book.TotalCoppies();
                txtAvailableCoppies.Text = "" + book.TotalCoppies(CoppyStatus.Avelable);
                txtMissingCoppies.Text = "" + book.TotalCoppies(CoppyStatus.Missing);
                txtIssuedCoppies.Text = "" + book.TotalCoppies(CoppyStatus.Issued);
                txtBadConditionCoppies.Text = "" + book.TotalCoppies(CoppyStatus.Bad);
                txtDestroidCoppies.Text = "" + book.TotalCoppies(CoppyStatus.Destroid);
            }
        }
    }
}