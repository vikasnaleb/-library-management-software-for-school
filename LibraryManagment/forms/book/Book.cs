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
    internal partial class Book : Form
    {
        controllers.Book obj = new controllers.Book();
        DBForms.DBForm fh;

        internal Book()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose); 
            fh.Init<tables.Book, tables.Book>(this.panForm, obj); 
            fh.SetFormButtons(obj, panForm, btnSave, btnReset);
            DBForms.DBForm.PopulateCombobox<tables.BookCategory>(cmbCategoryID, "ID", "CategoryName");
        }

        internal Book(long ID)
        {
            InitializeComponent();
            DBForms.DBForm.PopulateCombobox<tables.BookCategory>(cmbCategoryID, "ID", "CategoryName");
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            fh.Init<tables.Book, tables.Book>(this.panForm, obj);
            fh.SetFormButtons(obj, panForm, btnSave, btnReset);
            btnReset.Visible = false;
          
            if (ID > 0)
            {
                obj.Set(ID);
                DBForms.DBForm.SetForm<tables.Book>(obj, panForm); 
                btnSave.Text = "UPDATE";
            }
        }

    }
}