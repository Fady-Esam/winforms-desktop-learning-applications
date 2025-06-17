using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmBranchStores : DevExpress.XtraEditors.XtraForm
    {
        public FrmBranchStores()
        {
            InitializeComponent();
        }

        DBClass DBObj = new DBClass();

        private void FrmBranchStores_Load(object sender, EventArgs e)
        {
            GetBranches();
            GetStroes();
            string qury = "SELECT * FROM ReleationBranchStoresTbl";
            gridControl1.DataSource = DBObj.dataget(qury, "get");
        }
        private void GetBranches()
        {
            string branchesQry = "SELECT * FROM BranchTbl";
            branchesLue.DataSource = DBObj.dataget(branchesQry, "get");
            branchesLue.ValueMember = "BranchID";
            branchesLue.DisplayMember = "BranchName";
            branchesLue.Columns.Add(new LookUpColumnInfo("BranchName", "الفرع"));
        }
        private void GetStroes()
        {
            string storesQry = "SELECT * FROM StoreTbl";
            storesLue.DataSource = DBObj.dataget(storesQry, "get");
            storesLue.ValueMember = "StoreID";
            storesLue.DisplayMember = "StoreName";
            storesLue.Columns.Add(new LookUpColumnInfo("StoreName", "المخزن"));
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {    
            string insertQry = "";
            for (int x = 0; x < gridView1.RowCount; x++)
            {
                if (string.IsNullOrEmpty(gridView1.GetRowCellValue(x, "BranchStoreRelID").ToString()))
                {
                    insertQry += "INSERT INTO ReleationBranchStoresTbl (StoreID, BranchID) VALUES"
                   + " (" + gridView1.GetRowCellValue(x, "StoreID") + ", " + gridView1.GetRowCellValue(x, "BranchID") + ") "; 
                }
                else
                {
                    
                    insertQry += "UPDATE ReleationBranchStoresTbl SET StoreID = " + gridView1.GetRowCellValue(x, "StoreID") + ", " + "BranchID = " + gridView1.GetRowCellValue(x, "BranchID") + " " +
                        "WHERE BranchStoreRelID = " + gridView1.GetRowCellValue(x, "BranchStoreRelID") + " ";
                }
            }
            DBObj.saveway(insertQry);
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = DBObj.dataget("SELECT * FROM ReleationBranchStoresTbl", "get");
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

                    if (string.IsNullOrEmpty(gridView1.GetFocusedRowCellValue("BranchStoreRelID").ToString()))
                    {
                        if (view != null)
                        {
                            view.DeleteRow(view.FocusedRowHandle);
                        }
                    }
                    else
                    {
                        string DeleteQry = "DELETE ReleationBranchStoresTbl WHERE BranchStoreRelID = " + gridView1.GetFocusedRowCellValue("BranchStoreRelID") + " ";
                        DBObj.saveway(DeleteQry);
                        MessageBox.Show("تم الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControl1.DataSource = DBObj.dataget("SELECT * FROM ReleationBranchStoresTbl", "get");
                    }
                }
            }
        }

    }
}





