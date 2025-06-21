
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.TextEditController.Win32;
using HR;
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
    public partial class CreatePenalty : DevExpress.XtraEditors.XtraForm
    {
        DBClass DBCls = new DBClass();
        DataTable EmpoyeesDT;
        string getEmpsQry, getBrchsQry, getCurrencyQry, getAppliedFromQry,  insDedQry;
        public CreatePenalty()
        {
            InitializeComponent();
        }

        private void CreatePenalty_Load(object sender, EventArgs e)
        {
            FillLookUpEdits();

            if (RadioGroup2.SelectedIndex == 0)
            {
                GroupControl1.Visible = false;
                teDeductionAmount.Enabled = true;
            }
            else
            {
                GroupControl1.Visible = true;
                teDeductionAmount.Enabled = false;
            }
        }
        private void FillLookUpEdit(LookUpEdit name, DataTable dt, string valueMember, string displayMember)
        {
            name.Properties.DataSource = dt;
            name.Properties.ValueMember = valueMember;
            name.Properties.DisplayMember = displayMember;
        }

        private void FillEmployeeLue()
        {
            getEmpsQry = $@"select cont.ContactName, emp.EmpID from ContactsTbl cont inner join HREmployeesTbl emp
                                on cont.ContactNu = emp.ContactNu where cont.BranchID = {lueBranch.EditValue}";
            EmpoyeesDT = DBCls.dataget(getEmpsQry, "get");
            FillLookUpEdit(lueEmployee, EmpoyeesDT, "EmpID", "ContactName");
            if(EmpoyeesDT.Rows.Count > 0)
                lueEmployee.EditValue = EmpoyeesDT.Rows[0]["EmpID"];
        }
        private void FillLookUpEdits()
        {
            getBrchsQry = "select BranchID, BranchName from BranchsTbl";
            FillLookUpEdit(lueBranch, DBCls.dataget(getBrchsQry, "get"), "BranchID", "BranchName");
            lueBranch.EditValue = 1;
            FillLookUpEdit(lueDeduction, DBCls.dataget("Select DeductionID, DeductionName from HRDeductionItemsTbl", "get"), "DeductionID", "DeductionName");
            lueDeduction.EditValue = 1;
            FillEmployeeLue();
            getCurrencyQry = "select CurrName from CurrencyTbl";
            FillLookUpEdit(lueCurrency, DBCls.dataget(getCurrencyQry, "get"), "CurrName", "CurrName");
            getAppliedFromQry = "select GeneTypeID, GeneName from HRGeneTypesTbl";
            FillLookUpEdit(lueAppliedFrom, DBCls.dataget(getAppliedFromQry, "get"), "GeneTypeID", "GeneName");
        }

        private void AddNew()
        {
            lueEmployee.EditValue = null;
            teDeductionAmount.EditValue = 0;
            chboxApplyExchangeRate.Checked = false;
            lueCurrency.EditValue = null;
            meReason.EditValue = null;
            teDaysDeduction.EditValue = null;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
             // Apply();
            // AddNew();
        }

        private void GetDueSalary()
        {
            //try
            //{
            //    string Str = @"SELECT Convert(Decimal(10,2),ValueGene) As Salary FROM tblGene 
            //                      WHERE 
            //                         TypeGene=1 AND ContactNu='" + lueEmployee.EditValue + @"'
            //                         AND '" + deDeductDate.EditValue + @"' BETWEEN ValidFrom 
            //                         AND ValidTo AND BranchID =" + System.Convert.ToInt32(lueBranch.EditValue);
            //    DataTable DueSalaryDT = DBCls.dataget(Str, "get");
            //    if (DueSalaryDT.Rows.Count > 0)
            //        lblSalaryEmployeeValue.Text = System.Convert.ToDecimal(DueSalaryDT.Rows(0)("Salary"));
            //    else
            //        lblSalaryEmployeeValue.Text = 0;
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message, "Get Salary");
            //}

        }

        private void lueEmployee_EditValueChanged(object sender, EventArgs e)
        {
            if (RadioGroup2.SelectedIndex == 0)
            {
                GroupControl1.Visible = false;
                teDeductionAmount.Enabled = true;
            }
            else
            {
                GroupControl1.Visible = true;
                GetDueSalary();
                CalcPenaltiesByDays();
                teDeductionAmount.Enabled = false;
            }

        }
        private void deDeductDate_EditValueChanged(object sender, EventArgs e)
        {
            if (deDeductFromDate.EditValue == null)
                return;
            if (RadioGroup2.SelectedIndex == 0)
            {
                GroupControl1.Visible = false;
                teDeductionAmount.Enabled = true;
            }
            else
            {
                GroupControl1.Visible = true;
                GetDueSalary();
                CalcPenaltiesByDays();
                teDeductionAmount.Enabled = false;
            }
        }

        private void RadioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDueSalary();
            if (RadioGroup2.SelectedIndex == 0)
            {
                GroupControl1.Visible = false;
                teDeductionAmount.Enabled = true;
            }
            else
            {
                GroupControl1.Visible = true;
                GetDueSalary();
                teDeductionAmount.Enabled = false;
            }
        }

        private void CalcPenaltiesByDays()
        {
            if (RadioGroup2.SelectedIndex == 1)
            {
                if (chboxApplyExchangeRate.Checked == false)
                {
                    teDeductionAmount.EditValue = 0;
                    //teDeductionAmount.EditValue = Val(double.Parse(lblSalaryEmployeeValue.Text) / 30 * double.Parse(teDaysDeduction.EditValue));
                }
                else
                {
                    teDeductionAmount.EditValue = 0;
                    //teDeductionAmount.EditValue = Val(double.Parse(lblSalaryEmployeeValue.Text * lblRate.Text) / 30 * double.Parse(teDaysDeduction.EditValue));
                }
            }
        }



        private void teDaysDeduction_EditValueChanged(object sender, EventArgs e)
        {
            //if (teDaysDeduction.EditValue == "" || teDaysDeduction.EditValue == 0)
            //    return;
            CalcPenaltiesByDays();
        }

        private void lueCurrency_EditValueChanged(object sender, EventArgs e)
        {
            CalcPenaltiesByDays();
        }

        private void chboxApplyExchangeRate_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioGroup2.SelectedIndex > 0)
            {
                GetDueSalary();
                CalcPenaltiesByDays();
            }
        }

        private void btnContactDetails_Click(object sender, EventArgs e)
        {
        }

        private void lueBranch_EditValueChanged_1(object sender, EventArgs e)
        {
            FillEmployeeLue();
        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {
            insDedQry = $@"insert into HRDeductionsTbl (EmpID, DeductionID, DeductionAmount, DateFrom, DateTo, Details) 
                        values ({lueEmployee.EditValue}, {lueDeduction.EditValue}, {teDeductionAmount.EditValue}, '{deDeductFromDate.EditValue}', '{deDeductToDate.EditValue}', N'{meReason.Text}') ;";
            
            if(DBCls.saveway(insDedQry) > 0)
                MessageBox.Show("تم حفظ البيانات بنجاح");
        }
    }
}
