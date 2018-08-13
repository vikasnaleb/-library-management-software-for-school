using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms
{
    internal partial class Settings : Form
    { 
        DBForms.DBForm fh;
        controllers.Settings obj = new controllers.Settings();
        internal Settings()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel,btnClose);
            fh.Init<tables.Settings, tables.Settings>(this.panForm, obj); 
            fh.SetFormButtons(obj, panForm, btnSave);
            if (controllers.Settings.Count()>0)
            {
                obj.First();
                DBForms.DBForm.SetForm(obj, panForm);
            }
            DBForms.DBForm.SetPictureBox(pcbInstituteLogo, btnSelectLogo);
            DBForms.DBForm.SetPictureBox(pcbInstituteBackground, btnSelectBackground);
        }

        private void btnSelectLogo_Click(object sender, EventArgs e)
        {
            
        }
    }
}