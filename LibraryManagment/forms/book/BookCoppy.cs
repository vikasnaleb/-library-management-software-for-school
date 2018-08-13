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
    internal partial class BookCoppy : Form
    {
        controllers.BookCoppy obj = new controllers.BookCoppy();
        controllers.Book b = new controllers.Book();
        DBForms.DBForm fh;

        internal BookCoppy()
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            fh.Init<tables.BookCoppy, tables.BookCoppy>(this.panForm, obj);
            //fh.SetFormButtons<tables.BookCoppy>(obj, gbpForm, btnSave, btnClear);
            DBForms.DBForm.PopulateCombobox<tables.BookCategory>(cmbCategoryID, "ID", "CategoryName");
            DBForms.DBForm.SetSearchable(b, txtRegisterNo, BookSelect, "ID", "RegisterNo");
            DBForms.DBForm.SetSearchable(b, txtTitle, BookSelect, "ID", "Title");
        }

        internal BookCoppy(long id)
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            DBForms.DBForm.PopulateCombobox<tables.BookCategory>(cmbCategoryID, "ID", "CategoryName");
            DBForms.DBForm.SetSearchable(b, txtRegisterNo, BookSelect, "ID", "RegisterNo");
            DBForms.DBForm.SetSearchable(b, txtTitle, BookSelect, "ID", "Title");
            gbpBook.Enabled = false;
            txtCoppyNo.Enabled = false;
            if (id >= 0)
            {
                obj.Set(id);
                b.Set(obj.info.BookID);
                fh.Init<tables.BookCoppy, tables.BookCoppy>(this.panForm, obj);
                BookSelect();
                DBForms.Common.ObjectToForm(gbpForm, obj.info);
                btnSave.Text = "SAVE CHANGES";
            }
        }

        internal void BookSelect()
        { 
            if (b.info != null)
            {
                DBForms.Common.ObjectToForm(gbpBook, b.info);
                txtTotalCoppies.Text =""+ controllers.BookCoppy.Count("BookID", b.info.ID.ToString());
                txtAvailableCoppies.Text = "" + controllers.BookCoppy.Count("BookID,Status", b.info.ID+","+((int)CoppyStatus.Avelable).ToString());
                txtMissingCoppies.Text = "" + controllers.BookCoppy.Count("BookID,Status", b.info.ID + "," + ((int)CoppyStatus.Missing).ToString());
                txtIssuedCoppies.Text = "" + controllers.BookCoppy.Count("BookID,Status", b.info.ID + "," + ((int)CoppyStatus.Issued).ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBForms.DBForm.checkConditions(obj.info);
                long id = obj.info.ID;
                obj.info = DBForms.Common.GetForm<tables.BookCoppy>(this);
                obj.info.ID = id;
                obj.info.BookID = b.info.ID;
                obj.info.Title = b.info.Title;
                obj.info.Author = b.info.Author;
                obj.info.Edition = b.info.Edition;
                obj.Save();
                MessageBox.Show("Coppy saved successfully"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}