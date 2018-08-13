namespace LibraryManagment.forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintanance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMemberMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMember = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMemberType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBookCoppy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCoppyStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCirculationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIssueBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBookSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFineReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMemberList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookCoppies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystemLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.panTop = new System.Windows.Forms.Panel();
            this.menuUser = new System.Windows.Forms.MenuStrip();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnIssueBook = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReturnBook = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNewMember = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMemberSearch = new System.Windows.Forms.ToolStripButton();
            this.lblSupport = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panTop.SuspendLayout();
            this.menuUser.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHome,
            this.tsmiMemberMenu,
            this.tsmiBookMenu,
            this.tsmiCirculationMenu,
            this.tsmiReportMenu,
            this.tsmiUserMenu});
            this.menuStrip.Location = new System.Drawing.Point(8, 2);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(567, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsmiHome
            // 
            this.tsmiHome.Checked = true;
            this.tsmiHome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout,
            this.tsmiSettings,
            this.tsmiMaintanance,
            this.tsmiClose});
            this.tsmiHome.ForeColor = System.Drawing.Color.White;
            this.tsmiHome.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmiHome.Name = "tsmiHome";
            this.tsmiHome.Size = new System.Drawing.Size(64, 25);
            this.tsmiHome.Text = "&Home";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(169, 26);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(169, 26);
            this.tsmiSettings.Text = "Settings";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // tsmiMaintanance
            // 
            this.tsmiMaintanance.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiMaintanance.Name = "tsmiMaintanance";
            this.tsmiMaintanance.Size = new System.Drawing.Size(169, 26);
            this.tsmiMaintanance.Text = "Maintanance";
            this.tsmiMaintanance.Click += new System.EventHandler(this.tsmiMaintanance_Click);
            // 
            // tsmiClose
            // 
            this.tsmiClose.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(169, 26);
            this.tsmiClose.Text = "Close";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // tsmiMemberMenu
            // 
            this.tsmiMemberMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMember,
            this.tsmiMemberType});
            this.tsmiMemberMenu.ForeColor = System.Drawing.Color.White;
            this.tsmiMemberMenu.Name = "tsmiMemberMenu";
            this.tsmiMemberMenu.Size = new System.Drawing.Size(81, 25);
            this.tsmiMemberMenu.Text = "&Member";
            // 
            // tsmiMember
            // 
            this.tsmiMember.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiMember.Name = "tsmiMember";
            this.tsmiMember.Size = new System.Drawing.Size(176, 26);
            this.tsmiMember.Text = "Member";
            this.tsmiMember.Click += new System.EventHandler(this.tsmiMember_Click);
            // 
            // tsmiMemberType
            // 
            this.tsmiMemberType.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiMemberType.Name = "tsmiMemberType";
            this.tsmiMemberType.Size = new System.Drawing.Size(176, 26);
            this.tsmiMemberType.Text = "Member Type";
            this.tsmiMemberType.Click += new System.EventHandler(this.tsmiMemberType_Click);
            // 
            // tsmiBookMenu
            // 
            this.tsmiBookMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBooks,
            this.tsmiBookCategory,
            this.toolStripSeparator2,
            this.tsmiBookCoppy,
            this.tsmiCoppyStatus});
            this.tsmiBookMenu.ForeColor = System.Drawing.Color.White;
            this.tsmiBookMenu.Name = "tsmiBookMenu";
            this.tsmiBookMenu.Size = new System.Drawing.Size(64, 25);
            this.tsmiBookMenu.Text = "&Books";
            // 
            // tsmiBooks
            // 
            this.tsmiBooks.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiBooks.Name = "tsmiBooks";
            this.tsmiBooks.Size = new System.Drawing.Size(197, 26);
            this.tsmiBooks.Text = "Book";
            this.tsmiBooks.Click += new System.EventHandler(this.tsmiBooks_Click);
            // 
            // tsmiBookCategory
            // 
            this.tsmiBookCategory.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiBookCategory.Name = "tsmiBookCategory";
            this.tsmiBookCategory.Size = new System.Drawing.Size(197, 26);
            this.tsmiBookCategory.Text = "Book Category";
            this.tsmiBookCategory.Click += new System.EventHandler(this.tsmiBookCategory_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // tsmiBookCoppy
            // 
            this.tsmiBookCoppy.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiBookCoppy.Name = "tsmiBookCoppy";
            this.tsmiBookCoppy.Size = new System.Drawing.Size(197, 26);
            this.tsmiBookCoppy.Text = "Coppy";
            this.tsmiBookCoppy.Click += new System.EventHandler(this.tsmiBookCoppy_Click);
            // 
            // tsmiCoppyStatus
            // 
            this.tsmiCoppyStatus.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiCoppyStatus.Name = "tsmiCoppyStatus";
            this.tsmiCoppyStatus.Size = new System.Drawing.Size(197, 26);
            this.tsmiCoppyStatus.Text = "Coppy Condition";
            this.tsmiCoppyStatus.Click += new System.EventHandler(this.tsmiCoppyStatus_Click);
            // 
            // tsmiCirculationMenu
            // 
            this.tsmiCirculationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIssueBook,
            this.tsmiReturnBook,
            this.toolStripSeparator4,
            this.tsmiBookSearch});
            this.tsmiCirculationMenu.ForeColor = System.Drawing.Color.White;
            this.tsmiCirculationMenu.Name = "tsmiCirculationMenu";
            this.tsmiCirculationMenu.Size = new System.Drawing.Size(97, 25);
            this.tsmiCirculationMenu.Text = "&Circulation";
            // 
            // tsmiIssueBook
            // 
            this.tsmiIssueBook.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiIssueBook.Name = "tsmiIssueBook";
            this.tsmiIssueBook.Size = new System.Drawing.Size(166, 26);
            this.tsmiIssueBook.Text = "Issue Book";
            this.tsmiIssueBook.Click += new System.EventHandler(this.tsmiIssueReturnBook_Click);
            // 
            // tsmiReturnBook
            // 
            this.tsmiReturnBook.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiReturnBook.Name = "tsmiReturnBook";
            this.tsmiReturnBook.Size = new System.Drawing.Size(166, 26);
            this.tsmiReturnBook.Text = "Return Book";
            this.tsmiReturnBook.Click += new System.EventHandler(this.tsmiReturnBook_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmiBookSearch
            // 
            this.tsmiBookSearch.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiBookSearch.Name = "tsmiBookSearch";
            this.tsmiBookSearch.Size = new System.Drawing.Size(166, 26);
            this.tsmiBookSearch.Text = "Search Book";
            this.tsmiBookSearch.Click += new System.EventHandler(this.tsmiBookSearch_Click);
            // 
            // tsmiReportMenu
            // 
            this.tsmiReportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFineReport,
            this.tsmiUserList,
            this.tsmiMemberList,
            this.tsmiBookList,
            this.tsmiBookCoppies,
            this.tsmiSystemLogs,
            this.tsmiUserLogs});
            this.tsmiReportMenu.ForeColor = System.Drawing.Color.White;
            this.tsmiReportMenu.Name = "tsmiReportMenu";
            this.tsmiReportMenu.Size = new System.Drawing.Size(107, 25);
            this.tsmiReportMenu.Text = "&Report / List";
            // 
            // tsmiFineReport
            // 
            this.tsmiFineReport.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiFineReport.Name = "tsmiFineReport";
            this.tsmiFineReport.Size = new System.Drawing.Size(217, 26);
            this.tsmiFineReport.Text = "Fine/Penalty Report";
            this.tsmiFineReport.Click += new System.EventHandler(this.tsmiFineReport_Click);
            // 
            // tsmiUserList
            // 
            this.tsmiUserList.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiUserList.Name = "tsmiUserList";
            this.tsmiUserList.Size = new System.Drawing.Size(217, 26);
            this.tsmiUserList.Text = "User List";
            this.tsmiUserList.Click += new System.EventHandler(this.tsmiUserList_Click);
            // 
            // tsmiMemberList
            // 
            this.tsmiMemberList.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiMemberList.Name = "tsmiMemberList";
            this.tsmiMemberList.Size = new System.Drawing.Size(217, 26);
            this.tsmiMemberList.Text = "Member List";
            this.tsmiMemberList.Click += new System.EventHandler(this.tsmiMemberList_Click);
            // 
            // tsmiBookList
            // 
            this.tsmiBookList.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiBookList.Name = "tsmiBookList";
            this.tsmiBookList.Size = new System.Drawing.Size(217, 26);
            this.tsmiBookList.Text = "Book List";
            this.tsmiBookList.Click += new System.EventHandler(this.tsmiBookList_Click);
            // 
            // tsmiBookCoppies
            // 
            this.tsmiBookCoppies.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiBookCoppies.Name = "tsmiBookCoppies";
            this.tsmiBookCoppies.Size = new System.Drawing.Size(217, 26);
            this.tsmiBookCoppies.Text = "Book Coppis List";
            this.tsmiBookCoppies.Click += new System.EventHandler(this.tsmiBookCoppies_Click);
            // 
            // tsmiSystemLogs
            // 
            this.tsmiSystemLogs.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiSystemLogs.Name = "tsmiSystemLogs";
            this.tsmiSystemLogs.Size = new System.Drawing.Size(217, 26);
            this.tsmiSystemLogs.Text = "System Logs";
            this.tsmiSystemLogs.Click += new System.EventHandler(this.tsmiSystemLogs_Click);
            // 
            // tsmiUserLogs
            // 
            this.tsmiUserLogs.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiUserLogs.Name = "tsmiUserLogs";
            this.tsmiUserLogs.Size = new System.Drawing.Size(217, 26);
            this.tsmiUserLogs.Text = "User Logs";
            this.tsmiUserLogs.Click += new System.EventHandler(this.tsmiUserLogs_Click);
            // 
            // tsmiUserMenu
            // 
            this.tsmiUserMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewUser});
            this.tsmiUserMenu.ForeColor = System.Drawing.Color.White;
            this.tsmiUserMenu.Name = "tsmiUserMenu";
            this.tsmiUserMenu.Size = new System.Drawing.Size(54, 25);
            this.tsmiUserMenu.Text = "&User";
            // 
            // tsmiNewUser
            // 
            this.tsmiNewUser.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiNewUser.Name = "tsmiNewUser";
            this.tsmiNewUser.Size = new System.Drawing.Size(148, 26);
            this.tsmiNewUser.Text = "New User";
            this.tsmiNewUser.Click += new System.EventHandler(this.tsmiNewUser_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 26);
            this.toolStripMenuItem3.Text = "Registration";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(70)))), ((int)(((byte)(127)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(985, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 22);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.menuUser);
            this.panTop.Controls.Add(this.menuStrip);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1024, 35);
            this.panTop.TabIndex = 7;
            // 
            // menuUser
            // 
            this.menuUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuUser.BackColor = System.Drawing.Color.DimGray;
            this.menuUser.Dock = System.Windows.Forms.DockStyle.None;
            this.menuUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser});
            this.menuUser.Location = new System.Drawing.Point(812, 3);
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(62, 29);
            this.menuUser.TabIndex = 1;
            this.menuUser.Text = "MenuStrip";
            // 
            // tsmiUser
            // 
            this.tsmiUser.Checked = true;
            this.tsmiUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserPassword,
            this.tsmiProfile,
            this.toolStripSeparator1,
            this.tsmiLogout});
            this.tsmiUser.ForeColor = System.Drawing.Color.White;
            this.tsmiUser.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(54, 25);
            this.tsmiUser.Text = "User";
            // 
            // tsmiUserPassword
            // 
            this.tsmiUserPassword.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiUserPassword.Name = "tsmiUserPassword";
            this.tsmiUserPassword.Size = new System.Drawing.Size(204, 26);
            this.tsmiUserPassword.Text = "Change Password";
            this.tsmiUserPassword.Click += new System.EventHandler(this.tsmiUserPassword_Click);
            // 
            // tsmiProfile
            // 
            this.tsmiProfile.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiProfile.Name = "tsmiProfile";
            this.tsmiProfile.Size = new System.Drawing.Size(204, 26);
            this.tsmiProfile.Text = "Profile";
            this.tsmiProfile.Click += new System.EventHandler(this.tsmiProfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.ForeColor = System.Drawing.Color.LightGray;
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(204, 26);
            this.tsmiLogout.Text = "Logout";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnIssueBook,
            this.tsbtnReturnBook,
            this.tsbtnNewMember,
            this.toolStripButton1,
            this.tsbtnMemberSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.toolStrip1.Size = new System.Drawing.Size(1024, 44);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnIssueBook
            // 
            this.tsbtnIssueBook.BackColor = System.Drawing.Color.DimGray;
            this.tsbtnIssueBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnIssueBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbtnIssueBook.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbtnIssueBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnIssueBook.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tsbtnIssueBook.Name = "tsbtnIssueBook";
            this.tsbtnIssueBook.Size = new System.Drawing.Size(88, 26);
            this.tsbtnIssueBook.Tag = "";
            this.tsbtnIssueBook.Text = "Issue Book";
            this.tsbtnIssueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnIssueBook.Click += new System.EventHandler(this.tsbtnIssueBook_Click);
            // 
            // tsbtnReturnBook
            // 
            this.tsbtnReturnBook.BackColor = System.Drawing.Color.DimGray;
            this.tsbtnReturnBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnReturnBook.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbtnReturnBook.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbtnReturnBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReturnBook.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tsbtnReturnBook.Name = "tsbtnReturnBook";
            this.tsbtnReturnBook.Size = new System.Drawing.Size(100, 26);
            this.tsbtnReturnBook.Tag = "";
            this.tsbtnReturnBook.Text = "Return Book";
            this.tsbtnReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnReturnBook.Click += new System.EventHandler(this.tsbtnReturnBook_Click);
            // 
            // tsbtnNewMember
            // 
            this.tsbtnNewMember.BackColor = System.Drawing.Color.DimGray;
            this.tsbtnNewMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNewMember.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbtnNewMember.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbtnNewMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewMember.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tsbtnNewMember.Name = "tsbtnNewMember";
            this.tsbtnNewMember.Size = new System.Drawing.Size(109, 26);
            this.tsbtnNewMember.Tag = "";
            this.tsbtnNewMember.Text = "New Member";
            this.tsbtnNewMember.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnNewMember.Click += new System.EventHandler(this.tsbtnNewMember_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.DimGray;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 26);
            this.toolStripButton1.Tag = "";
            this.toolStripButton1.Text = "Search Book";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnMemberSearch
            // 
            this.tsbtnMemberSearch.BackColor = System.Drawing.Color.DimGray;
            this.tsbtnMemberSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnMemberSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbtnMemberSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbtnMemberSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMemberSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tsbtnMemberSearch.Name = "tsbtnMemberSearch";
            this.tsbtnMemberSearch.Size = new System.Drawing.Size(124, 26);
            this.tsbtnMemberSearch.Tag = "";
            this.tsbtnMemberSearch.Text = "Search Member";
            this.tsbtnMemberSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbtnMemberSearch.Click += new System.EventHandler(this.tsbtnMemberSearch_Click);
            // 
            // lblSupport
            // 
            this.lblSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupport.AutoSize = true;
            this.lblSupport.BackColor = System.Drawing.Color.Silver;
            this.lblSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupport.ForeColor = System.Drawing.Color.White;
            this.lblSupport.Location = new System.Drawing.Point(812, 48);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(176, 17);
            this.lblSupport.TabIndex = 11;
            this.lblSupport.Text = "Support -  7020157389";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 580);
            this.ControlBox = false;
            this.Controls.Add(this.lblSupport);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiHome;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportMenu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.MenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserPassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnNewMember;
        private System.Windows.Forms.ToolStripMenuItem tsmiFineReport;
        private System.Windows.Forms.Label lblSupport;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripButton tsbtnReturnBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMember;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberType;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiCirculationMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueBook;
        private System.Windows.Forms.ToolStripButton tsbtnIssueBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturnBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookCoppy;
        private System.Windows.Forms.ToolStripMenuItem tsmiCoppyStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintanance;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberList;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookList;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookCoppies;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemLogs;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserLogs;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserList;
        private System.Windows.Forms.ToolStripButton tsbtnMemberSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}



