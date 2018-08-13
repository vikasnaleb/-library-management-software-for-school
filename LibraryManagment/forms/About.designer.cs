namespace LibraryManagment.forms
{
    internal partial class About
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
            this.panForm = new System.Windows.Forms.Panel();
            this.txtAbout = new System.Windows.Forms.RichTextBox();
            this.TopPanel.SuspendLayout();
            this.panForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkViolet;
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Controls.Add(this.label23);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(525, 35);
            this.TopPanel.TabIndex = 13;
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
            this.btnClose.Location = new System.Drawing.Point(492, 3);
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
            this.label23.Size = new System.Drawing.Size(51, 18);
            this.label23.TabIndex = 3;
            this.label23.Text = "About";
            // 
            // panForm
            // 
            this.panForm.Controls.Add(this.txtAbout);
            this.panForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForm.Location = new System.Drawing.Point(0, 35);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(525, 437);
            this.panForm.TabIndex = 17;
            // 
            // txtAbout
            // 
            this.txtAbout.Location = new System.Drawing.Point(12, 13);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.ReadOnly = true;
            this.txtAbout.Size = new System.Drawing.Size(498, 409);
            this.txtAbout.TabIndex = 0;
            this.txtAbout.Text = "";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(525, 472);
            this.ControlBox = false;
            this.Controls.Add(this.panForm);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USER FORM";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.RichTextBox txtAbout;
    }
}