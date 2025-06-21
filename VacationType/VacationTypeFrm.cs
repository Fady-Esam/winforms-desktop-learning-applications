using DevExpress.XtraEditors;
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
    public partial class VacationTypeFrm : DevExpress.XtraEditors.XtraForm
    {
        string getQry, insQry, delQry;
        DataTable VacationTypesDt;
        DBClass DBObj = new DBClass();
        public VacationTypeFrm()
        {
            InitializeComponent();
        }

        public void GetVacationTypeFn()
        {
            getQry = "select * from HRAttendTypeTbl";
            VacationTypesDt = DBObj.dataget(getQry, "get");
            gridControl1.DataSource = VacationTypesDt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            insQry = "";
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, "AttendTypeID").ToString() == "")
                {
                    insQry += $" insert into HRAttendTypeTbl (AttendType) values (N'{gridView1.GetRowCellValue(i, "AttendType")}'); ";
                }
                else
                {
                    insQry += $" update HRAttendTypeTbl set AttendType = N'{gridView1.GetRowCellValue(i, "AttendType")}' where AttendTypeID = {gridView1.GetRowCellValue(i, "AttendTypeID")} ";
                }
            }
            DBObj.saveway(insQry);
            XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VacationTypesDt.Rows.Clear();
            GetVacationTypeFn();
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
                    if (gridView1.GetFocusedRowCellValue("AttendTypeID") == null || gridView1.GetFocusedRowCellValue("AttendTypeID").ToString() == "")
                    {
                        if (view != null)
                        {
                            view.DeleteRow(view.FocusedRowHandle);
                        }
                    }
                    else
                    {
                        delQry = $@"if not exists(select distinct AttendTypeID from HRAttendanceTbl where AttendTypeID = {gridView1.GetFocusedRowCellValue("AttendTypeID")}) delete HRAttendTypeTbl where AttendTypeID = {gridView1.GetFocusedRowCellValue("AttendTypeID")}";
                        int id = DBObj.saveway(delQry);
                        if (id > 0)
                        {
                            XtraMessageBox.Show("تم الحذف  بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VacationTypesDt.Rows.Clear();
                            GetVacationTypeFn();
                        }
                        else if (id == -1)
                        {
                            MessageBox.Show("هذا السطر لا يمكن حذفه");
                        }
                    }
                }
            }
        }

        private void VacationTypeFrm_Load(object sender, EventArgs e)
        {
            GetVacationTypeFn();
        }
    }
}