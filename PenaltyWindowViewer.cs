using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFs
{
    public partial class PenaltyWindowViewer : DevExpress.XtraEditors.XtraForm
    {
        private DBClass DBobj = new DBClass();

        public PenaltyWindowViewer()
        {
            InitializeComponent();
        }

        private void PenaltyWindowViewer_Load(object sender, EventArgs e)
        {

            DBobj.FillLookUpEdit(lueBranch, DBobj.dataget("select BranchID, BranchName from BranchsTbl", "get"), "BranchID", "BranchName");
            lueBranch.EditValue = 1;
            GridControl1.DataSource = GetData();
        }



        private DataTable GetData()
        {


            string query = $@"select ded.*, emp.EmpID, emp.ContactNu, cont.ContactName, cont.BranchID, dedItem.* from HRDeductionsTbl ded 
            inner join HREmployeesTbl emp on ded.EmpID = emp.EmpID inner join ContactsTbl cont on emp.ContactNu = cont.ContactNu 
            inner join HRDeductionItemsTbl dedItem on ded.DeductionID = dedItem.DeductionID where BranchID = {lueBranch.EditValue}";


            return DBobj.dataget(query, "get");

//            DataTable dt = new DataTable();
//            try
//            {
//                string q = $@"SELECT * 
//FROM (
//    SELECT 
//        DedInfo.*, 
//        Cont.ContactName 
//    FROM 
//        tblPayrollDeductionsInformation DedInfo
//    INNER JOIN 
//        ContactsTbl Cont 
//    ON 
//        DedInfo.ContactNu = Cont.ContactNu
//) AS Subquery
//WHERE 
//    MONTH(StartDate) = {deFromPenalty.DateTime.Month} and YEAR(StartDate) = {deFromPenalty.DateTime.Year} and BranchID = {lueBranch.EditValue};";
//                dt = DBobj.dataget(query, "get");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//            return dt;
        }



        private void dePenalty_EditValueChanged(object sender, EventArgs e)
        {
            GridControl1.DataSource = GetData();
        }


        private void btnDeletePenalty_Click(object sender, EventArgs e)
        {
            //if (XtraMessageBox.Show("هل تريد حذف هذا السند ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            //{
            //    var sql = "select * from tblPayrollDeductionsInformation where DeductionID=N'" + GridView1.GetFocusedRowCellValue("DeductionID") + "'";
            //    SqlDataAdapter adp = new SqlDataAdapter(sql, connSQLserver);
            //    DataSet ds = new DataSet();
            //    adp.Fill(ds);
            //    var dt = ds.Tables(0);
            //    if (dt.Rows.Count == 0)
            //        MsgBox("فشل في جلب البيانات");
            //    else
            //    {
            //        var dr = dt.Rows(0);
            //        dr.Delete();
            //        SqlCommandBuilder cmd = new SqlCommandBuilder(adp);
            //        adp.Update(dt);
            //        dePenalty_EditValueChanged(null, null);

            //        XtraMessageBox.Show("تم حذف السند بنجاح");
            //    }
            //}
        }

        private void btnPrintPenalty_Click(object sender, EventArgs e)
        {
            //rptPenalties report = new rptPenalties();
            //report.DataSource = GetData();
            //report.CreateDocument();




            //ReportPrintTool printTool = new ReportPrintTool(report);
            //printTool.ShowPreviewDialog();
        }

        private void btnNewPenalty_Click_1(object sender, EventArgs e)
        {
            var CreatPenFrm = new CreatePenalty();
            CreatPenFrm.ShowDialog();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            GridControl1.DataSource = GetData();
        }

        private void btnDeletePenalty_Click_1(object sender, EventArgs e)
        {
            DeletePenalty();
        }

        private void DeletePenalty()
        {
            if (MessageBox.Show("هل تريد حذف هذا السند؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            else
            {
                string DeleteStr = "DELETE HRDeductionsTbl WHERE ID = " + GridView1.GetFocusedRowCellValue("ID") + " ";
                DBobj.saveway(DeleteStr);
                XtraMessageBox.Show("تم الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridControl1.DataSource = GetData();
                
            }
        }

        private void GridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeletePenalty();
            }
        }

        private void lueBranch_EditValueChanged_1(object sender, EventArgs e)
        {
            GridControl1.DataSource = GetData();
        }
    }
}


