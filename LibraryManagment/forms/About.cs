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
    internal partial class About : Form
    { 
        DBForms.DBForm fh;

        internal About()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel,btnClose);
            txtAbout.Text = "Library Mangament is open source software developed in C#.\r";
        } 
    }
}