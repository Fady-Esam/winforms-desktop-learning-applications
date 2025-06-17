using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFs
{
    public partial class EmployeeInfoFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass DBObj = new DBClass();
        string getEmployeeQry, getDepartmentsQuery;
        DataTable GenderDt, NationalityDt, HousingDT, cstChartDT;
        public EmployeeInfoFrm()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = GetEmployees();
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            GetDepartments();
            DepartmentLue.EditValue = 1;
            GetGenderFN();
            GetChartAccountFn();
            GetNationalityFn();
            GetEmployeesNamesFn();
        }
        
        private void GetDepartments()
        {
            getDepartmentsQuery = "select DepID, DepName from HRDepartmentsTbl";
            FillLookUpEdit(DBObj.dataget(getDepartmentsQuery, "get"), "DepID", "DepName", DepartmentLue);
        }


        private void FillGridLookUpEdit(DataTable dt, string valueMember, string displayMember,  RepositoryItemLookUpEdit name)
        {
            name.DataSource = dt;
            name.DisplayMember = displayMember;
            name.ValueMember = valueMember;
        }
        private void FillLookUpEdit(DataTable dt, string valueMember, string displayMember, LookUpEdit name)
        {
            name.Properties.DataSource = dt;
            name.Properties.DisplayMember = displayMember;
            name.Properties.ValueMember = valueMember;
        }

        public void GetChartAccountFn()
        {
            cstChartDT = DBObj.dataget("Select Accounts_Items.Account_ID, Accounts_Items.Account_Name" +
                        " From Accounts_Routs Inner Join (Accounts_Main Inner Join Accounts_Items" +
                        " ON Accounts_Main.Dep_ID = Accounts_Items.Dep_Code) ON Accounts_Routs.Route_ID = Accounts_Main.Route_ID" +
                        " ", "get");
            FillGridLookUpEdit(cstChartDT, "Account_ID", "Account_Name", lueChartAcc);
            if (cstChartDT.Rows.Count > 0)
            {
                // lueChartAcc = cstChartDT.Rows[0][0].ToString();
            }
        }


        public void GetGenderFN()
        {
            GenderDt = new DataTable();
            GenderDt.Columns.Add("Gender", typeof(string));
            GenderDt.Rows.Add("Male");
            GenderDt.Rows.Add("Female");
            FillGridLookUpEdit(GenderDt, "Gender", "Gender", lueGender);
            //lueGender.EditValue = GenderDt.Rows[0][0].ToString();
        }



        public void GetNationalityFn()
        {
            NationalityDt = new DataTable();
            NationalityDt.Columns.Add("ID", typeof(int));
            NationalityDt.Columns.Add("Nationality", typeof(string));
            NationalityDt.Rows.Add(1, "Egyptian");
            NationalityDt.Rows.Add(2, "Italian");
            FillGridLookUpEdit(NationalityDt, "ID", "Nationality", lueNationality);
            //lueNationality.EditValue = NationalityDt.Rows[0][0];
        }

        public void GetHousingFn()
        {
            HousingDT = new DataTable();
            HousingDT.Columns.Add("ID", typeof(int));
            HousingDT.Columns.Add("Housing", typeof(string));
            HousingDT.Rows.Add(1, "Housing");
            FillGridLookUpEdit(HousingDT, "ID", "Housing", lueHousing);
            //lueHousing.EditValue = HousingDT.Rows[0][0];
        }
        public DataTable GetEmployees()
        {
            //getEmployeeQry = $"Select * From ContactsTbl cont Inner Join HREmployeesTbl emp ON cont.ContactNu = emp.ContactNu where DepID = {DepartmentLue.EditValue}";
            //return DBObj.dataget(getEmployeeQry, "get");
            return new DataTable();
        }
        public void GetEmployeesNamesFn()
        {
            FillGridLookUpEdit(GetEmployees(), "ContactNu", "ContactName", lueEmployeeName);
            lueEmployeeName.Columns.Add(new LookUpColumnInfo("ContactName", "اسم الموظف"));
            lueEmployeeName.Columns.Add(new LookUpColumnInfo("ContactNu", "ID"));
        }
    }
}