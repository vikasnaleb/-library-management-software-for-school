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
    internal partial class CirculationBookReturn : Form
    {
        controllers.Member member = new controllers.Member(); 
        controllers.BookCoppy coppy = new controllers.BookCoppy();
        controllers.Circulation obj = new controllers.Circulation(); 
        DBForms.DBForm fh;
        DBForms.ShortDataList<tables.Circulation,tables.view.Circulation> report;

        internal CirculationBookReturn()
        { 
            InitializeComponent();
            fh = new DBForms.DBForm(this, TopPanel,btnClose); 
            fh.Init<tables.Circulation, tables.Circulation>(this.panForm, obj); 
            DBForms.DBForm.SetSearchable(member, txtMemberID, MemberSelect, "ID", "MemberID");
            DBForms.DBForm.PopulateComobobox(cmbCirculationStatus, typeof(CirculationStatus));
            report = new DBForms.ShortDataList<tables.Circulation, tables.view.Circulation>(dgvTable);
            report.SearchControl(txtMemberID, "MemberID");
            report.SearchControl(cmbCirculationStatus, "Status");
            cmbCirculationStatus.SelectedIndex = 0;
            DBForms.DBForm.SetDateRange(dtpIssuedDate, dtpReturnDate);
        }
         
        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0) {
                long selected = (long)dgvTable.SelectedRows[0].Cells["ID"].Value;
                obj.Set(selected);
                coppy.First("CoppyNo", obj.info.CoppyNo);
                txtBookTitle.Text = obj.info.BookTitle;
                txtCoppyNo.Text = obj.info.CoppyNo;
                dtpReturnDate.MinDate = obj.info.IssuedDate.AddDays(1);
                dtpIssuedDate.MaxDate = obj.info.ReturnDate.AddDays(-1);
                dtpIssuedDate.Value = obj.info.IssuedDate;
                dtpReturnDate.Value = obj.info.ReturnDate;
                txtFine.Text = ""+obj.info.Fine;
                cmbFineStatus.SelectedIndex = (int)obj.info.FineStatus;
                cmbStatus.SelectedIndex = (int)obj.info.Status;
                txtNote.Text = obj.info.Note;
                int x = controllers.Circulation.Count("BookID,Status,ID!=", coppy.info.BookID + "," + (int)CirculationStatus.Issued+","+obj.info.ID);
                cmbStatus.Enabled = !(x > 0) && (coppy.info.Status == CoppyStatus.Avelable || coppy.info.Status == CoppyStatus.Issued);
                dtpReturnDate.Enabled = !(x > 0) && (coppy.info.Status == CoppyStatus.Avelable || coppy.info.Status == CoppyStatus.Issued);
                dtpIssuedDate.Enabled = !(x > 0) && (coppy.info.Status == CoppyStatus.Avelable || coppy.info.Status == CoppyStatus.Issued);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (member.info == null || member.info.ID < 0)
                    throw new Exception("Member Not Selected.!"); 

                obj.info.ReturnDate = dtpReturnDate.Value;
                obj.info.Fine = double.Parse(txtFine.Text.Trim());
                obj.info.Status =  (CirculationStatus)cmbStatus.SelectedIndex;
                obj.info.FineStatus = (FineStatus)cmbFineStatus.SelectedIndex;

                if (obj.info.Fine > 0 && obj.info.FineStatus== FineStatus.NA)
                {
                    throw new Exception("Select fine status PAID / UNPAID");
                }

                if (obj.info.Status == CirculationStatus.Returned)
                    coppy.info.Status = CoppyStatus.Avelable;
                else if (obj.info.Status == CirculationStatus.Issued)
                    coppy.info.Status = CoppyStatus.Issued;
                else
                    coppy.info.Status = CoppyStatus.Missing;

                coppy.Save();
                obj.Save();
                report.search();
                MessageBox.Show("Book returned successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Private Methods
        internal void MemberSelect()
        {
            if (member.info != null)
            {
                txtMemberFullName.Text = member.info.FullName;
            }
        }
        #endregion


    }
}