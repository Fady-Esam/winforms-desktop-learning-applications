using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class CustomerGroupFrm : DevExpress.XtraEditors.XtraForm
    {

        DataTable mainGroupDT, groupsDT;
        string mainGroupQry, groupsQry;
        DBClass DBObj = new DBClass();


        public CustomerGroupFrm()
        {
            InitializeComponent();
        }

        private void CustomerGroupFrm_Load(object sender, EventArgs e)
        {
            GetGroupsFn();
            GetBranchInfo();
        }

        private void GetGroupsFn()
        {
            groupsQry = "Select GroupID, GroupName, MainGroup, IsFast From CustomersGroupTbl";
            groupsDT = DBObj.dataget(groupsQry, "get");
            gridControl1.DataSource = groupsDT;
        }

        private void GetBranchInfo()
        {
            mainGroupDT = new DataTable();
            mainGroupDT.Columns.Add("MainGroup", typeof(string));
            mainGroupDT.Rows.Add("الشركة");
            mainGroupDT.Rows.Add("معارض");
            MainGroupLue.DataSource = mainGroupDT;
            MainGroupLue.DisplayMember = "MainGroup";
            MainGroupLue.ValueMember = "MainGroup";
        }

    }
}