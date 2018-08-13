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
    internal partial class BookCondition : Form
    {
        controllers.BookCoppy coppy = new controllers.BookCoppy();
        controllers.BookCondition obj = new controllers.BookCondition();
        DBForms.DBForm fh;

        internal BookCondition()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose); 
            fh.Init<tables.BookCondition, tables.BookCondition>(this.panForm, obj); 
            DBForms.DBForm.SetSearchable(coppy,txtCoppyNo, SelectCoppy, "ID", "CoppyNo");
        }

        internal BookCondition(long ID)
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            fh.Init<tables.BookCondition, tables.BookCondition>(this.panForm, obj);
            DBForms.DBForm.SetSearchable(coppy, txtCoppyNo, SelectCoppy, "ID", "CoppyNo");

            if (ID > 0)
            {
                obj.Set(ID);
                DBForms.DBForm.SetForm<tables.BookCondition>(obj, panForm); 
                btnSave.Text = "UPDATE";
            }
        }

        private void SelectCoppy()
        {
            if (coppy.info.ID > 0)
            {
                txtTitle.Text = coppy.info.Title;
                txtPrice.Text = coppy.info.Price.ToString();
                dtpPurchaseDate.Value = coppy.info.PurchaseDate;
                obj.First("CopyNo", coppy.info.CoppyNo);
                if (obj.info.ID > 0)
                {
                    DBForms.DBForm.SetForm(obj, gbpForm1);
                    btnSave.Text = "UPDATE";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (coppy.info == null || coppy.info.ID <= 0)
                    throw new Exception("Coppy not selected");
                if (coppy.info.Status == CoppyStatus.Issued)
                    throw new Exception("This book coppy is already issued to a memeber...");
                long id = obj.info.ID;
                obj.info = DBForms.Common.GetForm<tables.BookCondition>(gbpForm1);
                obj.info.ID = id;
                obj.info.CoppyNo = coppy.info.CoppyNo;
                coppy.info.Status = obj.info.Status == CoppyCondition.Bad?CoppyStatus.Bad: obj.info.Status == CoppyCondition.Missing ?CoppyStatus.Missing : obj.info.Status == CoppyCondition.Avelable ? CoppyStatus.Avelable : CoppyStatus.Destroid;
                coppy.Save();
                obj.Save();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbpForm_Enter(object sender, EventArgs e)
        {

        }
    }
}