using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment.forms
{
    internal partial class Main : Form
    {
        Form current;

        internal Main()
        {

            InitializeComponent();
            menuStrip.Renderer = new ToolStripProfessionalRenderer(new design.MenuColorTable());
            menuUser.Renderer = new ToolStripProfessionalRenderer(new design.MenuColorTable());
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
            tsmiUser.Text += " " + Core._user.info.Username;
            if(Core._user.info.UserType != UserTypes.Admin)
            {
                tsmiUserMenu.Visible = false;
                tsmiReportMenu.Visible = false;
            }
           // show(new Dashbord());
        } 

        private void show(Form form, bool maximize = false)
        {
            form.MdiParent = this;
            form.Activate();
            form.Show();
            form.ControlBox = false;
            if (maximize)
            form.WindowState = FormWindowState.Maximized;
            form.Activated += delegate (Object sender, EventArgs e)
            {
                if (current != null)
                    current.Activate();                
            };
        }

        private void open(Form form, bool maximize = false)
        {
            if (current != null)
            {               
                current.Visible = false;
            }

            current?.Dispose();
            current = form;
            current.FormClosing += Current_FormClosing;
            current.MdiParent = this;
            current.Activate();
            current.Show();
            current.TopMost = true;
            this.ControlBox = false;
            if (maximize)
                current.WindowState = FormWindowState.Maximized;
        }

        private void Current_FormClosing(object sender, FormClosingEventArgs e)
        {
            current?.Dispose();
            current = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiNewUser_Click(object sender, EventArgs e)
        {
            open(new user.User());
        }

        private void tsmiUserList_Click(object sender, EventArgs e)
        {
            open(new report.UserList());
        }

        private void tsmiBookCategory_Click(object sender, EventArgs e)
        {
            open(new book.Category());
        }

        private void tsmiBooks_Click(object sender, EventArgs e)
        {
            open(new book.Book(1));
        }

        private void tsmiBookList_Click(object sender, EventArgs e)
        {
            open(new report.BookList());
        }

        private void tsmiMemberList_Click(object sender, EventArgs e)
        {
            open(new report.MemberList());
        }

        private void tsmiMemberType_Click(object sender, EventArgs e)
        {
            open(new member.MemberType());
        }

        private void tsmiMember_Click(object sender, EventArgs e)
        {
            open(new member.Member());
        }

        private void tsmiIssueReturnBook_Click(object sender, EventArgs e)
        {
            open(new circulation.CirculationBookIssue());
        }

        private void tsmiReturnBook_Click(object sender, EventArgs e)
        {
            open(new circulation.CirculationBookReturn());
        }

        private void tsmiBookCoppy_Click(object sender, EventArgs e)
        {
            open(new book.BookCoppy());
        }

        private void tsmiCoppyStatus_Click(object sender, EventArgs e)
        {
            open(new book.BookCondition());
        }

        private void tsmiBookCoppies_Click(object sender, EventArgs e)
        {
            open(new report.BookCoppisList());
        }

        private void tsmiBookSearch_Click(object sender, EventArgs e)
        {
            open(new circulation.BookSearch());
        }

        private void tsmiSystemLogs_Click(object sender, EventArgs e)
        {
            open(new logs.SystemLogs());
        }

        private void tsmiUserLogs_Click(object sender, EventArgs e)
        {
            open(new logs.UserLogs());
        }

        private void tsmiMaintanance_Click(object sender, EventArgs e)
        {
            open(new maintanance.Backup());
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            open(new Settings());
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            open(new About());
        }

        private void tsmiProfile_Click(object sender, EventArgs e)
        {
            open(new user.Profile(Core._user.info.ID));
        }

        private void tsmiUserPassword_Click(object sender, EventArgs e)
        {
            open(new user.Password(Core._user.info.ID));
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            Core.Logout();
        }

        private void tsmiFineReport_Click(object sender, EventArgs e)
        {
            open(new report.FineList());
        }

        private void tsbtnIssueBook_Click(object sender, EventArgs e)
        {
            open(new circulation.CirculationBookIssue());
        }

        private void tsbtnReturnBook_Click(object sender, EventArgs e)
        {
            open(new circulation.CirculationBookReturn());

        }

        private void tsbtnNewMember_Click(object sender, EventArgs e)
        {
            open(new member.Member());

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            open(new circulation.BookSearch());

        }

        private void tsbtnMemberSearch_Click(object sender, EventArgs e)
        {
            open(new report.MemberList());

        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}