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
using static System.Math;

namespace WFs
{
    public partial class GeneTypeFrm : DevExpress.XtraEditors.XtraForm
    {
        string getQry, insQry, delQry;
        DataTable GeneTypesDt;
        DBClass DBObj = new DBClass();
        public GeneTypeFrm()
        {
            InitializeComponent();
        }
        public void GetGeneTypesDataFn()
        {
            getQry = "select * from HRGeneTypesTbl";
            GeneTypesDt = DBObj.dataget(getQry, "get");
            gridControl1.DataSource = GeneTypesDt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insQry = "";
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "GeneTypeID").ToString() == "")
                {
                    insQry += $"insert into HRGeneTypesTbl (GeneName) values (N'{gridView1.GetRowCellValue(i, "GeneName")}'); ";
                }
                else
                {
                    insQry += $" update HRGeneTypesTbl set GeneName = N'{gridView1.GetRowCellValue(i, "GeneName")}' where GeneTypeID = {gridView1.GetRowCellValue(i, "GeneTypeID")} ";
                }
            }
            DBObj.saveway(insQry);
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GeneTypesDt.Clear();
            GetGeneTypesDataFn();
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
                    if (gridView1.GetFocusedRowCellValue("GeneTypeID") == null || gridView1.GetFocusedRowCellValue("GeneTypeID").ToString() == "")
                    {
                        if (view != null)
                        {
                            view.DeleteRow(view.FocusedRowHandle);
                        }
                    }
                    else
                    {
                        delQry = $@"if not exists(select distinct GeneTypeID from HRGeneTbl where GeneTypeID = {gridView1.GetFocusedRowCellValue("GeneTypeID")}) delete HrGeneTypesTbl where GeneTypeID = {gridView1.GetFocusedRowCellValue("GeneTypeID")}";
                        int id = DBObj.saveway(delQry);
                        if (id > 0)
                        {
                            XtraMessageBox.Show("تم الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GeneTypesDt.Rows.Clear();
                            GetGeneTypesDataFn();
                        }
                        else if (id == -1)
                        {
                            MessageBox.Show("هذا السطر لا يمكن حذفه");
                        }
                    }
                }
            }
        }
        
        private void GeneTypeFrm_Load(object sender, EventArgs e)
        {
            GetGeneTypesDataFn();
        }

    }
}