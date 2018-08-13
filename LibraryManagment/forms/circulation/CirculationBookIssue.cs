using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagment.forms.circulation
{
    internal partial class CirculationBookIssue : Form
    {
        controllers.Member member = new controllers.Member();
        controllers.Book book = new controllers.Book();
        controllers.BookCoppy coppy = new controllers.BookCoppy();
        controllers.Circulation obj = new controllers.Circulation();

        DBForms.DBForm fh;
        DBForms.ShortDataList<tables.Circulation,tables.view.Circulation> report;
        internal CirculationBookIssue()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel,btnClose); 
            fh.Init<tables.Circulation, tables.Circulation>(this.panForm, obj); 

            DBForms.DBForm.SetSearchable(member, txtMemberID, MemberSelect, "ID", "MemberID");
            DBForms.DBForm.SetSearchable(coppy, txtCoppyNo, BookCoppySelect, "ID", "CoppyNo");

            report = new DBForms.ShortDataList<tables.Circulation, tables.view.Circulation>(dgvTable);
            report.SearchControl(txtMemberID, "MemberID");
            report.Where("Status", (int)CirculationStatus.Issued);
        }

        #region Private Functions

        private void MemberSelect()
        {
            if (member.info != null)
            {
                txtMemberFullName.Text = member.info.FullName;
               // report.search();
            }
        } 
        private void BookCoppySelect()
        {
            if (coppy.info != null)
            {
                book.Set(coppy.info.BookID);
                DBForms.Common.ObjectToForm<tables.Book>(gbpBook, book.info);
                txtTotalAvailable.Text = "" + controllers.BookCoppy.Count("BookID,Status", book.info.ID + "," + ((int)CoppyStatus.Avelable).ToString());
                txtBookStatus.Text = coppy.info.Status.ToString();
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (member.info == null || member.info.ID < 0)
                    throw new Exception("Member Not Selected.!");
                if (coppy.info.Status != CoppyStatus.Avelable)
                    throw new Exception("This coppy is not available for issue.!");
                if (book.info == null || book.info.ID < 0)
                    throw new Exception("Book Not Selected.!");
                obj.info.BookTitle = book.info.Title;
                obj.info.BookID = book.info.ID;
                obj.info.RegisterNo = book.info.RegisterNo;
                obj.info.MemberID = member.info.MemberID;
                obj.info.CoppyNo = coppy.info.CoppyNo;
                obj.info.Status = CirculationStatus.Issued;
                obj.info.FineStatus = FineStatus.NA;
                coppy.info.Status = CoppyStatus.Issued;
                coppy.Save();
                obj.Save();                
                MessageBox.Show("Coppy Issued successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}