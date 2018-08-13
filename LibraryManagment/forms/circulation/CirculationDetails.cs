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
    internal partial class CirculationDetails : Form
    {
        controllers.Member member = new controllers.Member();  
        controllers.Circulation obj = new controllers.Circulation(); 
        DBForms.DBForm fh;

        internal CirculationDetails(long id)
        { 
            InitializeComponent();
            if (id <= 0)
                this.Close();
            fh = new DBForms.DBForm(this, TopPanel, btnClose);
            fh.Init<tables.Circulation, tables.Circulation>(this.panForm, obj);
            obj.Set(id); 
            member.First("MemberID", obj.info.MemberID);
            DBForms.DBForm.SetForm(obj, panForm);
            txtMemberFullName.Text = member.info.FullName;
        }
         
    }
}