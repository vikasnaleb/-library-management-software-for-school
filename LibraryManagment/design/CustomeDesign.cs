using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.design
{ 
    internal class CustomeDesign
    {

        internal static void Label_Resize(Object obj, EventArgs e)
        {
            System.Windows.Forms.Label lbl = (System.Windows.Forms.Label)obj;
            System.Drawing.Font f = lbl.Font;
            float fs = f.Size;
            f = lbl.Font;
            fs = f.Size;
            while (lbl.Width < System.Windows.Forms.TextRenderer.MeasureText(lbl.Text, f).Width)
                f = new System.Drawing.Font(f.FontFamily, fs--, f.Style, f.Unit);
            lbl.Font = f;
        }

        internal static void Set(System.Windows.Forms.DataGridView dgv, int MinRows = 5)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSourceChanged += delegate (object sender, EventArgs e) {
                if (dgv.Columns.Contains("ID"))
                {
                    dgv.Columns["ID"].Visible = false;
                }
            };
        }
    }

}
