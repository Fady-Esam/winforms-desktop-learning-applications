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
    public partial class AddEmpFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass DBObj = new DBClass();
        string saveQry, currenyEmpQry, saveGeneQry, getGeneTypes, getCurrency, getGridData;
        int contactNu;
        DataTable GenderDt, NationalityDt, HousingDT, cstChartDT, currentEmpDT, EffectTypeDt, GridDt;

        private void FillLookUpEdit(DataTable dt, string valueMember, string displayMember, LookUpEdit name)
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
        public void GetChartAccountFn()
        {
            cstChartDT = DBObj.dataget("Select Accounts_Items.Account_ID, Accounts_Items.Account_Name" +
                        " From Accounts_Routs Inner Join (Accounts_Main Inner Join Accounts_Items" +
                        " ON Accounts_Main.Dep_ID = Accounts_Items.Dep_Code) ON Accounts_Routs.Route_ID = Accounts_Main.Route_ID" +
                        " ", "get");
            //Where Accounts_Items.Acc_Type = 'Emp'
            FillLookUpEdit(cstChartDT, "Account_ID", "Account_Name", chartAccLue);
            if(cstChartDT.Rows.Count > 0)
            {
                chartAccLue.EditValue = cstChartDT.Rows[0][0].ToString();
            }
        }
        public void GetGenderFN()
        {
            GenderDt = new DataTable();
            GenderDt.Columns.Add("Gender", typeof(string));
            GenderDt.Rows.Add("Male");
            GenderDt.Rows.Add("Female");
            FillLookUpEdit(GenderDt, "Gender", "Gender", lueGender);
            lueGender.EditValue = GenderDt.Rows[0][0].ToString();
        }
        public void GetNationalityFn()
        {
            NationalityDt = new DataTable();
            NationalityDt.Columns.Add("ID", typeof(int));
            NationalityDt.Columns.Add("Nationality", typeof(string));
            NationalityDt.Rows.Add(1, "Egyptian");
            FillLookUpEdit(NationalityDt, "ID", "Nationality", lueNationality);
            lueNationality.EditValue = NationalityDt.Rows[0][0];
        }

        public void GetHousingFn()
        {
            HousingDT = new DataTable();
            HousingDT.Columns.Add("ID", typeof(int));
            HousingDT.Columns.Add("Housing", typeof(string));
            HousingDT.Rows.Add(1, "Housing");
            FillLookUpEdit(HousingDT, "ID", "Housing", lueHousing);
            lueHousing.EditValue = HousingDT.Rows[0][0];
        }
        public AddEmpFrm()
        {
            InitializeComponent();
        }

        private void EmployeesFrm_Load(object sender, EventArgs e)
        {
            // dtHiringDate.EditValue = dtInsuranceDate.EditValue = ClassesFdr.GeneralVarClass.sysDate;
            GetChartAccountFn();
            GetGenderFN();
            GetNationalityFn();
            GetHousingFn();
            GetEffectType();
            GetEffetcTo();
            GetEffetcTo();
            GetCurrency();
            GetGeneTypesFn();
        }

        private void BtnGrid_Click(object sender, EventArgs e)
        {
            saveGeneQry = "";
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "GeneID").ToString() == "")
                {
                    saveGeneQry += " insert into HRGeneTbl (EmpID, GeneTypeID, GeneValue, EffectType, EffectingTo, ValidFrom, ValidTo, Description, IsTaxable, Currency) " +
                     "values (" + employeesLue.EditValue + ", " + gridView1.GetRowCellValue(i, "GeneTypeID") + ", " + gridView1.GetRowCellValue(i, "GeneValue") + ", " +
                     gridView1.GetRowCellValue(i, "EffectType") + ", " + gridView1.GetRowCellValue(i, "EffectingTo") + ", '" + gridView1.GetRowCellValue(i, "ValidFrom") + "', '" +
                     gridView1.GetRowCellValue(i, "ValidTo") + "', N'" + gridView1.GetRowCellValue(i, "Description") + "', " + (gridView1.GetRowCellValue(i, "IsTaxable")?.ToString() == "" ? 0 : Convert.ToInt32(gridView1.GetRowCellValue(i, "IsTaxable"))) + ", N'" +
                     gridView1.GetRowCellValue(i, "Currency") + "');";

                }
                else
                {
                     saveGeneQry += " UPDATE HRGeneTbl SET " +
                     "GeneValue = " + gridView1.GetRowCellValue(i, "GeneValue") + ", " +
                     "EffectType = " + gridView1.GetRowCellValue(i, "EffectType") + ", " +
                     "EffectingTo = " + gridView1.GetRowCellValue(i, "EffectingTo") + ", " +
                     "ValidFrom = '" + gridView1.GetRowCellValue(i, "ValidFrom") + "', " +
                     "ValidTo = '" + gridView1.GetRowCellValue(i, "ValidTo") + "', " +
                     "Description = N'" + gridView1.GetRowCellValue(i, "Description") + "', " +
                     "IsTaxable = " + (gridView1.GetRowCellValue(i, "IsTaxable")?.ToString() == "" ? 0 : Convert.ToInt32(gridView1.GetRowCellValue(i, "IsTaxable"))) + ", " +
                     "Currency = N'" + gridView1.GetRowCellValue(i, "Currency") + "' " +
                     "WHERE EmpID = " + employeesLue.EditValue +
                     "AND GeneID = " + gridView1.GetRowCellValue(i, "GeneID") + ";";
                }

            }
            DBObj.saveway(saveGeneQry);
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridDt.Rows.Clear();
            getGridDataFn();
        }

        public void GetEffectType()
        {
            EffectTypeDt = new DataTable();
            EffectTypeDt.Columns.Add("Type", typeof(string));
            EffectTypeDt.Columns.Add("ID", typeof(int));
            EffectTypeDt.Rows.Add("Increase", 1);
            EffectTypeDt.Rows.Add("Decrease", 2);
            FillGridLookUpEdit(lueeEffectType, EffectTypeDt, "ID", "Type");
        }
        public void GetEffetcTo()
        {
            getGeneTypes = "select * from HRGeneTypesTbl";
            FillGridLookUpEdit(lueeEffectingTo, DBObj.dataget(getGeneTypes, "get"), "GeneTypeID", "GeneName");
        }


        public void GetCurrency()
        {
            getCurrency = "select CurrName from CurrencyTbl";
            FillGridLookUpEdit(lueeCurrency, DBObj.dataget(getCurrency, "get"), "CurrName", "CurrName");
        }

        public void GetGeneTypesFn()
        {
            getGeneTypes = "select * from HRGeneTypesTbl";
            FillGridLookUpEdit(LueeGeneType, DBObj.dataget(getGeneTypes, "get"), "GeneTypeID", "GeneName");
        }

        private void getGridDataFn()
        {
            getGridData = $"select * from HRGeneTbl where EmpID = {employeesLue.EditValue}";
            GridDt = DBObj.dataget(getGridData, "get");
            gridControl1.DataSource = GridDt;
        }
        private void newEmpSw_Toggled(object sender, EventArgs e)
        {
            if (newEmpSw.IsOn == true)
            {
                employeeLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                GridDt.Rows.Clear();
            }
            else
            {
                employeeLayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                currenyEmpQry = "Select emp.EmpID, cont.ContactName, emp.ContactNu, emp.ChartAccount, emp.BirthDate, emp.Gender, emp.NationalityID, emp.HiringDate,"
                            + " emp.Education, emp.HousingID, emp.SocialInsNumber, emp.SocialInsStartDate, emp.MedicalCertExpDate,"
                            + " cont.Address, cont.Phone1, cont.ContactTypeID " 
                            + " From ContactsTbl cont Inner Join HREmployeesTbl emp ON cont.ContactNu = emp.ContactNu "
                            + " Order By emp.EmpID DESC";
                currentEmpDT = DBObj.dataget(currenyEmpQry, "get");
                //employeesLue.Properties.DataSource = currentEmpDT;
                FillLookUpEdit(currentEmpDT, "EmpID", "ContactName", employeesLue);

                if(currentEmpDT.Rows.Count > 0)
                {
                    employeesLue.EditValue = currentEmpDT.Rows[0][0];
                }
                getGridDataFn();
            }
        }

        DataRow[] selectedEmployeeDR;
        private void employeesLue_EditValueChanged(object sender, EventArgs e)
        {
            selectedEmployeeDR = currentEmpDT.Select("EmpID = " + employeesLue.EditValue + "");

            txtEmployeeName.Text = selectedEmployeeDR[0]["ContactName"].ToString();
            txtAddress.Text = selectedEmployeeDR[0]["Address"].ToString();
            dtBirthDate.EditValue = Convert.ToDateTime(selectedEmployeeDR[0]["BirthDate"]);
            lueNationality.EditValue = selectedEmployeeDR[0]["NationalityID"].ToString();
            lueGender.EditValue = selectedEmployeeDR[0]["Gender"].ToString();
            lueHousing.EditValue = selectedEmployeeDR[0]["HousingID"];
            txtPhone.Text = selectedEmployeeDR[0]["Phone1"].ToString();
            txtInsuranceNumber.Text = selectedEmployeeDR[0]["SocialInsNumber"].ToString();
            dtInsuranceDate.EditValue = Convert.ToDateTime(selectedEmployeeDR[0]["SocialInsStartDate"]);
            dtHiringDate.EditValue = Convert.ToDateTime(selectedEmployeeDR[0]["HiringDate"]);
            dtMedicalDate.EditValue = Convert.ToDateTime(selectedEmployeeDR[0]["MedicalCertExpDate"]);
            chartAccLue.EditValue = selectedEmployeeDR[0]["ChartAccount"].ToString();
            getGridDataFn();
        }
        private void AddNewFn()
        {
            if (txtEmployeeName.Text != "")
            {
                try
                {
                    contactNu = Convert.ToInt32(DBObj.dataget("Select MAX(ContactNu) From ContactsTbl", 0)) + 1;
                }
                catch
                {
                    contactNu = 1;
                }

                //saveQry = "Insert Into ContactsTbl (ContactNu, ContactName, Address, Phone1, ContactTypeID, UserID)"
                //        + " Values (" + contactNu + " , N'" + txtEmployeeName.Text + "' , N'" + txtAddress.Text + "' ,"
                //        + " N'" + txtPhone.Text + "' , '3' , " + ClassesFdr.GeneralVarClass.userID + ")"
                //        + " Insert Into HREmployeesTbl (ContactNu, ChartAccount, BirthDate, Gender, NationalityID, HiringDate,"
                //        + " Education, HousingID, SocialInsNumber, SocialInsStartDate, MedicalCertExpDate, NationalID, AddUser)"
                //        + " Values (" + contactNu + " , N'" + chartAccLue.EditValue + "' , '" + dtBirthDate.EditValue + "' ,"
                //        + " N'" + lueGender.EditValue.ToString() + "' , " + lueNationality.EditValue + " , '" + dtHiringDate.EditValue + "' ,"
                //        + " N'', " + lueHousing.EditValue + " , N'" + txtInsuranceNumber.Text + "' , '" + dtInsuranceDate.EditValue + "' ,"
                //        + " '" + dtMedicalDate.EditValue + "', N'"+ txtNationalID.Text +"' , " + ClassesFdr.GeneralVarClass.userID + "); SELECT @@IDENTITY;";

                saveQry = "Insert Into ContactsTbl (ContactNu, ContactName, Address, Phone1, ContactTypeID, UserID)"
                        + " Values (" + contactNu + " , N'" + txtEmployeeName.Text + "' , N'" + txtAddress.Text + "' ,"
                        + " N'" + txtPhone.Text + "' , '3' , " + '1' + ")"
                        + " Insert Into HREmployeesTbl (ContactNu, ChartAccount, BirthDate, Gender, NationalityID, HiringDate,"
                        + " Education, HousingID, SocialInsNumber, SocialInsStartDate, MedicalCertExpDate, AddUser)"
                        + " Values (" + contactNu + " , N'" + chartAccLue.EditValue + "' , '" + dtBirthDate.EditValue + "' ,"
                        + " N'" + lueGender.EditValue.ToString() + "' , " + lueNationality.EditValue + " , '" + dtHiringDate.EditValue + "' ,"
                        + " N'', " + lueHousing.EditValue + " , N'" + txtInsuranceNumber.Text + "' , '" + dtInsuranceDate.EditValue + "' ,"
                        + " '" + dtMedicalDate.EditValue + "', " + '1' + "); " +
                        "SELECT @@IDENTITY;";
                int id = DBObj.SaveWithReturnIdentity(saveQry);
                employeesLue.EditValue = id;
                if (id > 0)
                {
                    XtraMessageBox.Show("تمت الإضافة بنجاح", "Done");
                    // txtEmployeeName.Text = txtAddress.Text = txtPhone.Text = txtInsuranceNumber.Text = "";
                }

            }
            else
            {
                XtraMessageBox.Show("أكتب اسم الموظف", "Empty Name");
            }
        }
        private void EditOldFn()
        {
            //NationalID = N'"+ txtNationalID.Text + "'
            if (txtEmployeeName.Text != "")
            {
                contactNu = Convert.ToInt32(currentEmpDT.Select("EmpID = "+ employeesLue.EditValue + "")[0]["ContactNu"]);

                saveQry = "Update ContactsTbl SET ContactName = N'" + txtEmployeeName.Text + "', Address = N'" + txtAddress.Text + "',"
                        + " Phone1 = N'" + txtPhone.Text + "' Where ContactNu = " + contactNu + ""
                        + " Update HREmployeesTbl SET ChartAccount = N'" + chartAccLue.EditValue + "', BirthDate = '" + dtBirthDate.EditValue + "',"
                        + " Gender = N'" + lueGender.EditValue.ToString() + "', NationalityID = " + lueNationality.EditValue + ", HiringDate = '" + dtHiringDate.EditValue + "',"
                        + " HousingID = " + lueHousing.EditValue + ", SocialInsNumber = N'" + txtInsuranceNumber.Text + "', SocialInsStartDate = '" + dtInsuranceDate.EditValue + "',"
                        + " MedicalCertExpDate = '" + dtMedicalDate.EditValue + "' " + 
                          "Where EmpID = " + employeesLue.EditValue + " Select " + employeesLue.EditValue + "";

                if (DBObj.SaveWithReturnIdentity(saveQry) > 0)
                {


                    XtraMessageBox.Show("نم الحفظ بنجاح", "Done");
                    //txtEmployeeName.Text = txtAddress.Text = txtPhone.Text = txtInsuranceNumber.Text = "";
                }
            }
            else
            {
                XtraMessageBox.Show("أكتب اسم الموظف", "Empty Name");
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(newEmpSw.IsOn) 
            {
                AddNewFn();
            }
            else
            {
                EditOldFn();
            }
        }
    }
}