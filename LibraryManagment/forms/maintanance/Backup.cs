using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms.maintanance
{
    internal partial class Backup : Form
    { 
        DBForms.DBForm fh;

        internal Backup()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel,btnClose); 
        }

        private void btnDatabaeBackup_Click(object sender, EventArgs e)
        {
            Core.application.BackupDatabase();
            MessageBox.Show("Database exported successfully");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Core.application.RestoreDatabase();
            MessageBox.Show("Database Imported successfully");
        }

        private void btnExportFiles_Click(object sender, EventArgs e)
        {
            Core.application.BackupFiles();
        }

        private void btnImportFiles_Click(object sender, EventArgs e)
        {
            Core.application.RestoreFiles();
        }
    }
}