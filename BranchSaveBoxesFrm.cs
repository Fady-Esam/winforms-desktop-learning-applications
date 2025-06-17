using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFs
{
    public partial class BranchSaveBoxesFrm : DevExpress.XtraEditors.XtraForm
    {
        public BranchSaveBoxesFrm()
        {
            InitializeComponent();
        }

        DBClass DBObj = new DBClass();

        private void BranchSaveBoxesFrm_Load(object sender, EventArgs e)
        {
            GetBranches();
            GetSaveBoxes(); 
            string getQry = "SELECT * FROM ReleationBranchSaveBoxesTbl";
            gridControl1.DataSource = DBObj.dataget(getQry, "get");
        }
        

        private void GetBranches()
        {
            string branchesQry = "SELECT * FROM BranchTbl";
            branchesLue.DataSource = DBObj.dataget(branchesQry, "get");
            branchesLue.ValueMember = "BranchID";
            branchesLue.DisplayMember = "BranchName";
            branchesLue.Columns.Add(new LookUpColumnInfo("BranchName", "الفرع"));
        }

        private void GetSaveBoxes()
        {
            string SaveBoxQry = "SELECT * FROM SaveBoxTbl";
            saveBoxesLue.DataSource = DBObj.dataget(SaveBoxQry, "get");
            saveBoxesLue.ValueMember = "SaveBoxID";
            saveBoxesLue.DisplayMember = "SaveBoxName";
            saveBoxesLue.Columns.Add(new LookUpColumnInfo("SaveBoxName", "اسم الصندوق"));
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            string insertQry = "";
            for (int x = 0; x < gridView1.RowCount; x++)
            {
                
                if (string.IsNullOrEmpty(gridView1.GetRowCellValue(x, "BranchSaveBoxRelID").ToString()))
                {
                    insertQry += "INSERT INTO ReleationBranchSaveBoxesTbl (SaveBoxID, BranchID) VALUES"
                                       + " (" + gridView1.GetRowCellValue(x, "SaveBoxID") + ", " + gridView1.GetRowCellValue(x, "BranchID") + ") ";
                }
                else
                {
                    insertQry += "UPDATE ReleationBranchSaveBoxesTbl SET SaveBoxID = " + gridView1.GetRowCellValue(x, "SaveBoxID") + ", " + "BranchID = " + gridView1.GetRowCellValue(x, "BranchID") + " " +
                        "WHERE BranchSaveBoxRelID = " + gridView1.GetRowCellValue(x, "BranchSaveBoxRelID") + " ";
                }
            }
            DBObj.saveway(insertQry);
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = DBObj.dataget("SELECT * FROM ReleationBranchSaveBoxesTbl", "get");
        }

        private void gridView1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                if (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                else
                {
                    if (string.IsNullOrEmpty(gridView1.GetFocusedRowCellValue("BranchSaveBoxRelID").ToString()))
                    {
                        if (view != null)
                        {
                            view.DeleteRow(view.FocusedRowHandle);
                        }
                    }

                    else
                    {
                        string DeleteQry = "DELETE ReleationBranchSaveBoxesTbl WHERE BranchSaveBoxRelID = " + gridView1.GetFocusedRowCellValue("BranchSaveBoxRelID") + " ";
                        DBObj.saveway(DeleteQry);
                        MessageBox.Show("تم الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControl1.DataSource = DBObj.dataget("SELECT * FROM ReleationBranchSaveBoxesTbl", "get");
                    }
                }
            }
        }
    }
}
