using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class TaxesRules : DevExpress.XtraEditors.XtraForm
    {
        string getQry, saveQry, DelQry;
        DBClass DBobj = new DBClass();
        DataTable GridDt;
        public TaxesRules()
        {
            InitializeComponent();
        }

        private void TaxesRules_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            getQry = "select * from TaxRules";
            GridDt = DBobj.dataget(getQry, "get");
            GridControl1.DataSource = GridDt;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveQry = "";
            for (int i = 0; i < GridView1.RowCount; i++)
            {
                if (GridView1.GetRowCellValue(i, "RuleID").ToString() == "")
                {
                    saveQry += $@"insert into TaxRules(MinSalary, MaxSalary, TaxRate, DateFrom, DateTo) 
                    values ({GridView1.GetRowCellValue(i, "MinSalary")}, {GridView1.GetRowCellValue(i, "MaxSalary")}, 
                    {GridView1.GetRowCellValue(i, "TaxRate")}, '{GridView1.GetRowCellValue(i, "DateFrom")}', 
                    '{GridView1.GetRowCellValue(i, "DateTo")}'); ";
                }

                else
                {
                    saveQry += $@" UPDATE TaxRules 
                    SET MinSalary = {GridView1.GetRowCellValue(i, "MinSalary")}, 
                        MaxSalary = {GridView1.GetRowCellValue(i, "MaxSalary")}, 
                        TaxRate = {GridView1.GetRowCellValue(i, "TaxRate")}, 
                        DateFrom = '{GridView1.GetRowCellValue(i, "DateFrom")}', 
                        DateTo = '{GridView1.GetRowCellValue(i, "DateTo")}' 
                    WHERE TaxRuleID = {GridView1.GetRowCellValue(i, "RuleID")}; ";
                }
            }
            DBobj.saveway(saveQry);
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridDt.Rows.Clear();
            GetData();
        }

        private void GridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                if (MessageBox.Show("هل تريد الحذف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    return;
                else
                {
                    if (GridView1.GetFocusedRowCellValue("RuleID") == null || GridView1.GetFocusedRowCellValue("RuleID").ToString() == "")
                    {
                        if (view != null)
                        {
                            view.DeleteRow(view.FocusedRowHandle);
                        }
                    }
                    else
                    {
                        DelQry = "DELETE TaxRules WHERE TaxRuleID = " + GridView1.GetFocusedRowCellValue("RuleID") + " ";
                        DBobj.saveway(DelQry);
                        XtraMessageBox.Show("تم الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridDt.Rows.Clear();
                        GetData();
                    }
                }
            }
        }

    }

}
