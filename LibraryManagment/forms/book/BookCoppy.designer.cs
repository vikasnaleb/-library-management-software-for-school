namespace LibraryManagment.forms.book
{
    partial class BookCoppy
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
            this.gbpForm = new System.Windows.Forms.GroupBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCoppyNo = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtRecivedFrom = new System.Windows.Forms.TextBox();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtVender = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbpBook = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAvailableCoppies = new System.Windows.Forms.TextBox();
            this.txtIssuedCoppies = new System.Windows.Forms.TextBox();
            this.txtMissingCoppies = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalCoppies = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCategoryID = new System.Windows.Forms.ComboBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisterNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.panForm.SuspendLayout();
            this.gbpForm.SuspendLayout();
            this.gbpBook.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.TopPanel.Size = new System.Drawing.Size(904, 35);
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
            this.btnClose.Location = new System.Drawing.Point(871, 3);
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
            this.label23.Size = new System.Drawing.Size(183, 16);
            this.label23.TabIndex = 3;
            this.label23.Text = "Book Coppy / Purchase Entry";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(3, 435);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(904, 3);
            this.BottomPanel.TabIndex = 13;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(907, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(3, 438);
            this.RightPanel.TabIndex = 15;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(3, 438);
            this.LeftPanel.TabIndex = 14;
            // 
            // panForm
            // 
            this.panForm.Controls.Add(this.gbpForm);
            this.panForm.Controls.Add(this.gbpBook);
            this.panForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForm.Location = new System.Drawing.Point(3, 35);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(904, 400);
            this.panForm.TabIndex = 16;
            // 
            // gbpForm
            // 
            this.gbpForm.Controls.Add(this.dtpPurchaseDate);
            this.gbpForm.Controls.Add(this.label7);
            this.gbpForm.Controls.Add(this.label11);
            this.gbpForm.Controls.Add(this.btnClear);
            this.gbpForm.Controls.Add(this.btnSave);
            this.gbpForm.Controls.Add(this.txtCoppyNo);
            this.gbpForm.Controls.Add(this.txtNote);
            this.gbpForm.Controls.Add(this.txtRecivedFrom);
            this.gbpForm.Controls.Add(this.txtBillNo);
            this.gbpForm.Controls.Add(this.label18);
            this.gbpForm.Controls.Add(this.txtVender);
            this.gbpForm.Controls.Add(this.label17);
            this.gbpForm.Controls.Add(this.txtPrice);
            this.gbpForm.Controls.Add(this.label12);
            this.gbpForm.Controls.Add(this.label10);
            this.gbpForm.Controls.Add(this.label8);
            this.gbpForm.Location = new System.Drawing.Point(543, 12);
            this.gbpForm.Name = "gbpForm";
            this.gbpForm.Size = new System.Drawing.Size(346, 366);
            this.gbpForm.TabIndex = 2;
            this.gbpForm.TabStop = false;
            this.gbpForm.Text = "Add Book Coppy";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(136, 109);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(194, 20);
            this.dtpPurchaseDate.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Purchase Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(21, 271);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Note";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(111, 324);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(224, 324);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ADD COPY";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCoppyNo
            // 
            this.txtCoppyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoppyNo.Location = new System.Drawing.Point(136, 27);
            this.txtCoppyNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCoppyNo.Name = "txtCoppyNo";
            this.txtCoppyNo.Size = new System.Drawing.Size(196, 23);
            this.txtCoppyNo.TabIndex = 0;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(136, 268);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(194, 39);
            this.txtNote.TabIndex = 6;
            // 
            // txtRecivedFrom
            // 
            this.txtRecivedFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecivedFrom.Location = new System.Drawing.Point(136, 229);
            this.txtRecivedFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecivedFrom.Name = "txtRecivedFrom";
            this.txtRecivedFrom.Size = new System.Drawing.Size(194, 23);
            this.txtRecivedFrom.TabIndex = 5;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(136, 190);
            this.txtBillNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(194, 23);
            this.txtBillNo.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(18, 230);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "Recived From";
            // 
            // txtVender
            // 
            this.txtVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVender.Location = new System.Drawing.Point(136, 149);
            this.txtVender.Margin = new System.Windows.Forms.Padding(2);
            this.txtVender.Name = "txtVender";
            this.txtVender.Size = new System.Drawing.Size(194, 23);
            this.txtVender.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(21, 192);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Bill No";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(136, 68);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(196, 23);
            this.txtPrice.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(21, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Vender / Shop";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 30);
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
            this.label8.Location = new System.Drawing.Point(17, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Price";
            // 
            // gbpBook
            // 
            this.gbpBook.Controls.Add(this.panel1);
            this.gbpBook.Controls.Add(this.cmbCategoryID);
            this.gbpBook.Controls.Add(this.txtEdition);
            this.gbpBook.Controls.Add(this.label6);
            this.gbpBook.Controls.Add(this.txtAuthor);
            this.gbpBook.Controls.Add(this.label5);
            this.gbpBook.Controls.Add(this.txtPublisher);
            this.gbpBook.Controls.Add(this.label4);
            this.gbpBook.Controls.Add(this.txtTitle);
            this.gbpBook.Controls.Add(this.label3);
            this.gbpBook.Controls.Add(this.txtRegisterNo);
            this.gbpBook.Controls.Add(this.label9);
            this.gbpBook.Controls.Add(this.label2);
            this.gbpBook.Controls.Add(this.txtISBN);
            this.gbpBook.Controls.Add(this.label1);
            this.gbpBook.Location = new System.Drawing.Point(15, 12);
            this.gbpBook.Name = "gbpBook";
            this.gbpBook.Size = new System.Drawing.Size(517, 366);
            this.gbpBook.TabIndex = 1;
            this.gbpBook.TabStop = false;
            this.gbpBook.Text = "Book";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtAvailableCoppies);
            this.panel1.Controls.Add(this.txtIssuedCoppies);
            this.panel1.Controls.Add(this.txtMissingCoppies);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtTotalCoppies);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(14, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 90);
            this.panel1.TabIndex = 33;
            // 
            // txtAvailableCoppies
            // 
            this.txtAvailableCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableCoppies.Location = new System.Drawing.Point(361, 15);
            this.txtAvailableCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvailableCoppies.Name = "txtAvailableCoppies";
            this.txtAvailableCoppies.ReadOnly = true;
            this.txtAvailableCoppies.Size = new System.Drawing.Size(107, 23);
            this.txtAvailableCoppies.TabIndex = 21;
            // 
            // txtIssuedCoppies
            // 
            this.txtIssuedCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedCoppies.Location = new System.Drawing.Point(361, 56);
            this.txtIssuedCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtIssuedCoppies.Name = "txtIssuedCoppies";
            this.txtIssuedCoppies.ReadOnly = true;
            this.txtIssuedCoppies.Size = new System.Drawing.Size(107, 23);
            this.txtIssuedCoppies.TabIndex = 21;
            // 
            // txtMissingCoppies
            // 
            this.txtMissingCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMissingCoppies.Location = new System.Drawing.Point(120, 53);
            this.txtMissingCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtMissingCoppies.Name = "txtMissingCoppies";
            this.txtMissingCoppies.ReadOnly = true;
            this.txtMissingCoppies.Size = new System.Drawing.Size(116, 23);
            this.txtMissingCoppies.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(254, 60);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "Issued";
            // 
            // txtTotalCoppies
            // 
            this.txtTotalCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCoppies.Location = new System.Drawing.Point(120, 14);
            this.txtTotalCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCoppies.Name = "txtTotalCoppies";
            this.txtTotalCoppies.ReadOnly = true;
            this.txtTotalCoppies.Size = new System.Drawing.Size(116, 23);
            this.txtTotalCoppies.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(13, 57);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Missing";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(254, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Available ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Total Coppies";
            // 
            // cmbCategoryID
            // 
            this.cmbCategoryID.BackColor = System.Drawing.Color.Silver;
            this.cmbCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryID.FormattingEnabled = true;
            this.cmbCategoryID.Location = new System.Drawing.Point(336, 199);
            this.cmbCategoryID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoryID.Name = "cmbCategoryID";
            this.cmbCategoryID.Size = new System.Drawing.Size(167, 24);
            this.cmbCategoryID.TabIndex = 6;
            // 
            // txtEdition
            // 
            this.txtEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.Location = new System.Drawing.Point(110, 202);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(139, 23);
            this.txtEdition.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Edition";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(110, 155);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(393, 23);
            this.txtAuthor.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Author";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(110, 110);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(393, 23);
            this.txtPublisher.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Publisher";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(110, 64);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(393, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Title";
            // 
            // txtRegisterNo
            // 
            this.txtRegisterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterNo.Location = new System.Drawing.Point(110, 22);
            this.txtRegisterNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegisterNo.Name = "txtRegisterNo";
            this.txtRegisterNo.Size = new System.Drawing.Size(139, 23);
            this.txtRegisterNo.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(264, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Register No";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(305, 21);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(198, 23);
            this.txtISBN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(262, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "ISBN";
            // 
            // BookCoppy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(910, 438);
            this.ControlBox = false;
            this.Controls.Add(this.panForm);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookCoppy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER FORM";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panForm.ResumeLayout(false);
            this.gbpForm.ResumeLayout(false);
            this.gbpForm.PerformLayout();
            this.gbpBook.ResumeLayout(false);
            this.gbpBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisterNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCategoryID;
        private System.Windows.Forms.GroupBox gbpBook;
        private System.Windows.Forms.GroupBox gbpForm;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCoppyNo;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAvailableCoppies;
        private System.Windows.Forms.TextBox txtTotalCoppies;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIssuedCoppies;
        private System.Windows.Forms.TextBox txtMissingCoppies;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRecivedFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnClear;
    }
}