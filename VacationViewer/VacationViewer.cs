using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class VacationViewer : DevExpress.XtraEditors.XtraForm
    {
        private DBClass DBobj = new DBClass();
        private string saveQry, getEmployeesNamesQry, getDataQry, DelQry;
        DataTable GridDt;

        public VacationViewer()
        {
            InitializeComponent();
        }

        private void FillLookUpEdit(LookUpEdit name, DataTable dt, string valueMember, string displayMember)
        {
            name.Properties.DataSource = dt;
            name.Properties.DisplayMember = displayMember;
            name.Properties.ValueMember = valueMember;
        }
        public void FillGridLookUpEdit(RepositoryItemLookUpEdit lue, DataTable dt, string valMember, string disMember)
        {
            lue.ValueMember = valMember;
            lue.DisplayMember = disMember;
            lue.DataSource = dt;
            
        }
        private void GetEmployeesNames()
        {
            getEmployeesNamesQry = $"select emp.EmpID, cont.ContactName from HREmployeesTbl emp inner join ContactsTbl cont on emp.ContactNu = cont.ContactNu where cont.BranchID = {lueBranch.EditValue}";
            FillGridLookUpEdit(lueEmployeesNames, DBobj.dataget(getEmployeesNamesQry, "get"), "EmpID", "ContactName");
        }

        private void VacationViewer_Load(object sender, EventArgs e)
        {
            FillLookUpEdit(lueBranch, DBobj.dataget("select BranchID, BranchName from BranchsTbl", "get"), "BranchID", "BranchName");
            lueBranch.EditValue = 1;
            GetEmployeesNames();
            FillGridLookUpEdit(lueAttendType, DBobj.dataget("select * from HRAttendTypeTbl", "get"), "AttendTypeID", "AttendType");
            FillGridLookUpEdit(lueCurrency, DBobj.dataget("select CurrName from CurrencyTbl", "get"), "CurrName", "CurrName");
            GetData();
        }
        private void GetData()
        {
            getDataQry = $"select attend.*, cont.ContactName, Brch.BranchName, atType.AttendType from  HRAttendanceTbl attend inner join HREmployeesTbl emp on attend.EmpID = emp.EmpID inner join ContactsTbl cont on emp.ContactNu = cont.ContactNu inner join BranchsTbl Brch on cont.BranchID = Brch.BranchID inner join HRAttendTypeTbl atType on attend.AttendTypeID = atType.AttendTypeID where cont.BranchID = {lueBranch.EditValue}";
            GridDt = DBobj.dataget(getDataQry, "get");
            gridControl1.DataSource = GridDt;

        }
        private void DeleteFn(object sender)
        {
            if (XtraMessageBox.Show("هل تريد حذف هذا السند ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                if (gridView1.GetFocusedRowCellValue("ID") == null || gridView1.GetFocusedRowCellValue("ID").ToString() == "")
                {
                    if (view != null)
                    {
                        view.DeleteRow(view.FocusedRowHandle);
                    }
                }
                else
                {
                    DelQry = $"Delete HRAttendanceTbl where ID = {gridView1.GetFocusedRowCellValue("ID")}";
                    DBobj.saveway(DelQry);
                    XtraMessageBox.Show("تم حذف السند بنجاح");
                    GridDt.Rows.Clear();
                    GetData();
                }
            }
        }

        private void btnDeleteVacation_Click_1(object sender, EventArgs e)
        {
            DeleteFn(sender);
        }

        private void btnPrintVacation_Click_1(object sender, EventArgs e)
        {
            var report = new rptVacations();
            report.DataSource = gridControl1.DataSource;
            report.CreateDocument();
            var printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteFn(sender);
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            GetData();
        }

        private void lueBranch_EditValueChanged_1(object sender, EventArgs e)
        {
            GetEmployeesNames();
            GetData();
        }

        private void btnNewVacation_Click_1(object sender, EventArgs e)
        {
            saveQry = "";
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "ID").ToString() == "")
                {
                    saveQry += $@" insert into HRAttendanceTbl (EmpID, AttendTypeID, startDate, ReturnToWork, Amount, Currency, Reason) 
                    values ({gridView1.GetRowCellValue(i, "EmpID")}, {gridView1.GetRowCellValue(i, "AttendTypeID")}, 
                    '{gridView1.GetRowCellValue(i, "startDate")}', '{gridView1.GetRowCellValue(i, "ReturnToWork")}',
                    {gridView1.GetRowCellValue(i, "Amount")}, N'{gridView1.GetRowCellValue(i, "Currency")}', N'{gridView1.GetRowCellValue(i, "Reason")}'); ";
                }
                else
                {
                    saveQry += $@" UPDATE HRAttendanceTbl 
                          SET EmpID = {gridView1.GetRowCellValue(i, "EmpID")},
                          AttendTypeID = {gridView1.GetRowCellValue(i, "AttendTypeID")}, 
                          startDate = '{gridView1.GetRowCellValue(i, "startDate")}', 
                          ReturnToWork = '{gridView1.GetRowCellValue(i, "ReturnToWork")}', 
                          Amount = {gridView1.GetRowCellValue(i, "Amount")}, 
                          Currency = N'{gridView1.GetRowCellValue(i, "Currency")}', 
                          Reason = N'{gridView1.GetRowCellValue(i, "Reason")}'
                          WHERE ID = {gridView1.GetRowCellValue(i, "ID")}; ";
                }
            }
            DBobj.saveway(saveQry);
            XtraMessageBox.Show("تم حفظ البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridDt.Rows.Clear();
            GetData();
        }
    }
}







