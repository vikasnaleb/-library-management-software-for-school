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
    internal partial class Member : Form
    {
        controllers.Member obj = new controllers.Member();
        DBForms.DBForm fh;

        internal Member()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel,btnClose); 
            fh.Init<tables.Member, tables.Member>(this.panForm, obj); 
            fh.SetFormButtons(obj, panForm, btnSave, btnReset);
            DBForms.DBForm.PopulateCombobox<tables.MemberType>(cmbMemberType, "ID", "TypeName");
        }

        internal Member(long ID)
        {
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel,btnClose);
            fh.Init<tables.Member, tables.Member>(this.panForm, obj);
            fh.SetFormButtons(obj, panForm, btnSave, btnReset);
            DBForms.DBForm.PopulateCombobox<tables.MemberType>(cmbMemberType, "ID", "TypeName");
            btnReset.Visible = false;
          
            if (ID > 0)
            {
                obj.Set(ID);
                DBForms.DBForm.SetForm(obj, panForm); 
                btnSave.Text = "UPDATE";
            }
        } 
    }
}