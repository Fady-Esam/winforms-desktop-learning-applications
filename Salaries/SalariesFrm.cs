using DevExpress.Utils.Extensions;
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
    public partial class SalariesFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass DBobj = new DBClass();
        string getQry;
        DataTable GridDt;
        public SalariesFrm()
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

        private void GetBranches()
        {
            FillLookUpEdit(lueBranches, DBobj.dataget("select BranchID, BranchName from BranchsTbl", "get"), "BranchID", "BranchName");
            lueBranches.EditValue = 1;
        }
        
        private void GetData()
        {
            getQry = $@"
                SELECT gen.Currency, gen.Description, brch.BranchName, genTyp.GeneName, gen.IsTaxable, cont.ContactName, jobTi.JobTitle, jobTi.TaxIndication, dep.DepName, jobTi.InsIndication, 0 AS Salary, 0 AS IncomeTax, SUM(ded.DeductionAmount) AS totalDeduct, 0 AS DueSalary
                FROM ContactsTbl cont 
                INNER JOIN HREmployeesTbl emp ON cont.ContactNu = emp.ContactNu
                INNER JOIN HRJobTitlesTbl jobTi ON emp.EmpID = jobTi.EmpID
                INNER JOIN HRDepartmentsTbl dep ON jobTi.DepartmentID = dep.DepID 
                INNER JOIN HRGeneTbl gen ON emp.EmpID = gen.EmpID
                INNER JOIN HRGeneTypesTbl genTyp ON gen.GeneTypeID = genTyp.GeneTypeID
                INNER JOIN HRDeductionsTbl ded ON emp.EmpID = ded.EmpID
                INNER JOIN BranchsTbl brch ON cont.BranchID = brch.BranchID
                WHERE cont.BranchID = {lueBranches.EditValue}
                GROUP BY gen.Currency, gen.Description, brch.BranchName, genTyp.GeneName, gen.IsTaxable, cont.ContactName, jobTi.JobTitle, jobTi.TaxIndication, dep.DepName, jobTi.InsIndication;
            ";
            GridDt = DBobj.dataget(getQry, "get");
            gridControl1.DataSource = GridDt;
        }
        private void SalariesFrm_Load(object sender, EventArgs e)
        {
            GetBranches();
            GetData();
        }
        private void lueBranches_EditValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var report = new rptSalaries();
            //report.DataSource = gridControl1.DataSource;
            //report.CreateDocument();
            //var printTool = new ReportPrintTool(report);
            //printTool.ShowPreviewDialog();
        }
    }
}