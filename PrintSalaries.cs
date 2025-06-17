using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
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
    public partial class PrintSalaries : DevExpress.XtraEditors.XtraForm
    {
        private DBClass DBObj = new DBClass();
        public PrintSalaries()
        {
            InitializeComponent();
        }

        private void PrintSalaries_Load(object sender, EventArgs e)
        {

            InitializeComponent();
            SalaryYear();
            SalaryMonth();
            FetchLue();
        }

        private void FetchLue()
        {
            DBObj.FillLookUpEdit(lueBranch, DBObj.dataget("select BranchID, BranchName from BranchsTbl", "get"), "BranchID", "BranchName");
            //riLookCheckEdit2WithlueBranch(lueEmployee, "ContactNu", "ContactName", "ContactsTbl", "ContactNu", "BranchID", lueBranch);
        }



        public void SalaryMonth()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Month", typeof(string));
            table.Rows.Add(new object[] { 1, "January" });
            table.Rows.Add(new object[] { 2, "Februry" });
            table.Rows.Add(new object[] { 3, "March" });
            table.Rows.Add(new object[] { 4, "April" });
            table.Rows.Add(new object[] { 5, "May" });
            table.Rows.Add(new object[] { 6, "June" });
            table.Rows.Add(new object[] { 7, "July" });
            table.Rows.Add(new object[] { 8, "August" });
            table.Rows.Add(new object[] { 9, "September" });
            table.Rows.Add(new object[] { 10, "October" });
            table.Rows.Add(new object[] { 11, "November" });
            table.Rows.Add(new object[] { 12, "December" });
            lueMonth.Properties.DataSource = table;
            lueMonth.Properties.ValueMember = "ID";
            lueMonth.Properties.DisplayMember = "Month";
            lueMonth.Properties.ShowHeader = false;
        }


        public void SalaryYear()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Year", typeof(string));
            table.Rows.Add(new object[] { 2023, "2023" });
            table.Rows.Add(new object[] { 2024, "2024" });
            lueYear.Properties.DataSource = table;
            lueYear.Properties.ValueMember = "ID";
            lueYear.Properties.DisplayMember = "Year";
            lueYear.Properties.ShowHeader = false;
        }
        private DataTable GetData()
        {
            string query = $@"
                select * from tblPayrollSalariesDetails where 
                SalariesMonth = {lueMonth.EditValue} and SalariesYear = {lueYear.EditValue} and 
                BranchID = {lueBranch.EditValue} and ContactNu = {lueEmployee.EditValue}
            ";
               return DBObj.dataget(query, "get");

        }


        private DataTable GetFullSalaries()
        {
            string query = $@"
                select * from 
                (
                select SalDet.*, Cont.DepartmentID , Dep.Department, Brch.BranchName from tblPayrollSalariesDetails SalDet
                inner join ContactsTbl Cont on SalDet.ContactNu = Cont.ContactNu 
                inner join tblDepartment Dep on Cont.DepartmentID = Dep.DepartmentID
                inner join BranchsTbl Brch on SalDet.BranchID = Brch.BranchID
                ) as subQuery where SalaryMonth = {lueMonth.EditValue} and SalaryYear = {lueYear.EditValue} and BranchID = {lueBranch.EditValue}
            ";
            return DBObj.dataget(query, "get");

        }

        private void btnPreviewPrint_Click(object sender, EventArgs e)
        {
            //if (RadioGroup1.SelectedIndex == 0)
            //{
            //    rptSalariesByEmployee report = new rptSalariesByEmployee();
            //    string selectedValues = Convert.ToString(lueEmployee.EditValue);
            //    string[] valuesArray = selectedValues.Split(',');

            //    report.Parameters("Month").Value = lueMonth.EditValue;
            //    report.Parameters("Year").Value = lueYear.EditValue;
            //    report.Parameters("Employee").Value = valuesArray;
            //    report.Parameters("Branch").Value = int.Parse(lueBranch.EditValue);

            //    report.DataSource = GetData();

            //    report.CreateDocument();
            //    ReportPrintTool printTool = new ReportPrintTool(report);
            //    printTool.ShowPreview();
            //}
            //else
            //{
            //    rptFullSalaries report = new rptFullSalaries();
            //    report.DataSource = GetFullSalaries();
            //    report.CreateDocument();

            //    ReportPrintTool printTool = new ReportPrintTool(report);
            //    printTool.ShowPreview();
            //}
        }

        private void lueBranch_EditValueChanged(object sender, EventArgs e)
        {
            DBObj.FillLookUpEdit(lueBranch, DBObj.dataget("select BranchID, BranchName from BranchsTbl", "get"), "BranchID", "BranchName");

            //riLookCheckEdit2WithlueBranch(lueEmployee, "ContactNu", "ContactName", "ContactsTbl", "ContactNu", "BranchID", lueBranch);
            //lueEmployee.RefreshEditValue();
        }

        private void RadioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioGroup1.SelectedIndex == 0)
            {
                LayoutControlItem3.Enabled = true;
                LayoutControlItem4.Enabled = true;
                LayoutControlItem6.Enabled = true;
                LayoutControlItem8.Enabled = true;
            }
            else
            {
                LayoutControlItem3.Enabled = true;
                LayoutControlItem4.Enabled = true;
                LayoutControlItem6.Enabled = true;
                LayoutControlItem8.Enabled = false;
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            //rptFullSalariesSummary report = new rptFullSalariesSummary();
            //report.DataSource = GetFullSalaries();
            //report.CreateDocument();

            //ReportPrintTool printTool = new ReportPrintTool(report);
            //printTool.ShowPreviewDialog();
        }
    }
}
