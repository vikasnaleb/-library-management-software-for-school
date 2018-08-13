namespace LibraryManagment.forms.circulation
{
    partial class CirculationBookReturn
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
            this.btnSave = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFineStatus = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.txtCoppyNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCirculationStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberFullName = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            this.panForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(244, 357);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Controls.Add(this.label23);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(903, 35);
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
            this.btnClose.Location = new System.Drawing.Point(870, 3);
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
            this.label23.Location = new System.Drawing.Point(12, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 16);
            this.label23.TabIndex = 3;
            this.label23.Text = "Return Book";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(3, 464);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(903, 3);
            this.BottomPanel.TabIndex = 13;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(906, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(3, 467);
            this.RightPanel.TabIndex = 15;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(3, 467);
            this.LeftPanel.TabIndex = 14;
            // 
            // panForm
            // 
            this.panForm.Controls.Add(this.panel1);
            this.panForm.Controls.Add(this.label11);
            this.panForm.Controls.Add(this.label8);
            this.panForm.Controls.Add(this.cmbCirculationStatus);
            this.panForm.Controls.Add(this.label2);
            this.panForm.Controls.Add(this.dgvTable);
            this.panForm.Controls.Add(this.txtMemberID);
            this.panForm.Controls.Add(this.txtMemberFullName);
            this.panForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForm.Location = new System.Drawing.Point(3, 35);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(903, 429);
            this.panForm.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.dtpReturnDate);
            this.panel1.Controls.Add(this.dtpIssuedDate);
            this.panel1.Controls.Add(this.cmbFineStatus);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.txtFine);
            this.panel1.Controls.Add(this.txtCoppyNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBookTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(552, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 398);
            this.panel1.TabIndex = 44;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = " ";
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(110, 122);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(214, 20);
            this.dtpReturnDate.TabIndex = 43;
            // 
            // dtpIssuedDate
            // 
            this.dtpIssuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssuedDate.Location = new System.Drawing.Point(110, 85);
            this.dtpIssuedDate.Name = "dtpIssuedDate";
            this.dtpIssuedDate.Size = new System.Drawing.Size(214, 20);
            this.dtpIssuedDate.TabIndex = 43;
            // 
            // cmbFineStatus
            // 
            this.cmbFineStatus.BackColor = System.Drawing.Color.Silver;
            this.cmbFineStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFineStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFineStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFineStatus.FormattingEnabled = true;
            this.cmbFineStatus.Location = new System.Drawing.Point(110, 238);
            this.cmbFineStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFineStatus.Name = "cmbFineStatus";
            this.cmbFineStatus.Size = new System.Drawing.Size(214, 24);
            this.cmbFineStatus.TabIndex = 42;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Silver;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(110, 197);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(214, 24);
            this.cmbStatus.TabIndex = 42;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(110, 278);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(214, 68);
            this.txtNote.TabIndex = 40;
            // 
            // txtFine
            // 
            this.txtFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.Location = new System.Drawing.Point(110, 159);
            this.txtFine.Margin = new System.Windows.Forms.Padding(2);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(214, 23);
            this.txtFine.TabIndex = 40;
            // 
            // txtCoppyNo
            // 
            this.txtCoppyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoppyNo.Location = new System.Drawing.Point(110, 47);
            this.txtCoppyNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCoppyNo.Name = "txtCoppyNo";
            this.txtCoppyNo.Size = new System.Drawing.Size(214, 23);
            this.txtCoppyNo.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Return Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 281);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Note";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(7, 241);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Penalty Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Issued Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Fine / Penalty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Coppy No";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(110, 9);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(214, 23);
            this.txtBookTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Book Title";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(26, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Previous Record";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Member ID";
            // 
            // cmbCirculationStatus
            // 
            this.cmbCirculationStatus.BackColor = System.Drawing.Color.Silver;
            this.cmbCirculationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCirculationStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCirculationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCirculationStatus.FormattingEnabled = true;
            this.cmbCirculationStatus.Location = new System.Drawing.Point(364, 108);
            this.cmbCirculationStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCirculationStatus.Name = "cmbCirculationStatus";
            this.cmbCirculationStatus.Size = new System.Drawing.Size(154, 24);
            this.cmbCirculationStatus.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Full Name";
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTable.Location = new System.Drawing.Point(25, 135);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(493, 260);
            this.dgvTable.TabIndex = 37;
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellContentClick);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(113, 20);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(173, 23);
            this.txtMemberID.TabIndex = 0;
            // 
            // txtMemberFullName
            // 
            this.txtMemberFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberFullName.Location = new System.Drawing.Point(113, 65);
            this.txtMemberFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberFullName.Name = "txtMemberFullName";
            this.txtMemberFullName.ReadOnly = true;
            this.txtMemberFullName.Size = new System.Drawing.Size(405, 23);
            this.txtMemberFullName.TabIndex = 0;
            // 
            // CirculationBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(909, 467);
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
            this.Name = "CirculationBookReturn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER FORM";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panForm.ResumeLayout(false);
            this.panForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberFullName;
        private System.Windows.Forms.TextBox txtCoppyNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpIssuedDate;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbFineStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCirculationStatus;
    }
}