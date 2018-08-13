using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms.book
{
    internal partial class Category : Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.BookCategory, tables.BookCategory> report;
        controllers.BookCategory obj = new controllers.BookCategory();

        internal Category()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose); 
            fh.Init<tables.BookCategory, tables.BookCategory>(this.panForm, obj); 
            report = new DBForms.ListView<tables.BookCategory, tables.BookCategory>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                long id = obj.info.ID;
                obj.info = DBForms.Common.GetForm<tables.BookCategory>(this);
                obj.info.ID = id;
                obj.Save();
                MessageBox.Show("Cattegory saved successfully");
                report.search();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}