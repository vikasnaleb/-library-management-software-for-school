namespace LibraryManagment.forms.maintanance
{
    partial class Backup
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panForm = new System.Windows.Forms.Panel();
            this.gbpDatabaseBackup = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDatabaeBackup = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.panForm.SuspendLayout();
            this.gbpDatabaseBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Controls.Add(this.label23);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(397, 35);
            this.TopPanel.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::LibraryManagment.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(364, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(12, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(179, 18);
            this.label23.TabIndex = 3;
            this.label23.Text = "Import and Export data";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(3, 354);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(397, 3);
            this.BottomPanel.TabIndex = 13;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(400, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(3, 357);
            this.RightPanel.TabIndex = 15;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(3, 357);
            this.LeftPanel.TabIndex = 14;
            // 
            // panForm
            // 
            this.panForm.Controls.Add(this.gbpDatabaseBackup);
            this.panForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForm.Location = new System.Drawing.Point(3, 35);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(397, 319);
            this.panForm.TabIndex = 16;
            // 
            // gbpDatabaseBackup
            // 
            this.gbpDatabaseBackup.Controls.Add(this.btnRestore);
            this.gbpDatabaseBackup.Controls.Add(this.label1);
            this.gbpDatabaseBackup.Controls.Add(this.label5);
            this.gbpDatabaseBackup.Controls.Add(this.btnDatabaeBackup);
            this.gbpDatabaseBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpDatabaseBackup.ForeColor = System.Drawing.Color.DimGray;
            this.gbpDatabaseBackup.Location = new System.Drawing.Point(19, 24);
            this.gbpDatabaseBackup.Name = "gbpDatabaseBackup";
            this.gbpDatabaseBackup.Size = new System.Drawing.Size(363, 280);
            this.gbpDatabaseBackup.TabIndex = 25;
            this.gbpDatabaseBackup.TabStop = false;
            this.gbpDatabaseBackup.Text = "Import and Export database";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(67, 211);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(197, 30);
            this.btnRestore.TabIndex = 26;
            this.btnRestore.Text = "Import";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Save data to *.sql file";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(11, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 51);
            this.label5.TabIndex = 24;
            this.label5.Text = "Restore databse from *.sql file.  Before restore take current bakup first.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDatabaeBackup
            // 
            this.btnDatabaeBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatabaeBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.btnDatabaeBackup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDatabaeBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabaeBackup.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatabaeBackup.ForeColor = System.Drawing.Color.White;
            this.btnDatabaeBackup.Location = new System.Drawing.Point(67, 81);
            this.btnDatabaeBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatabaeBackup.Name = "btnDatabaeBackup";
            this.btnDatabaeBackup.Size = new System.Drawing.Size(197, 30);
            this.btnDatabaeBackup.TabIndex = 26;
            this.btnDatabaeBackup.Text = "Export ";
            this.btnDatabaeBackup.UseVisualStyleBackColor = false;
            this.btnDatabaeBackup.Click += new System.EventHandler(this.btnDatabaeBackup_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(403, 357);
            this.ControlBox = false;
            this.Controls.Add(this.panForm);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Backup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER FORM";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panForm.ResumeLayout(false);
            this.gbpDatabaseBackup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.GroupBox gbpDatabaseBackup;
        private System.Windows.Forms.Button btnDatabaeBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}