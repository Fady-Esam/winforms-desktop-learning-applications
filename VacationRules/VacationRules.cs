using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class VacationRules : DevExpress.XtraEditors.XtraForm
    {
        string getEmployeesNamesQry, saveQry, getDataQry, DelQry;
        DBClass DBobj = new DBClass();
        DataTable GridDt;
        public VacationRules()
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
        private void VacationRules_Load(object sender, EventArgs e)
        {
            FillLookUpEdit(lueBranches, DBobj.dataget("select BranchID, BranchName from BranchsTbl", "get"), "BranchID", "BranchName");
            lueBranches.EditValue = 1;
            GetEmployeesNames();
            GetAttendTypes();
            GetData();
        }

        private void lueBranches_EditValueChanged(object sender, EventArgs e)
        {
            GetEmployeesNames();
            GetData();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                if (MessageBox.Show("هل تريد الحذف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;

                else
                {
                    if (gridView1.GetFocusedRowCellValue("VacationRulesID").ToString() == "")
                    {
                        if (view != null)
                        {
                            view.DeleteRow(view.FocusedRowHandle);
                        }
                    }
                    else
                    {
                        DelQry = "DELETE HRVacationRulesTbl WHERE VacationRulesID = " + gridView1.GetFocusedRowCellValue("VacationRulesID") + " ";
                        DBobj.saveway(DelQry);
                        XtraMessageBox.Show("تم الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridDt.Rows.Clear();
                        GetData();
                    }
                }
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveQry = "";
            for(int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "VacationRulesID").ToString() == "")
                {

                    saveQry += $@" insert into HRVacationRulesTbl (EmpID, VacationDays, ApplyAs, Year, AttendTypeID, Carryover) 
                    values ({gridView1.GetRowCellValue(i, "EmpID")}, {gridView1.GetRowCellValue(i, "VacationDays")}, 
                     N'{gridView1.GetRowCellValue(i, "ApplyAs")}',  {gridView1.GetRowCellValue(i, "Year")}, 
                    {gridView1.GetRowCellValue(i, "AttendTypeID")}, {(gridView1.GetRowCellValue(i, "Carryover")?.ToString() == "" ? 0 : Convert.ToInt32(gridView1.GetRowCellValue(i, "Carryover")))}); ";
                }
                else
                {
                    saveQry += $@" UPDATE HRVacationRulesTbl 
                SET EmpID = {gridView1.GetRowCellValue(i, "EmpID")}, 
                VacationDays = {gridView1.GetRowCellValue(i, "VacationDays")}, 
                ApplyAs = N'{gridView1.GetRowCellValue(i, "ApplyAs")}', 
                Year = {gridView1.GetRowCellValue(i, "Year")}, 
                AttendTypeID = {gridView1.GetRowCellValue(i, "AttendTypeID")}, 
                Carryover = {(gridView1.GetRowCellValue(i, "Carryover")?.ToString() == "" ? 0 : Convert.ToInt32(gridView1.GetRowCellValue(i, "Carryover")))} 
                WHERE VacationRulesID = {gridView1.GetRowCellValue(i, "VacationRulesID")};";

                }
            }
            DBobj.saveway(saveQry);
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridDt.Rows.Clear();
            GetData();

        }

        private void GetData()
        {
            getDataQry = $"select vacRul.* from  HRVacationRulesTbl vacRul inner join HREmployeesTbl emp on vacRul.EmpID = emp.EmpID inner join ContactsTbl cont on emp.ContactNu = cont.ContactNu where cont.BranchID = {lueBranches.EditValue}";
            GridDt = DBobj.dataget(getDataQry, "get");
            gridControl1.DataSource = GridDt;
        }
        private void GetEmployeesNames()
        {
            getEmployeesNamesQry = $"select emp.EmpID, cont.ContactName from HREmployeesTbl emp inner join ContactsTbl cont on emp.ContactNu = cont.ContactNu where cont.BranchID = {lueBranches.EditValue}";
            FillGridLookUpEdit(lueEmployeesNames, DBobj.dataget(getEmployeesNamesQry, "get"), "EmpID", "ContactName");
        }
        private void GetAttendTypes()
        {
            FillGridLookUpEdit(lueAttendTypes, DBobj.dataget("select * from HRAttendTypeTbl", "get"), "AttendTypeID", "AttendType");
        }

    }
}