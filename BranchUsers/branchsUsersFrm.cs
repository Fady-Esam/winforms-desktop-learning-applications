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
    public partial class branchsUsersFrm : DevExpress.XtraEditors.XtraForm
    {

        DataTable branchDT, usersDT,usersLinkDT;
        string getBranchs, usersQry, insertQry, DeleteStr;
        DBClass DBObj = new DBClass();

        public branchsUsersFrm()
        {
            InitializeComponent();
        }




        private void GetBranchInfo()
        {
            getBranchs = "SELECT BranchID, BranchName, InvoiceSerialing FROM BranchsTbl ";
            branchDT = DBObj.dataget(getBranchs, "get");
            branchsLue.DataSource = branchDT;
            branchsLue.DisplayMember = "BranchName";
            branchsLue.ValueMember = "BranchID";
            branchsLue.Columns.Add(new LookUpColumnInfo("BranchID", "الكود", 5));
            branchsLue.Columns.Add(new LookUpColumnInfo("BranchName", "اسم الفرع"));
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question ,MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                else
                {
                    if (gridView1.GetFocusedRowCellValue("ID").ToString() == "")
                    {
                        if (view != null)
                        {
                            view.DeleteRow(view.FocusedRowHandle);
                        }
                    }
                    else
                    {
                        DeleteStr = "DELETE BranchsUsersTbl WHERE ID = " + gridView1.GetFocusedRowCellValue("ID") + " ";
                        DBObj.saveway(DeleteStr, "", 0);
                        XtraMessageBox.Show("تم الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usersLinkDT.Rows.Clear();
                        usersLinkDT = DBObj.dataget("SELECT * FROM BranchsUsersTbl", "get");
                        gridControl1.DataSource = usersLinkDT;
                    }
                }                  
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            insertQry = "";
            for (int x = 0; x < gridView1.RowCount; x++)
            {
                //MessageBox.Show(gridViewPrices.GetRowCellValue(x, "ID").ToString());
                if (gridView1.GetRowCellValue(x, "ID").ToString() == "")
                {
                    insertQry += " INSERT INTO BranchsUsersTbl (UserID, BranchID, IsActive) VALUES"
                                       + " (" + gridView1.GetRowCellValue(x, "UserID") + " , " + gridView1.GetRowCellValue(x, "BranchID") + " ,"
                                       + " " + Convert.ToInt16(gridView1.GetRowCellValue(x, "IsActive")) + " ) ";
                }
                else
                {
                    insertQry += " UPDATE BranchsUsersTbl SET UserID =  " + gridView1.GetRowCellValue(x, "UserID") + ","
                                       + " BranchID = " + gridView1.GetRowCellValue(x, "BranchID") + ", IsActive = " + Convert.ToInt16(gridView1.GetRowCellValue(x, "IsActive")) + " "
                                       + " WHERE ID = " + gridView1.GetRowCellValue(x, "ID") + " ";
                }
            }

            DBObj.saveway(insertQry, "", 0);

            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            usersLinkDT.Rows.Clear();
            usersLinkDT = DBObj.dataget("SELECT * FROM BranchsUsersTbl", "get");
                       gridControl1.DataSource = usersLinkDT;
        }

        private void GetUsers()
        {
            usersQry = "Select UserID, FullName From UsersTbl";
            usersDT = DBObj.dataget(usersQry, "get");
            usersLue.DataSource = usersDT;
            usersLue.DisplayMember = "FullName";
            usersLue.ValueMember = "UserID";
            usersLue.Columns.Add(new LookUpColumnInfo("UserID", "الكود", 5));
            usersLue.Columns.Add(new LookUpColumnInfo("FullName", "اسم المستخدم"));
        }

        private void branchsUsersFrm_Load(object sender, EventArgs e)
        {
            GetBranchInfo();
            GetUsers();

            usersLinkDT = DBObj.dataget("SELECT * FROM BranchsUsersTbl", "get");
            gridControl1.DataSource = usersLinkDT;

        }
    }
}