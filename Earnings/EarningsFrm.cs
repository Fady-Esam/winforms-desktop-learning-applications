using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
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
    public partial class EarningsFrm : DevExpress.XtraEditors.XtraForm
    {
        private string getEmployeesNamesQry, saveQry, getDataQry, DelQry;
        private DBClass DBobj = new DBClass();
        private DataTable GridDt;
        public EarningsFrm()
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

        private void EarningsFrm_Load(object sender, EventArgs e)
        {
            FillLookUpEdit(lueBranches, DBobj.dataget("select BranchID, BranchName from BranchsTbl", "get"), "BranchID", "BranchName");
            lueBranches.EditValue = 1;
            GetEmployeesNames();
            GetEarnings();
            GetData();
        }
        private void DeleteFn(object sender)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (MessageBox.Show("هل تريد الحذف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;
            
            else
            {
                if (gridView1.GetFocusedRowCellValue("ID") == null || gridView1.GetFocusedRowCellValue("ID").ToString() == "")
                {
                    if (view != null)
                    {
                        view.DeleteRow(view.FocusedRowHandle);
                    }
                }
                else
                {
                    DelQry = "DELETE HREarningsTbl WHERE ID = " + gridView1.GetFocusedRowCellValue("ID") + " ";
                    DBobj.saveway(DelQry);
                    XtraMessageBox.Show("تم الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridDt.Rows.Clear();
                    GetData();
                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteFn(sender);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFn(sender);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveQry = "";
            for(int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "ID").ToString() == "")
                {
                    saveQry += $@" insert into HREarningsTbl (EmpID, EarningID, EarningAmount, DateFrom, DateTo, Details) 
                    values ({gridView1.GetRowCellValue(i, "EmpID")}, {gridView1.GetRowCellValue(i, "EarningID")}, 
                    {gridView1.GetRowCellValue(i, "EarningAmount")}, '{gridView1.GetRowCellValue(i, "DateFrom")}', 
                    '{gridView1.GetRowCellValue(i, "DateTo")}', N'{gridView1.GetRowCellValue(i, "Details")}'); ";
                }
                else
                {
                    saveQry += $@" UPDATE HREarningsTbl 
                        SET EmpID = {gridView1.GetRowCellValue(i, "EmpID")}, 
                        EarningID = {gridView1.GetRowCellValue(i, "EarningID")},
                        EarningAmount = {gridView1.GetRowCellValue(i, "EarningAmount")}, 
                        DateFrom = '{gridView1.GetRowCellValue(i, "DateFrom")}', 
                        DateTo = '{gridView1.GetRowCellValue(i, "DateTo")}', 
                        Details = N'{gridView1.GetRowCellValue(i, "Details")}' 
                        WHERE ID = {gridView1.GetRowCellValue(i, "ID")};";
                }
            }
            DBobj.saveway(saveQry);
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridDt.Rows.Clear();
            GetData();
        }

        private void lueBranches_EditValueChanged(object sender, EventArgs e)
        {
            GetEmployeesNames();
            GetData();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            //var report = new rptEarnings();
            //report.DataSource = gridControl1.DataSource;
            //report.CreateDocument();
            //var printTool = new ReportPrintTool(report);
            //printTool.ShowPreviewDialog();
        }
        private void GetData()
        {
            getDataQry = $@"select earn.*, Brch.BranchName, cont.ContactName, earnIt.EarningName from HREarningsTbl earn inner join 
                        HREmployeesTbl emp on earn.EmpID = emp.EmpID inner join ContactsTbl cont on emp.ContactNu = cont.ContactNu inner join 
                        BranchsTbl Brch on cont.BranchID = Brch.BranchID inner join 
                        HREarningItemsTbl earnIt on earn.EarningID = earnIt.EarningID where cont.BranchID = {lueBranches.EditValue}";
            GridDt = DBobj.dataget(getDataQry, "get");
            gridControl1.DataSource = GridDt;
        }


        private void GetEmployeesNames()
        {
            getEmployeesNamesQry = $"select emp.EmpID, cont.ContactName from HREmployeesTbl emp inner join ContactsTbl cont on emp.ContactNu = cont.ContactNu where cont.BranchID = {lueBranches.EditValue}";
            FillGridLookUpEdit(lueEmployeesNames, DBobj.dataget(getEmployeesNamesQry, "get"), "EmpID", "ContactName");
        }

        private void GetEarnings()
        {
            FillGridLookUpEdit(lueEarnings, DBobj.dataget("select EarningID, EarningName from HREarningItemsTbl", "get"), "EarningID", "EarningName");
        }

    }
}




