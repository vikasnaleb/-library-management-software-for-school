namespace LibraryManagment.forms.book
{
    partial class BookCondition
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
            this.gbpForm1 = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpReportedDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbpForm = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCoppyNo = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.panForm.SuspendLayout();
            this.gbpForm1.SuspendLayout();
            this.gbpForm.SuspendLayout();
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
            this.TopPanel.Size = new System.Drawing.Size(769, 35);
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
            this.btnClose.Location = new System.Drawing.Point(736, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(12, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(189, 16);
            this.label23.TabIndex = 3;
            this.label23.Text = "Book Coppy Status / Condition";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(3, 299);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(769, 3);
            this.BottomPanel.TabIndex = 13;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(772, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(3, 302);
            this.RightPanel.TabIndex = 15;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(3, 302);
            this.LeftPanel.TabIndex = 14;
            // 
            // panForm
            // 
            this.panForm.Controls.Add(this.gbpForm1);
            this.panForm.Controls.Add(this.gbpForm);
            this.panForm.Controls.Add(this.label3);
            this.panForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForm.Location = new System.Drawing.Point(3, 35);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(769, 264);
            this.panForm.TabIndex = 16;
            // 
            // gbpForm1
            // 
            this.gbpForm1.Controls.Add(this.cmbStatus);
            this.gbpForm1.Controls.Add(this.txtDescription);
            this.gbpForm1.Controls.Add(this.dtpReportedDate);
            this.gbpForm1.Controls.Add(this.btnSave);
            this.gbpForm1.Controls.Add(this.label2);
            this.gbpForm1.Controls.Add(this.label11);
            this.gbpForm1.Controls.Add(this.label1);
            this.gbpForm1.Location = new System.Drawing.Point(392, 47);
            this.gbpForm1.Name = "gbpForm1";
            this.gbpForm1.Size = new System.Drawing.Size(355, 201);
            this.gbpForm1.TabIndex = 34;
            this.gbpForm1.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Silver;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(142, 116);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(194, 24);
            this.cmbStatus.TabIndex = 46;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(142, 27);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(194, 39);
            this.txtDescription.TabIndex = 21;
            // 
            // dtpReportedDate
            // 
            this.dtpReportedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReportedDate.Location = new System.Drawing.Point(142, 81);
            this.dtpReportedDate.Name = "dtpReportedDate";
            this.dtpReportedDate.Size = new System.Drawing.Size(194, 20);
            this.dtpReportedDate.TabIndex = 45;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(227, 159);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(27, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Reported Date";
            // 
            // gbpForm
            // 
            this.gbpForm.Controls.Add(this.txtTitle);
            this.gbpForm.Controls.Add(this.label4);
            this.gbpForm.Controls.Add(this.dtpPurchaseDate);
            this.gbpForm.Controls.Add(this.label7);
            this.gbpForm.Controls.Add(this.txtCoppyNo);
            this.gbpForm.Controls.Add(this.txtPrice);
            this.gbpForm.Controls.Add(this.label12);
            this.gbpForm.Controls.Add(this.label10);
            this.gbpForm.Controls.Add(this.label8);
            this.gbpForm.Location = new System.Drawing.Point(25, 47);
            this.gbpForm.Name = "gbpForm";
            this.gbpForm.Size = new System.Drawing.Size(346, 201);
            this.gbpForm.TabIndex = 33;
            this.gbpForm.TabStop = false;
            this.gbpForm.Enter += new System.EventHandler(this.gbpForm_Enter);
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(136, 69);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(196, 23);
            this.txtTitle.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Title";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Enabled = false;
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(136, 150);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(194, 20);
            this.dtpPurchaseDate.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Purchase Date";
            // 
            // txtCoppyNo
            // 
            this.txtCoppyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoppyNo.Location = new System.Drawing.Point(136, 27);
            this.txtCoppyNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCoppyNo.Name = "txtCoppyNo";
            this.txtCoppyNo.Size = new System.Drawing.Size(196, 23);
            this.txtCoppyNo.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(136, 109);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(196, 23);
            this.txtPrice.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(21, 215);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(21, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Coppy  No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Use this form for register Missing / Destroied coppies";
            // 
            // BookCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(775, 302);
            this.ControlBox = false;
            this.Controls.Add(this.panForm);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookCondition";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER FORM";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panForm.ResumeLayout(false);
            this.panForm.PerformLayout();
            this.gbpForm1.ResumeLayout(false);
            this.gbpForm1.PerformLayout();
            this.gbpForm.ResumeLayout(false);
            this.gbpForm.PerformLayout();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpReportedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbpForm1;
        private System.Windows.Forms.GroupBox gbpForm;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCoppyNo;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}