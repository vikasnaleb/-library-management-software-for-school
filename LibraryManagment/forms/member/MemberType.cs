using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms.member
{
    internal partial class MemberType : Form
    {
        DBForms.DBForm fh;
        DBForms.ListView<tables.MemberType, tables.MemberType> report;
        controllers.MyController<tables.MemberType> obj = new controllers.MyController<tables.MemberType>();

        internal MemberType()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            fh.Init<tables.MemberType, tables.MemberType>(this.panForm, obj);
            report = new DBForms.ListView<tables.MemberType, tables.MemberType>(panForm, "", DBForms.helper.Printing.MyPrinter.DataGrideViewPrinter);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                long id = obj.info.ID;
                obj.info = DBForms.Common.GetForm<tables.MemberType>(this);
                obj.info.ID = id;
                DBForms.DBForm.checkConditions(obj.info);
                obj.Save();
                MessageBox.Show("Cattegory saved successfully");
                report.search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}