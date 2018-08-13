namespace LibraryManagment.forms.circulation
{
    partial class BookSearch
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panForm = new System.Windows.Forms.Panel();
            this.gpbBookDetails = new System.Windows.Forms.GroupBox();
            this.cmbCategoryID = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPublishingYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestroidCoppies = new System.Windows.Forms.TextBox();
            this.txtIssuedCoppies = new System.Windows.Forms.TextBox();
            this.txtMissingCoppies = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalCoppies = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBadConditionCoppies = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAvailableCoppies = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegisterNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPree = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            this.panForm.SuspendLayout();
            this.gpbBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Controls.Add(this.lblTitle);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(886, 35);
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
            this.btnClose.Location = new System.Drawing.Point(851, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(63, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Book List";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(3, 506);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(886, 3);
            this.BottomPanel.TabIndex = 13;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(889, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(3, 509);
            this.RightPanel.TabIndex = 15;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(3, 509);
            this.LeftPanel.TabIndex = 14;
            // 
            // panForm
            // 
            this.panForm.Controls.Add(this.gpbBookDetails);
            this.panForm.Controls.Add(this.label1);
            this.panForm.Controls.Add(this.txtBookTitle);
            this.panForm.Controls.Add(this.dgvTable);
            this.panForm.Controls.Add(this.btnLast);
            this.panForm.Controls.Add(this.btnFirst);
            this.panForm.Controls.Add(this.btnPree);
            this.panForm.Controls.Add(this.btnNext);
            this.panForm.Controls.Add(this.txtBookAuthor);
            this.panForm.Controls.Add(this.label16);
            this.panForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForm.Location = new System.Drawing.Point(3, 35);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(886, 471);
            this.panForm.TabIndex = 16;
            // 
            // gpbBookDetails
            // 
            this.gpbBookDetails.Controls.Add(this.cmbCategoryID);
            this.gpbBookDetails.Controls.Add(this.txtPrice);
            this.gpbBookDetails.Controls.Add(this.label8);
            this.gpbBookDetails.Controls.Add(this.label9);
            this.gpbBookDetails.Controls.Add(this.txtPublishingYear);
            this.gpbBookDetails.Controls.Add(this.label7);
            this.gpbBookDetails.Controls.Add(this.txtEdition);
            this.gpbBookDetails.Controls.Add(this.label6);
            this.gpbBookDetails.Controls.Add(this.txtAuthor);
            this.gpbBookDetails.Controls.Add(this.label5);
            this.gpbBookDetails.Controls.Add(this.txtPublisher);
            this.gpbBookDetails.Controls.Add(this.label4);
            this.gpbBookDetails.Controls.Add(this.txtTitle);
            this.gpbBookDetails.Controls.Add(this.label3);
            this.gpbBookDetails.Controls.Add(this.txtDestroidCoppies);
            this.gpbBookDetails.Controls.Add(this.txtIssuedCoppies);
            this.gpbBookDetails.Controls.Add(this.txtMissingCoppies);
            this.gpbBookDetails.Controls.Add(this.label15);
            this.gpbBookDetails.Controls.Add(this.label13);
            this.gpbBookDetails.Controls.Add(this.txtTotalCoppies);
            this.gpbBookDetails.Controls.Add(this.label12);
            this.gpbBookDetails.Controls.Add(this.label11);
            this.gpbBookDetails.Controls.Add(this.txtBadConditionCoppies);
            this.gpbBookDetails.Controls.Add(this.label14);
            this.gpbBookDetails.Controls.Add(this.txtAvailableCoppies);
            this.gpbBookDetails.Controls.Add(this.label10);
            this.gpbBookDetails.Controls.Add(this.txtRegisterNo);
            this.gpbBookDetails.Controls.Add(this.label2);
            this.gpbBookDetails.Location = new System.Drawing.Point(427, 12);
            this.gpbBookDetails.Name = "gpbBookDetails";
            this.gpbBookDetails.Size = new System.Drawing.Size(439, 446);
            this.gpbBookDetails.TabIndex = 41;
            this.gpbBookDetails.TabStop = false;
            this.gpbBookDetails.Text = "Book Details";
            // 
            // cmbCategoryID
            // 
            this.cmbCategoryID.BackColor = System.Drawing.Color.Silver;
            this.cmbCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryID.Enabled = false;
            this.cmbCategoryID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryID.FormattingEnabled = true;
            this.cmbCategoryID.Location = new System.Drawing.Point(119, 373);
            this.cmbCategoryID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoryID.Name = "cmbCategoryID";
            this.cmbCategoryID.Size = new System.Drawing.Size(304, 24);
            this.cmbCategoryID.TabIndex = 37;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(119, 411);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(304, 23);
            this.txtPrice.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 413);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 376);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Category";
            // 
            // txtPublishingYear
            // 
            this.txtPublishingYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublishingYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublishingYear.Location = new System.Drawing.Point(120, 335);
            this.txtPublishingYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtPublishingYear.Name = "txtPublishingYear";
            this.txtPublishingYear.ReadOnly = true;
            this.txtPublishingYear.Size = new System.Drawing.Size(303, 23);
            this.txtPublishingYear.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Publish Year";
            // 
            // txtEdition
            // 
            this.txtEdition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.Location = new System.Drawing.Point(119, 296);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.ReadOnly = true;
            this.txtEdition.Size = new System.Drawing.Size(304, 23);
            this.txtEdition.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Edition";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(120, 256);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(303, 23);
            this.txtAuthor.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Author";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(120, 217);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(303, 23);
            this.txtPublisher.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Publisher";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(120, 177);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(303, 23);
            this.txtTitle.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Title";
            // 
            // txtDestroidCoppies
            // 
            this.txtDestroidCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestroidCoppies.Location = new System.Drawing.Point(319, 96);
            this.txtDestroidCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestroidCoppies.Name = "txtDestroidCoppies";
            this.txtDestroidCoppies.ReadOnly = true;
            this.txtDestroidCoppies.Size = new System.Drawing.Size(104, 23);
            this.txtDestroidCoppies.TabIndex = 23;
            // 
            // txtIssuedCoppies
            // 
            this.txtIssuedCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedCoppies.Location = new System.Drawing.Point(319, 57);
            this.txtIssuedCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtIssuedCoppies.Name = "txtIssuedCoppies";
            this.txtIssuedCoppies.ReadOnly = true;
            this.txtIssuedCoppies.Size = new System.Drawing.Size(104, 23);
            this.txtIssuedCoppies.TabIndex = 23;
            // 
            // txtMissingCoppies
            // 
            this.txtMissingCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMissingCoppies.Location = new System.Drawing.Point(319, 20);
            this.txtMissingCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtMissingCoppies.Name = "txtMissingCoppies";
            this.txtMissingCoppies.ReadOnly = true;
            this.txtMissingCoppies.Size = new System.Drawing.Size(104, 23);
            this.txtMissingCoppies.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(246, 98);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Destroied";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(246, 59);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Issued";
            // 
            // txtTotalCoppies
            // 
            this.txtTotalCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCoppies.Location = new System.Drawing.Point(119, 20);
            this.txtTotalCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCoppies.Name = "txtTotalCoppies";
            this.txtTotalCoppies.ReadOnly = true;
            this.txtTotalCoppies.Size = new System.Drawing.Size(104, 23);
            this.txtTotalCoppies.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(246, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Missing";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(15, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total Coppies";
            // 
            // txtBadConditionCoppies
            // 
            this.txtBadConditionCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBadConditionCoppies.Location = new System.Drawing.Point(120, 98);
            this.txtBadConditionCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtBadConditionCoppies.Name = "txtBadConditionCoppies";
            this.txtBadConditionCoppies.ReadOnly = true;
            this.txtBadConditionCoppies.Size = new System.Drawing.Size(103, 23);
            this.txtBadConditionCoppies.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(16, 99);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Bad Condition";
            // 
            // txtAvailableCoppies
            // 
            this.txtAvailableCoppies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableCoppies.Location = new System.Drawing.Point(120, 59);
            this.txtAvailableCoppies.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvailableCoppies.Name = "txtAvailableCoppies";
            this.txtAvailableCoppies.ReadOnly = true;
            this.txtAvailableCoppies.Size = new System.Drawing.Size(103, 23);
            this.txtAvailableCoppies.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Available";
            // 
            // txtRegisterNo
            // 
            this.txtRegisterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterNo.Location = new System.Drawing.Point(120, 137);
            this.txtRegisterNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegisterNo.Name = "txtRegisterNo";
            this.txtRegisterNo.ReadOnly = true;
            this.txtRegisterNo.Size = new System.Drawing.Size(303, 23);
            this.txtRegisterNo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Register No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Book Name";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(98, 20);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(303, 20);
            this.txtBookTitle.TabIndex = 39;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTable.Location = new System.Drawing.Point(15, 93);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(397, 314);
            this.dgvTable.TabIndex = 36;
            this.dgvTable.DoubleClick += new System.EventHandler(this.dgvTable_DoubleClick);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Black;
            this.btnLast.Image = global::LibraryManagment.Properties.Resources.sign_last;
            this.btnLast.Location = new System.Drawing.Point(274, 422);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 30);
            this.btnLast.TabIndex = 34;
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Black;
            this.btnFirst.Image = global::LibraryManagment.Properties.Resources.sign_first;
            this.btnFirst.Location = new System.Drawing.Point(112, 422);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFirst.Size = new System.Drawing.Size(50, 30);
            this.btnFirst.TabIndex = 33;
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnPree
            // 
            this.btnPree.BackColor = System.Drawing.Color.Transparent;
            this.btnPree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPree.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPree.ForeColor = System.Drawing.Color.Black;
            this.btnPree.Image = global::LibraryManagment.Properties.Resources.sign_left;
            this.btnPree.Location = new System.Drawing.Point(166, 422);
            this.btnPree.Margin = new System.Windows.Forms.Padding(2);
            this.btnPree.Name = "btnPree";
            this.btnPree.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPree.Size = new System.Drawing.Size(50, 30);
            this.btnPree.TabIndex = 32;
            this.btnPree.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::LibraryManagment.Properties.Resources.sign_right;
            this.btnNext.Location = new System.Drawing.Point(220, 422);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 30);
            this.btnNext.TabIndex = 31;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(12, 61);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "Author";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAuthor.Location = new System.Drawing.Point(98, 55);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(303, 23);
            this.txtBookAuthor.TabIndex = 31;
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(892, 509);
            this.ControlBox = false;
            this.Controls.Add(this.panForm);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "BookSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER FORM";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panForm.ResumeLayout(false);
            this.panForm.PerformLayout();
            this.gpbBookDetails.ResumeLayout(false);
            this.gpbBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPree;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.GroupBox gpbBookDetails;
        private System.Windows.Forms.TextBox txtRegisterNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPublishingYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAvailableCoppies;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMissingCoppies;
        private System.Windows.Forms.TextBox txtTotalCoppies;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIssuedCoppies;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDestroidCoppies;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBadConditionCoppies;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCategoryID;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label label16;
    }
}