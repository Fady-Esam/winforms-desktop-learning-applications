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
    public partial class ContractRateFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass DBClass = new DBClass();
        public ContractRateFrm()
        {
            InitializeComponent();
        }


        int ContractId = 1;

        private void ContractRateFrm_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT * FROM tblhbContractRate WHERE ContractID = " + ContractId;
            gridControl1.DataSource = DBClass.getData(query1);
            /*
            string query2 = "SELECT * FROM tblhbContractChildRoomRate";
            gridControl2.DataSource = DBClass.getData(query2);*/
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            string insertQry = "";
            bool isSave = false;
            for (int x = 0; x < gridView1.RowCount; x++)
            {

                if (string.IsNullOrEmpty(gridView1.GetRowCellValue(x, "hbContractRateID").ToString()))
                {
                   
                    insertQry = "INSERT INTO tblhbContractRate (ContractID, RoomCategoryID, TravelPeriodsID, AdultRate, ExtraAdultRate, SGLSuppl, ApplyAs) VALUES"
                                       + " (" + ContractId + ", " + gridView1.GetRowCellValue(x, "RoomCategoryID") + ", " + gridView1.GetRowCellValue(x, "TravelPeriodsID") + ", " + gridView1.GetRowCellValue(x, "AdultRate") + ", " + gridView1.GetRowCellValue(x, "ExtraAdultRate") + ", " + gridView1.GetRowCellValue(x, "SGLSuppl") + ", " + gridView1.GetRowCellValue(x, "ApplyAs") + "); SELECT SCOPE_IDENTITY(); ";
                    isSave = true;
                }
                else
                {
                    insertQry += $"UPDATE tblhbContractRate SET ContractID = '{ContractId}', RoomCategoryID = '{gridView1.GetRowCellValue(x, "RoomCategoryID")}', TravelPeriodsID = '{gridView1.GetRowCellValue(x, "TravelPeriodsID")}', AdultRate = '{gridView1.GetRowCellValue(x, "AdultRate")}', ExtraAdultRate = '{gridView1.GetRowCellValue(x, "ExtraAdultRate")}', SGLSuppl = '{gridView1.GetRowCellValue(x, "SGLSuppl")}', ApplyAs = '{gridView1.GetRowCellValue(x, "ApplyAs")}' WHERE hbContractRateID = '{gridView1.GetRowCellValue(x, "hbContractRateID")}' ";
                }
            }
            if (isSave)
            {                                          
                int id = DBClass.insertData(insertQry);
                gridControl2.DataSource = DBClass.getData("SELECT * FROM tblhbContractChildRoomRate WHERE hbContractRateID = " + id); 
            }
            else
            {
                DBClass.saveway(insertQry);
            }
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = DBClass.getData("SELECT * FROM tblhbContractRate WHERE ContractID = " + ContractId);
        }
        int ChildRoomRateID = -1;

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string insertQry = "";
            for (int x = 0; x < gridView2.RowCount; x++)
            {
                if (string.IsNullOrEmpty(gridView2.GetRowCellValue(x, "hbContractChildID").ToString()))
                {
                    insertQry += "INSERT INTO tblhbContractChildRoomRate (hbContractPolicyChildID, hbContractRateID, hbContractRoomDetID, ChildString, ChildValue1, ChildValue2, ChildValue3, ChildValue4, ChildValue5, ApplyAs) VALUES"
                                        + " (" + gridView2.GetRowCellValue(x, "hbContractPolicyChildID") + ", " + gridView2.GetRowCellValue(x, "hbContractRateID") + ", " + gridView2.GetRowCellValue(x, "hbContractRoomDetID") + ", " + gridView2.GetRowCellValue(x, "ChildString") + ", " + gridView2.GetRowCellValue(x, "ChildValue1") + ", " + gridView2.GetRowCellValue(x, "ChildValue2") + ", " + gridView2.GetRowCellValue(x, "ChildValue3") + ", " + gridView2.GetRowCellValue(x, "ChildValue4") + ", " + gridView2.GetRowCellValue(x, "ChildValue5") + gridView2.GetRowCellValue(x, "ApplyAs") + ") ";
                }
                else
                {
                    insertQry += $"UPDATE tblhbContractChildRoomRate SET hbContractPolicyChildID = {gridView2.GetRowCellValue(x, "hbContractPolicyChildID")}, hbContractRateID = {gridView2.GetRowCellValue(x, "hbContractRateID")}, hbContractRoomDetID = {gridView2.GetRowCellValue(x, "hbContractRoomDetID")} , ChildString = '{gridView2.GetRowCellValue(x, "ChildString")}', ChildValue1 = {gridView2.GetRowCellValue(x, "ChildValue1")}, ChildValue2 = {gridView2.GetRowCellValue(x, "ChildValue2")}, ChildValue3 = {gridView2.GetRowCellValue(x, "ChildValue3")}, ChildValue4 = {gridView2.GetRowCellValue(x, "ChildValue4")}, ChildValue5 = {gridView2.GetRowCellValue(x, "ChildValue5")}, ApplyAs = {gridView2.GetRowCellValue(x, "ApplyAs")} WHERE hbContractChildID = {gridView2.GetRowCellValue(x, "hbContractChildID")} ";
                }
            }
            DBClass.saveway(insertQry);
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl2.DataSource = DBClass.getData("SELECT * FROM tblhbContractChildRoomRate WHERE hbContractRateID = " + ChildRoomRateID);

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view == null) return;
            var rowData = view.GetRow(e.RowHandle);
            if (rowData == null) return;
            var cellValue = view.GetRowCellValue(e.RowHandle, e.Column);
            if (cellValue == null) return;
            ChildRoomRateID = (int)view.GetRowCellValue(e.RowHandle, "hbContractRateID");
            string query = $"SELECT * FROM tblhbContractChildRoomRate WHERE hbContractRateID = '{ChildRoomRateID}' ";
            gridControl2.DataSource = DBClass.dataget(query);
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
